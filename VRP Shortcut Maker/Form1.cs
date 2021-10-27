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
        public Form1()
        {
            InitializeComponent();
        }
        public static string currdir = Environment.CurrentDirectory;
        public static string exefull = "";
        bool customname = false;
        bool foundGame = false;
        public static string batname = "";
        bool hasGameSelected = false;
        public static string SelectExe = "";
        string gamefolderpath = "";
        public static string SelectExePath = "";
        string gamefoldername = "";
        string gamedir = "";
        string filenoexe = "";
        readonly string Airlink = "-oculus -oculus vr -vrmode oculus";


        public static string GetValidFileName(string fileName)
        {
            // remove any invalid character from the filename.
            String ret = Regex.Replace(fileName.Trim(), "[^A-Za-z0-9_. ]+", "");
            return ret.Replace(" ", String.Empty);
        }

        private void selectGameButton_Click(object sender, EventArgs e)

        {
            foundGame = false;
            hasGameSelected = false;
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
                File.WriteAllText("gname.txt", gamefoldername);//When user selects C:/Whatever/Half-Life Alyx/ this will take Half-Life Alyx from it and use it for the shortcut title.
            }
            else
            {
                return;
            }
            if (Directory.Exists($"{folderSelectDialog.FileName}\\{gamefoldername}"))
                gamefolderpath = $"{folderSelectDialog.FileName}\\{gamefoldername}";

            foreach (string folder in Directory.EnumerateDirectories(folderSelectDialog.FileName, "*_data", SearchOption.AllDirectories))
            {
                foreach (string file in Directory.EnumerateFiles(folderSelectDialog.FileName, "*.exe", SearchOption.TopDirectoryOnly))
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
                foreach (string folder in Directory.EnumerateDirectories(folderSelectDialog.FileName, "*Win64*", SearchOption.AllDirectories))
                {
                    foreach (string file in Directory.EnumerateFiles(folderSelectDialog.FileName, "*.exe", SearchOption.AllDirectories))
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
                foreach (string folder in Directory.EnumerateDirectories(folderSelectDialog.FileName, "win64", SearchOption.AllDirectories))
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

                    foreach (string file2 in Directory.EnumerateFiles(folderSelectDialog.FileName, "*.exe", SearchOption.AllDirectories))

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
                    foreach (string file2 in Directory.EnumerateFiles(folderSelectDialog.FileName, "*.exe", SearchOption.AllDirectories))
                    {
                        if (!hasGameSelected)
                        {

                            string box_msg = "EXE could not be automatically found, please select the game EXE manually below.";
                            string box_title = "No EXE found.";
                            selectExeButton.Visible = true;
                            MessageBox.Show(box_msg, box_title);
                            // IDEALLY - I'd like to GREY OUT the run program option and even the SELECT exe button UNTIL this moment, they must specify a game folder for
                            //2 reasons, 1. to search for shipping exe. 2. to give us the game name, sorking directories, all that stuch
                        }

                    }

                }

                if (foundGame)
                {
                    runProgramButton.Enabled = true;

                }


                /*
                    Here you should put the default path (in the variable)
                    Also you should do something with the settings so if user has it in custom path he doesnt have to press the button
                    every time he starts the program
                */
            }


        }


        void runProgramButton_Click(object sender, EventArgs e)
            {
            runProgramButton.Enabled = false;

            string args = "";
            if (Directory.Exists($"{currdir}\\Temp"))
                Directory.Delete($"{currdir}\\Temp", true);
            File.WriteAllText("currdir.txt", currdir);
            Directory.CreateDirectory($"{currdir}\\Temp");
            string disabler = "";
            if (Properties.Settings.Default.ExeDesktop)
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
            if (customname)
            {
                gamefoldername = customNameTextBox.Text;
                File.WriteAllText("gname.txt", gamefoldername);

            }
            Process BatProcess = new Process();
            BatProcess.StartInfo.CreateNoWindow = true;
            BatProcess.StartInfo.UseShellExecute = false;
            if (AirCheckbox.Checked)
            {
                if (args.Contains("-"))
                    File.WriteAllText("nosteamoc.txt", $"\"{SelectExePath}\" {Airlink} {args}");
                else
                 File.WriteAllText("nosteamoc.txt", $"\"{SelectExePath}\" {Airlink}");
                if (args.Contains("-"))
                    File.WriteAllText("steamoc.txt", $"\"{SelectExePath}\" -Steam -VR {Airlink} {args}");
                else
                    File.WriteAllText("steamoc.txt", $"\"{SelectExePath}\" -Steam -VR {Airlink}");

                File.WriteAllText("filename.txt",$"\"{filenoexe}\""); //Complete exe title, for shortcut name.
                File.WriteAllText("temp2.txt", "\"{SelectExePath}\""); //Complete exe path, to get icon from exe file for shortcut.
                File.WriteAllText("gdir.txt", "\"" + gamedir + "\""); //Game directory, for "working directory" and "target path" usages.

                BatProcess.StartInfo.FileName = "LinkNS.bat";
                BatProcess.Start();
                BatProcess.WaitForExit();
                Bat2Exe(SelectExePath);
                BatProcess.StartInfo.FileName = "LinkWS.bat";
                BatProcess.Start();
                BatProcess.WaitForExit();
                Bat2Exe(SelectExePath);
            }



            if (CreateVDCheckBox.Checked)
            {

                File.WriteAllText("filename.txt", filenoexe); //Complete exe title, to get icon from exe file for shortcut.
                File.WriteAllText("temp2.txt", $"\"{SelectExePath}\""); //Complete exe path, to get icon from exe file for shortcut.
                File.WriteAllText("temp3.txt", $"\"{SelectExePath}\"{args}"); //File name including extension.
                File.WriteAllText("gdir.txt", $"\"{gamedir}\""); //Game directory, for "working directory" and "target path" usages.
                if (args.Contains("-"))
                    File.WriteAllText("temp.txt", $"{Properties.Settings.Default.VDEXE} \"{SelectExePath}\"{args} -vrmode oculus -oculus -oculus vr");
                else
                    File.WriteAllText("temp.txt", $"{Properties.Settings.Default.VDEXE} \"{SelectExePath}\" -vrmode oculus -oculus -oculus vr"); //Saved or Default VD path + args

                BatProcess.StartInfo.FileName = "Script1.bat";
                BatProcess.Start();
                BatProcess.WaitForExit();
                Bat2Exe(SelectExePath);
                BatProcess.StartInfo.FileName = "Script2.bat";
                BatProcess.Start();
                BatProcess.WaitForExit();
                Bat2Exe(SelectExePath);
            }
            if (NoOccy.Checked)
            {
                if (args.Contains("-"))
                    File.WriteAllText("temp1.txt", $"\"{SelectExePath}\"{args}"); //Complete exe path, to get icon from exe file for shortcut.c
                else
                    File.WriteAllText("temp1.txt",$"\"{SelectExePath}\"");
                    File.WriteAllText("temp2.txt", $"\"{SelectExePath}\"");
                File.WriteAllText("gdir.txt", $"\"{gamedir}\""); //Game directory, for "working directory" and "target path" usages.
                BatProcess.StartInfo.FileName = "NoLink.bat";
                BatProcess.Start();
                BatProcess.WaitForExit();
                Bat2Exe(SelectExePath);
            }

            MessageBox.Show("Shortcut Successfully made!");
            string[] files = System.IO.Directory.GetFiles(currdir, "*.txt");
            foreach (string file in files)
            {
                if (file.EndsWith(".txt"))
                System.IO.File.Delete(file);
            }
            gameDirTextBox.Clear();
            TopLABEL.Text = "Select Game Directory:";
        }
        public static string targetdir = "";
        public static string bat = "";


        //we really should vc if you are going to do more c# stuff in the future, also try to name your stuff from forms, instead of button1 name it what it does
        //dont worry tho, you dont have any experience with coding so ur doing really great, and doing big stuff inc# is very hard
        //if you dont have any prior coding language
        public static string Bat2Exe(string newexe)
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

                    string path = Path.GetDirectoryName(newexe);
                    string justfilename = Path.GetFileName(file);
                    string newfile =$"{currdir}\\My Launchers\\{justfilename}";
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
                File.WriteAllText("gname.txt", gamefoldername);


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

        public static Icon ExtractIconFromFilePath(string executablePath)
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

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\My Launchers"))
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\My Launchers");
            
            if (!Directory.Exists($"{currdir}\\My Launchers"))
                Directory.CreateDirectory($"{currdir}\\My Launchers");
            currdir = Environment.CurrentDirectory;
           Updater.AppName = "VRL";
           Updater.Repostory = "harryeffinpotter/Shortcut-Maker";
           Updater.Update();
            CreateVDCheckBox.Checked = Properties.Settings.Default.VDChecked;
            AirCheckbox.Checked = Properties.Settings.Default.AirLink;
            NoOccy.Checked = Properties.Settings.Default.NonOccy;
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

        private void NoOccy_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NonOccy = NoOccy.Checked;
            Properties.Settings.Default.Save();
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
    }
}