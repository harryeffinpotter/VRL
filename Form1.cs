using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace VRL
{
    public partial class Form1 : Form
    {
        public static string currdir = Environment.CurrentDirectory;
        public static bool autosearch = false;
        public static bool qs = false;
        public static bool FFARM = false;
        public static bool FFARE = false;
        public static string CLIDir = "";
        public static string exefull = "";
        public static bool customname = false;
        public static bool foundGame = false;
        public static string batname = "";
        public static bool hasGameSelected = false;
        public static string SelectExe = "";
        public static bool GAM = false;
        public static string gamefolderpath = "";
        public static string SelectExePath = "";
        public static string gamefoldername = "";
        public static string gamedir = "";
        public static string inilines = "";

        public static string filenoexe = "";
        readonly string Airlink = "-oculus -oculus vr -vrmode oculus";
        public Form1()
        {
            InitializeComponent();
            if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\VRL\\GAM"))
             GAM = true;

        
            if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\VRL\\FilePath.txt"))
            {
                qs = true;
                string[] CLI = File.ReadAllLines($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\VRL\\FilePath.txt");
                foreach (string line in CLI)
                {
                    if (!String.IsNullOrWhiteSpace(line) && line.Contains("\\"))
                    {
                        CLIDir = line;
                        CLIDir = CLIDir.Replace("/n", "");
                        CLIDir = CLIDir.Replace("/r", "");
                        FFARM = true;
                        qs = true;
                        autosearch = true;
                        Properties.Settings.Default.LastDir = line;
                        Properties.Settings.Default.Save();
                        gamefolderpath = CLIDir.Replace("\"","");
                        CLIDir = CLIDir.Replace("\"", "");
                        gamefolderpath = Path.GetFullPath(gamefolderpath);
                        gamefoldername = Path.GetFileName(gamefolderpath);
                        string ExeTitleIni = Path.GetFileName(gamefolderpath);
                        gameDirTextBox.Text = CLIDir;
                  
                        string dirsize = GetFolderSize(gamefolderpath);
                        IniFileEdit($"\"..\\..\\Settings.ini\" [Settings] Size={dirsize}");
             
                        IniFileEdit($"\"..\\..\\Settings.ini\" [PathName] ExeTitle={ExeTitleIni}");
                        IniFileEdit($"\"..\\..\\Settings.ini\" [Settings] Name={ExeTitleIni}");
                        File.WriteAllText("gname.txt", gamefoldername);//When user selects C:/Whatever/Half-Life Alyx/ this will take Half-Life Alyx from it and use it for the shortcut titl

                    }



                }
            
            ExeFind_Method();
            }
            else
            {
                FFARM = false;
                FFARE = true;
            }
        }

    


        public static string GetValidFileName(string fileName)
        {
            // remove any invalid character from the filename.
            String ret = Regex.Replace(fileName.Trim(), "[^A-Za-z0-9_. ]+", "");
            return ret.Replace(" ", String.Empty);
        }

        private void selectGameButton_Click(object sender, EventArgs e)

        {
            FolderSelectDialog folderSelectDialog = new FolderSelectDialog();
            folderSelectDialog.Title = "Select the game's main folder.";

            if (Properties.Settings.Default.LastDir.Length > 0)
                folderSelectDialog.InitialDirectory = Properties.Settings.Default.LastDir;

            if (folderSelectDialog.Show(Handle))
            {
                gameDirTextBox.Text = folderSelectDialog.FileName;
                gamefolderpath = folderSelectDialog.FileName;
                Properties.Settings.Default.LastDir = folderSelectDialog.FileName;
                Properties.Settings.Default.Save();//Game Directory for target/working dirs set here, can be replaced by manual select.
                gamefoldername = Path.GetFileName(folderSelectDialog.FileName);
                File.WriteAllText("gname.txt", $"\"{gamefoldername}\"");//When user selects C:/Whatever/Half-Life Alyx/ this will take Half-Life Alyx from it and use it for the shortcut title.
            }
            else return;


            ExeFind_Method();

        }

        public void ExeFind_Method()
        {

            foreach (string folder in Directory.EnumerateDirectories(gamefolderpath, "*_data", SearchOption.AllDirectories))
            {
                foreach (string file in Directory.EnumerateFiles(gamefolderpath, "*.exe", SearchOption.TopDirectoryOnly))
                {
                   
                    if (!file.Contains("(VD)") && !file.Contains("(OtherHMDs)") && !file.Contains("(VD+Steam)") && !file.Contains("(Link)") && !file.Contains("(Link+Steam)"))
                    {
                        string dironly = Path.GetDirectoryName(folder).ToLower();
                        string filename = Path.GetFileNameWithoutExtension(file);
                        filename = filename.ToLower();
                        string cutfolder = folder.Remove(folder.Length - 5);
                        cutfolder = folder.ToLower();
                        if (folder.ToLower().Contains(filename))
                        {
                            SelectExe = Path.GetFileName(file);
                            gameDirTextBox.Text = SelectExe;
                            TopLABEL.Text = "Game Found!";
                            filenoexe = Path.GetFileNameWithoutExtension(file);
                            foundGame = true;
                            gamedir = Path.GetDirectoryName(file);
                            SelectExePath = file;
                            hasGameSelected = true;
                            break;
                        }
                        if (!foundGame)
                            cutfolder = cutfolder.Replace(" ", "");


                        if (filename.Contains(cutfolder))
                        {
                            SelectExe = Path.GetFileName(file);
                            gameDirTextBox.Text = SelectExe;
                            TopLABEL.Text = "Game Found!";
                            filenoexe = Path.GetFileNameWithoutExtension(file);
                            foundGame = true;
                            gamedir = Path.GetDirectoryName(file);
                            SelectExePath = file;
                            hasGameSelected = true;
                            break;
                        }

                        if (!foundGame)
                            dironly = dironly.Substring(0, 1);

                        if (filename.StartsWith(dironly))
                        {
                            SelectExe = Path.GetFileName(file);
                            gameDirTextBox.Text = SelectExe;
                            TopLABEL.Text = "Game Found!";
                            filenoexe = Path.GetFileNameWithoutExtension(file);
                            foundGame = true;
                            gamedir = Path.GetDirectoryName(file);
                            SelectExePath = file;
                            hasGameSelected = true;
                            break;
                        }
                    }
                }
            }
            if (!foundGame)
            {
                foreach (string folder in Directory.EnumerateDirectories(gamefolderpath, "*Win64*", SearchOption.AllDirectories))
                {
                    foreach (string file in Directory.EnumerateFiles(gamefolderpath, "*.exe", SearchOption.AllDirectories))
                    {
                        string filename = Path.GetFileName(file).ToLower(); ; //get filename from path and make it lower so it is case insensitive
                        if (filename.Contains("Shipping.exe"))
                        {
                            SelectExe = Path.GetFileName(file);
                            gameDirTextBox.Text = SelectExe;
                            TopLABEL.Text = "Game Found!";
                            filenoexe = Path.GetFileNameWithoutExtension(file);
                            foundGame = true;
                            gamedir = Path.GetDirectoryName(file);
                            SelectExePath = file;
                            hasGameSelected = true;
                            break;
                        }
                    }
                }
                foreach (string folder in Directory.EnumerateDirectories(gamefolderpath, "win64", SearchOption.AllDirectories))
                {
                    foreach (string file in Directory.EnumerateFiles(folder, "*.exe", SearchOption.AllDirectories))
                    {
                        string filename = Path.GetFileName(file).ToLower(); ; //get filename from path and make it lower so it is case insensitive
                        if (filename.Contains("Shipping.exe"))
                        {
                            SelectExe = Path.GetFileName(file);
                            gameDirTextBox.Text = SelectExe;
                            TopLABEL.Text = "Game Found!";
                            filenoexe = Path.GetFileNameWithoutExtension(file);
                            foundGame = true;
                            gamedir = Path.GetDirectoryName(file);
                            SelectExePath = file;
                            hasGameSelected = true;
                            break;
                        }
                        else if (filename.EndsWith(".exe") && !filename.Contains("unis") && !filename.Contains("unityCrashhandler64.exe") && !filename.Contains("crash.exe") &&
                                    !filename.Contains("redist") && !filename.Contains("unity") && !filename.Contains("trial") && !filename.Contains("dx") &&
                                !filename.Contains("(vd)") && !filename.Contains("(otherhmds)") && !filename.Contains("(vd+steam)") && !filename.Contains("(link)") && !filename.Contains("(link+steam)"))
                        {
                            SelectExe = Path.GetFileName(file);
                            gameDirTextBox.Text = SelectExe;
                            TopLABEL.Text = "Game Found!";
                            filenoexe = Path.GetFileNameWithoutExtension(file);
                            foundGame = true;
                            gamedir = Path.GetDirectoryName(file);
                            SelectExePath = file;
                            hasGameSelected = true;
                            break;
                        }
                    }
                }
                if (!foundGame) //here you should do the logic to select the exe from the game folder, do it how you want idk what you want
                {
                    string[] wrd = gamefoldername.Split(' ');
                    //wrd is an array of game name parts

                    foreach (string file2 in Directory.EnumerateFiles(gamefolderpath, "*.exe", SearchOption.AllDirectories))

                    {
                        string filename2 = Path.GetFileName(file2).ToLower(); //get filename from path and make it lower so it is case insensitive

                        bool gameNamePartFound = false;
                        foreach (string GameWrd in wrd)
                        {
                            if (!filename2.Contains("Installer") && filename2.Contains(GameWrd) && !filename2.Contains("unis") && !filename2.Contains("UnityCrashHandler64.exe") && !filename2.Contains("Crash.exe") &&
                                !filename2.Contains("redist") && !filename2.Contains("unity") && !filename2.Contains("trial") && !filename2.Contains("dx") && !filename2.Contains("Unity"))
                            {
                                gameNamePartFound = true;
                                break;
                            }
                        }

                        if (gameNamePartFound && !file2.Contains("(VD)") && !file2.Contains("(OtherHMDs)") && !file2.Contains("(VD+Steam)") && !file2.Contains("(Link)") && !file2.Contains("(Link+Steam)"))
                        {
                            SelectExe = Path.GetFileName(file2);
                            gameDirTextBox.Text = SelectExe;
                            TopLABEL.Text = "Game Found!";
                            filenoexe = Path.GetFileNameWithoutExtension(file2);
                            foundGame = true;
                            gamedir = Path.GetDirectoryName(file2);
                            SelectExePath = file2;
                            hasGameSelected = true;
                            break;

                        }
                        string dataParent = new DirectoryInfo(System.IO.Path.GetDirectoryName(file2)).Name;

                        dataParent = dataParent.Substring(0, 1).ToLower();


                        if (filename2.StartsWith(dataParent) && !filename2.Contains("(VD)") && !filename2.Contains("(OtherHMDs)") && !filename2.Contains("(VD+Steam)") && !filename2.Contains("(Link)") && !filename2.Contains("(Link+Steam)"))
                        {
                            SelectExe = Path.GetFileName(file2);
                            gameDirTextBox.Text = SelectExe;
                            TopLABEL.Text = "Game Found!";
                            filenoexe = Path.GetFileNameWithoutExtension(file2);
                            foundGame = true;
                            gamedir = Path.GetDirectoryName(file2);
                            SelectExePath = file2;
                            hasGameSelected = true;
                            break;
                        }


                    }
                    string box_msg = "";

                    if (!hasGameSelected)
                    {
                        foreach (string file2 in Directory.EnumerateFiles(gamefolderpath, "*.exe", SearchOption.AllDirectories))
                        {
                            box_msg = "EXE could not be automatically found, please select the game EXE manually below.";
                            string box_title = "No EXE found.";
                            selectExeButton.Visible = true;
                            MessageBox.Show(box_msg, box_title);
                            // IDEALLY - I'd like to GREY OUT the run program option and even the SELECT exe button UNTIL this moment, they must specify a game folder for
                            //2 reasons, 1. to search for shipping exe. 2. to give us the game name, sorking directories, all that stuch
                        }

                    }
                }

            }

            if (!foundGame)
            {

                    runProgramButton.Enabled = true;

            }
            else if (FFARM || FFARE)
            {
                MakeShortcuts();
                runProgramButton.Enabled = true;
            }


 
    

        }



        void runProgramButton_Click(object sender, EventArgs e)
        {
            MakeShortcuts();   
        }

        public void IniFileEdit(string args)
        {
            Process IniProcess = new Process();
            IniProcess.StartInfo.CreateNoWindow = true;
            IniProcess.StartInfo.UseShellExecute = false;
            IniProcess.StartInfo.FileName = "inifile.exe";
            IniProcess.StartInfo.Arguments = args;
            IniProcess.Start();
            IniProcess.WaitForExit();
        }
        public void MakeShortcuts()
        { 
            runProgramButton.Enabled = false;
            if (Properties.Settings.Default.FFARM)
            {
                FFARE = true;
            }
            File.WriteAllText("exetitle.txt", $"\"{SelectExe}\"");
            string args = "";
            if (Directory.Exists($"{currdir}\\Temp"))
                Directory.Delete($"{currdir}\\Temp", true);
            File.WriteAllText("currdir.txt", $"\"{currdir}\"");
            Directory.CreateDirectory($"{currdir}\\Temp");
            string disabler = "";
            if (Properties.Settings.Default.ExeDesktop || FFARM)
                disabler = "goto :exit";
            File.WriteAllText("dis.txt", disabler);
            foreach (string arg in argsRichTextBox.Text.Split('\n'))
            {
                args += $" {arg}";
            }
            if (!foundGame)
            {
                MessageBox.Show("You need to select a game first");
                return;
            }
            if (customname && !FFARM)
            {
                gamefoldername = customNameTextBox.Text;
                File.WriteAllText("justexenoexe.txt", $"\"{gamefoldername}\"");

            }
            
            Process BatProcess = new Process();
            BatProcess.StartInfo.CreateNoWindow = true;
            BatProcess.StartInfo.UseShellExecute = false;
            // CREATE ALL REFERENCE TEXTS AT ONCE INSTEAD OF ALL OVER THE DAMN PLACE!
                if (args.Contains("-"))
                    File.WriteAllText("exefullpath.txt", $"\"{SelectExePath}\" {Airlink}{args}");
                else
                    File.WriteAllText("exefullpath.txt", $"\"{SelectExePath}\"");
        
                if (args.Contains("-"))
                    File.WriteAllText("justexe.txt", $"\"{SelectExe}\"{args}");
                else
                    File.WriteAllText("justexe.txt", $"\"{SelectExe}\"");
         
                if (args.Contains("-"))
                    File.WriteAllText("vdfull.txt", $"{Properties.Settings.Default.VDEXE} \"{SelectExePath}\"{args}");
                else
                    File.WriteAllText("vdfull.txt", $"{Properties.Settings.Default.VDEXE} \"{SelectExePath}\""); //Saved or Default VD path + args
         
                if (args.Contains("-"))
                    File.WriteAllText("vdrel.txt", $"{Properties.Settings.Default.VDEXE} \"{SelectExe}\"{args}");
                else 
                    File.WriteAllText("vdrel.txt", $"{Properties.Settings.Default.VDEXE} \"{SelectExe}\""); //Saved or Default VD path + args
                    
            File.WriteAllText("justexenoexe.txt", $"\"{filenoexe}\""); //Complete exe title, to get icon from exe file for shortcut.     
            File.WriteAllText("foundexedir.txt", $"\"{gamedir}\""); //Game directory, for "working directory" and "target path" usages..
      
       
                BatProcess.StartInfo.FileName = "LinkAS.bat";
                BatProcess.Start();
                BatProcess.WaitForExit();
                Bat2Exe(SelectExePath);
                BatProcess.StartInfo.FileName = "VDAS.bat";
                BatProcess.Start();
                BatProcess.WaitForExit();
                Bat2Exe(SelectExePath);
   
        
            if (GAM)
            {
                if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\VRL\\CorrectPath.txt"))
                    File.Delete($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\VRL\\CorrectPath.txt");
                File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\VRL\\CorrectPath.txt", gamedir);
                BatProcess.StartInfo.FileName = "Gam.bat";
                BatProcess.Start();
                BatProcess.WaitForExit();
                Bat2Exe(SelectExePath);
            }


            string[] files = System.IO.Directory.GetFiles(currdir, "*.txt");
            foreach (string file in files)
            {
                if (file.EndsWith(".txt"))
                    System.IO.File.Delete(file);
            }
            if (!FFARM)
            {
                MessageBox.Show("Shortcut Successfully made!");
                gameDirTextBox.Clear();
                TopLABEL.Text = "Select Game Directory:";
                if (File.Exists($"\"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\Sac\\FilePath.txt\""))
                    File.Delete($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\SAC\\FilePath.txt");
            }
            if (FFARM)
            {
                if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\VRL\\FilePath.txt"))
                File.Delete($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\VRL\\FilePath.txt");
                
                string ExePathIni = SelectExePath.Replace($"{CLIDir}", "");
                    ExePathIni = ExePathIni.Remove(0, 1);
                    IniFileEdit($"\"..\\..\\Settings.ini\" [PathName] Path={ExePathIni}");
                
                Environment.Exit(0);
            }
        }
        public static string targetdir = "";
        public static string bat = "";



        //we really should vc if you are going to do more c# stuff in the future, also try to name your stuff from forms, instead of button1 name it what it does
        //dont worry tho, you dont have any experience with coding so ur doing really great, and doing big stuff inc# is very hard
        //if you dont have any prior coding language
        public static string Bat2Exe(string newexe = "")
        {
            IconPullClick(newexe);
            foreach (string file in Directory.EnumerateFiles($"{currdir}\\Temp", "*.bat", SearchOption.TopDirectoryOnly))
            {
                bat = file;
                batname = Path.GetFileNameWithoutExtension(file);
            }
            Process BatProcess = new Process();
            BatProcess.StartInfo.CreateNoWindow = true;
            BatProcess.StartInfo.UseShellExecute = false;
            BatProcess.StartInfo.FileName = $"\"{currdir}\\go.exe\"";
            BatProcess.StartInfo.Arguments = $"/bat \"{bat}\" /exe \"{currdir}\\Temp\\{batname}.exe\" /icon \"{Environment.CurrentDirectory}\\Temp\\temp.ico\" /overwrite";
            BatProcess.Start();
            BatProcess.WaitForExit();
            foreach (string file in Directory.EnumerateFiles($"{currdir}\\Temp", "*.exe", SearchOption.TopDirectoryOnly))
            {
                string newfile = "";
                string justfilename = Path.GetFileName(file);
                if (FFARM || FFARE)
                {
                    newfile = $"{gamedir}\\{justfilename}";
                }
                else
                    newfile = $"{currdir}\\My Launchers\\{justfilename}";

                if (File.Exists(newfile))
                    File.Delete(newfile);
                File.Move(file, newfile);

            }
            if (Directory.Exists($"{currdir}\\Temp"))
                Directory.Delete($"{currdir}\\Temp", true);
            Directory.CreateDirectory($"{currdir}\\Temp");
            return newexe;
        }

        private void selectExeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Game's main exe |*.exe"; //only show .exe files or shortcuts
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                exefull = System.IO.Path.GetFullPath(openFileDialog.FileName);
                gamedir = Path.GetDirectoryName(openFileDialog.FileName);
                filenoexe = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                openFileDialog.InitialDirectory = gameDirTextBox.Text;
                SelectExePath = openFileDialog.FileName;
                SelectExe = System.IO.Path.GetFileName(openFileDialog.FileName);
                hasGameSelected = true;
                foundGame = true;
                gamefoldername = Path.GetFileName(openFileDialog.FileName);
                gameDirTextBox.Text = SelectExe;
                //If game exe is selected, this will remove the Game.Exe from it and just leave us with the directory that contains it-
                //which is ONCE AGAIN for target folder purposes.
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.VDEXE = "\"" + @"C:\Program Files\Virtual Desktop Streamer\VirtualDesktop.Streamer.exe" + "\"";
            Properties.Settings.Default.Save();

            MessageBox.Show("VD Path set to default");
            //VD Streamer Directory Reset button
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save(); //and saves it to options file.
            if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\SAC\\FilePath.txt"))
                File.Delete($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\SAC\\FilePath.txt");
        }

        public static void IconPullClick(string selectExe)
        {
            string exepath = SelectExePath;
            Icon theIcon = ExtractIconFromFilePath(exepath);

            if (theIcon != null)
            {
                // Save it to disk, or do whatever you want with it.
                if (File.Exists($"{currdir}\\Temp\\temp.ico"))
                    File.Delete($"{currdir}\\Temp\\temp.ico");
                if (!Directory.Exists($"{currdir}\\Temp"))
                    Directory.CreateDirectory($"{currdir}\\Temp");
                using (FileStream stream = new FileStream($"{currdir}\\Temp\\temp.ico", FileMode.CreateNew))
                {
                    theIcon.Save(stream);
                }
            }
        }

        public static Icon ExtractIconFromFilePath(string executablePath = "")
        {
            Icon result = (Icon)null;

            try
            {
                result = Icon.ExtractAssociatedIcon(executablePath);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to extract the icon from the binary");
            }

            return result;
        }

        private void CreateVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VDChecked = CreateVDCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        static string GetFolderSize(string s)
        {
            string[] fileNames = Directory.GetFiles(s, "*.*", SearchOption.AllDirectories);
            long size = 0;

            // Calculate total size by looping through files in the folder and totalling their sizes
            foreach (string name in fileNames)
            {
                // length of each file.
                FileInfo details = new FileInfo(name);
                size += details.Length;
            }
            string Total = BytesToString(size);
            return Total;
        }

        static String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        private void CustomNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomNameCheckBox.Checked)
            {
                customNameTextBox.Visible = true;
                customname = true;
            }
            if (!CustomNameCheckBox.Checked)
            {
                customNameTextBox.Visible = false;
                customname = false;
            }
        }

        private void vdFolderButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Virtual Desktop | VirtualDesktop.Streamer.exe";
            fileDialog.Title = "Select VD Streamer exe (VirtualDesktop.Streamer.exe)";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.VDEXE = $"\"{fileDialog.FileName}\""; //If folder name chosen for custom streamer loc, it replaces setting here
                Properties.Settings.Default.Save(); //and saves it to options file.
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {


            if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\Microsoft\\Windows\\Start Menu\\Programs\\My Launchers"))
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\Microsoft\\Windows\\Start Menu\\Programs\\My Launchers");

            if (!Directory.Exists($"{currdir}\\My Launchers"))
                Directory.CreateDirectory($"{currdir}\\My Launchers");

            Updater.AppName = "VRL";
            Updater.Repostory = "harryeffinpotter/Shortcut-Maker";
            Updater.Update();
            CreateVDCheckBox.Checked = Properties.Settings.Default.VDChecked;
            AirCheckbox.Checked = Properties.Settings.Default.AirLink;
            DesktopBox.Checked = Properties.Settings.Default.ExeDesktop;
        }



        private void AirCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AirLink = AirCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void DesktopBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ExeDesktop = DesktopBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void ShowVDDIR_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowVDDIR.Checked)
            {
                VDDIRLBL.Visible = true;
                VDDIRLBL2.Visible = true;
                vdFolderButton.Visible = true;
                vdPathResetButton.Visible = true;
            }
            else
            {
                VDDIRLBL.Visible = false;
                VDDIRLBL2.Visible = false;
                vdFolderButton.Visible = false;
                vdPathResetButton.Visible = false;
            }


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool mouseDown;
        System.Drawing.Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void gameDirTextBox_TextChanged(object sender, EventArgs e)
        {
            if (gameDirTextBox.Text.Length > 0)
                runProgramButton.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show("Enable FFAR mode? If you're not sure what this is just click NO.", "FFAR Mode?", MessageBoxButtons.YesNo);
            if (dialogResult1 == DialogResult.Yes)
            {
                Properties.Settings.Default.FFARM = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.FFARM = false;
                Properties.Settings.Default.Save();
            }
        }
    }

}