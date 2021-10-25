using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using System.Diagnostics;



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
                DesktopBox.Checked = Properties.Settings.Default.ExeDesktop;
                gameDirTextBox.Text = folderSelectDialog.FileName;
                gamefolderpath = folderSelectDialog.FileName;
                Properties.Settings.Default.LastDir = folderSelectDialog.FileName;
                Properties.Settings.Default.Save();//Game Directory for target/working dirs set here, can be replaced by manual select.
                gamefoldername = Path.GetFileName(folderSelectDialog.FileName);
                File.WriteAllText("gname.txt", gamefoldername);//When user selects C:/Whatever/Half-Life Alyx/ this will take Half-Life Alyx from it and use it for the shortcut title.
            }
            else
            {
                MessageBox.Show("You must select a game folder!");
                return;
            }
            //Since .net 4 there is a recursive file search directly implemented in c#
            //*.* means every file with any or no extension
            /* Message from rookie to harry - You might want to use the same folderselect which rookie uses, this one is weird
            af and doesn't let you do stuff like change directory easily if you have the path in your clipboard and the ui
            is too small and lacks a lot of other features */
            if (Directory.Exists($"{folderSelectDialog.FileName}\\{gamefoldername}"))
                gamefolderpath = $"{folderSelectDialog.FileName}\\{gamefoldername}";

            foreach (string folder in Directory.EnumerateDirectories(folderSelectDialog.FileName, "*_data", SearchOption.AllDirectories))
            {
                string dataParent = Directory.GetParent(folder.TrimEnd(Path.DirectorySeparatorChar)).FullName;
                foreach (string file in Directory.EnumerateFiles(dataParent, "*.exe", SearchOption.TopDirectoryOnly))
                {
                    string dironly = Path.GetDirectoryName(folder).ToLower();
                    string filename = Path.GetFileName(file).ToLower();
                    filename = filename.Replace(".exe", "");
                    string cutfolder = folder.Remove(folder.Length - 5);
                    if (cutfolder.Contains(filename))
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
                        else if (filename.EndsWith(".exe") && !filename.Contains("unis") && !filename.Contains("UnityCrashHandler64.exe") && !filename.Contains("Crash.exe") &&
                                    !filename.Contains("redist") && !filename.Contains("unity") && !filename.Contains("trial") && !filename.Contains("dx"))
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

                        if (gameNamePartFound)
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


                        if (filename2.StartsWith(dataParent))
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
                /*  
                    Here you should put the default path (in the variable)
                    Also you should do something with the settings so if user has it in custom path he doesnt have to press the button
                    every time he starts the program
                */
            }
        }

            private void runProgramButton_Click(object sender, EventArgs e)


    { 
            string args = "";
            foreach (string arg in argsRichTextBox.Text.Split('\n'))
            {
                args += $" {arg}";
            }
            if (ShowVDDIR.Checked)
            {
                File.WriteAllText("tempSteam.txt", "-Steam -VR");
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
                {
                    File.WriteAllText("nosteamoc.txt", $"\"{SelectExe}\" {Airlink} {args}");
                }
                     else
                {
                    File.WriteAllText("nosteamoc.txt", $"\"{SelectExe}\" {Airlink}");
                }
                if (args.Contains("-"))
                {
                    File.WriteAllText("steamoc.txt", $"\"{SelectExe}\" -Steam -VR {Airlink} {args}");
                }
                else
                {
                    File.WriteAllText("steamoc.txt", $"\"{SelectExe}\" -Steam -VR {Airlink}");
                }

                File.WriteAllText("filename.txt", filenoexe); //Complete exe title, for shortcut name.
                File.WriteAllText("temp2.txt", SelectExePath); //Complete exe path, to get icon from exe file for shortcut.
                File.WriteAllText("gdir.txt", gamedir); //Game directory, for "working directory" and "target path" usages.

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


                /* Do what you want here, i'll just make the program make a file called temp.txt with the path and args
                 * probably you also want it to extract and run the powershell/batch you made/will make */



                File.WriteAllText("filename.txt", filenoexe); //Complete exe title, to get icon from exe file for shortcut.
                File.WriteAllText("temp2.txt", SelectExePath); //Complete exe path, to get icon from exe file for shortcut.
                File.WriteAllText("temp3.txt", $"\"{SelectExe}\"{args}"); //File name including extension.
                File.WriteAllText("gdir.txt", gamedir); //Game directory, for "working directory" and "target path" usages.
                if (args.Contains("-"))
                    File.WriteAllText("temp.txt", $"{Properties.Settings.Default.VDEXE} \"{SelectExe}\"{args} -vrmode oculus -oculus -oculus vr");
                else
                    File.WriteAllText("temp.txt", $"{Properties.Settings.Default.VDEXE} \"{SelectExe}\" -vrmode oculus -oculus -oculus vr"); //Saved or Default VD path + args
                if (Directory.Exists($"{Environment.CurrentDirectory}\\Temp"))
                {
                    Directory.Delete($"{Environment.CurrentDirectory}\\Temp", true);
                    Directory.CreateDirectory($"{Environment.CurrentDirectory}\\Temp");
                }
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
                File.WriteAllText("temp2.txt", SelectExePath); //Complete exe path, to get icon from exe file for shortcut.
                File.WriteAllText("temp3.txt", args); //Selected path WITHOUT VD Streamer, for non Virtual Desktop users.
                File.WriteAllText("gdir.txt", gamedir); //Game directory, for "working directory" and "target path" usages.
                BatProcess.StartInfo.FileName = "NoLink.bat";
                BatProcess.Start();
                BatProcess.WaitForExit();
                Bat2Exe(SelectExePath);
                string temp = currdir + "\\Temp";
                if (Directory.Exists($"{currdir}\\Temp"))
                    Directory.Delete(temp, true);


            }

            MessageBox.Show("Shortcut Successfully made!");
            string[] files = System.IO.Directory.GetFiles(currdir, "*.txt");
            foreach (string file in files)
            {
                if (file.EndsWith(".txt"))
                System.IO.File.Delete(file);
            }
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
            BatProcess.StartInfo.FileName = $"{currdir}\\go.exe";
            BatProcess.StartInfo.Arguments = $"/bat \"{bat}\" /exe \"{currdir}\\Temp\\{batname}.exe\" /icon \"{Environment.CurrentDirectory}\\Temp\\temp.ico\"";
            BatProcess.Start();
            BatProcess.WaitForExit();
            foreach (string file in Directory.EnumerateFiles($"{currdir}\\Temp", "*.exe", SearchOption.TopDirectoryOnly))
            {
                if (!file.Contains("go.exe") && !file.Contains("VRL.exe"))
                {
                    string path = Path.GetDirectoryName(newexe);
                    string justfilename = Path.GetFileName(file);
                    string newfile = path + "\\" + justfilename;
                    if (File.Exists(newfile))
                        File.Delete(newfile);
                    File.Move(file, newfile);
                }
            }
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
            currdir = Environment.CurrentDirectory;
           // Updater.AppName = "ShortcutMaker";
           // Updater.Repostory = "harryeffinpotter/Shortcut-Maker";
            // Updater.Update();
        }



        private void AirCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EXE2D = AirCheckbox.Checked;
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
    }
}