using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using System.Diagnostics;



namespace VRP_Shortcut_Maker
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CustomLaunchExe = "";
        bool customname = false;
        bool hasCustomLaunchExeSet = false;
        bool foundGame = false;
        bool hasGameSelected = false;
        string SelectExe = "";
        string SelectExePath = "";
        string gamefoldername = "";
        string gamedir = "";
        string filenoexe = "";

        private void selectGameButton_Click(object sender, EventArgs e)

        {
            FolderSelectDialog folderSelectDialog = new FolderSelectDialog();
            folderSelectDialog.Title = "Select the game's main folder.";
            if (Properties.Settings.Default.LastDir.Length > 0)
                folderSelectDialog.InitialDirectory = Properties.Settings.Default.LastDir;

            if (folderSelectDialog.Show(Handle))
            {

                gameDirTextBox.Text = folderSelectDialog.FileName;
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

            foreach (string file in Directory.EnumerateFiles(folderSelectDialog.FileName, "*.exe", SearchOption.AllDirectories))
            {
                string filename = Path.GetFileName(file).ToLower(); //get filename from path and make it lower so it is case insensitive
                if (filename.Contains("win64") && filename.Contains("shipping"))
                {
                    filenoexe = Path.GetFileNameWithoutExtension(file);
                    Console.WriteLine(file);
                    foundGame = true;
                    gamedir = Path.GetDirectoryName(file);
                    gameDirTextBox.Text = file;
                    SelectExePath = file;
                    SelectExe = System.IO.Path.GetFileName(file); //Game full path is set here, WITH exe name. If not found, users must manually set this.
                    string box_msg = "Game EXE found!";
                    string box_title = "Game EXE found.";
                    MessageBox.Show(box_msg, box_title);
                    hasGameSelected = true;
                    break;
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
                        if (filename2.Contains(GameWrd))
                        {
                            gameNamePartFound = true;
                            break;
                        }
                    }

                    if (gameNamePartFound)
                    {
                        filenoexe = Path.GetFileNameWithoutExtension(file2);
                        Console.WriteLine(file2);
                        foundGame = true;
                        gamedir = Path.GetDirectoryName(file2);
                        gameDirTextBox.Text = file2;
                        SelectExePath = file2; //Game full path is set here, WITH exe name. If not found, users must manually set this.
                        SelectExe = System.IO.Path.GetFileName(file2);
                        string box_msg2 = "Game EXE found!";
                        string box_title2 = "Game EXE found.";
                        MessageBox.Show(box_msg2, box_title2);
                        hasGameSelected = true;
                        break;
                    }


                }


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

        private void runProgramButton_Click(object sender, EventArgs e)
        {
            string args = "";
            foreach (string arg in argsRichTextBox.Text.Split('\n'))
            {
                args += $" {arg}";
            }
            if (checkBox1.Checked)
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
            if (AgainstCheckbox.Checked)
            {
                if (hasCustomLaunchExeSet)
                {
                    File.WriteAllText("customexe.txt", $"\"{CustomLaunchExe}\" \"{SelectExe}\"{args}");
                    File.WriteAllText("filename.txt", filenoexe); //Complete exe title, to get icon from exe file for shortcut.
                    File.WriteAllText("temp2.txt", SelectExePath); //Complete exe path, to get icon from exe file for shortcut.
                    File.WriteAllText("gdir.txt", gamedir); //Game directory, for "working directory" and "target path" usages.
                    BatProcess.StartInfo.FileName = "Script3.bat";
                    BatProcess.Start();
                    BatProcess.WaitForExit();
                    MessageBox.Show("Shortcut Successfully made!");
                }
                if (!hasCustomLaunchExeSet)
                {
                    MessageBox.Show("You must set a custom exe to launch against or uncheck \"Launch against custom exe\" box");
                    return;

                }
            }
            if (!AgainstCheckbox.Checked)
            {


                if (CreateVDCheckBox.Checked)
                {


                    /* Do what you want here, i'll just make the program make a file called temp.txt with the path and args
                     * probably you also want it to extract and run the powershell/batch you made/will make */


                    {
                        File.WriteAllText("filename.txt", filenoexe); //Complete exe title, to get icon from exe file for shortcut.
                        File.WriteAllText("temp2.txt", SelectExePath); //Complete exe path, to get icon from exe file for shortcut.
                        File.WriteAllText("temp3.txt", $"\"{SelectExe}\"{args}"); //Selected exe WITHOUT VD Streamer, for non Virtual Desktop users.
                        File.WriteAllText("gdir.txt", gamedir); //Game directory, for "working directory" and "target path" usages.
                        File.WriteAllText("temp.txt", $"{Properties.Settings.Default.VDEXE} \"{SelectExe}\"{args}"); //Saved or Default VD path + args
                        BatProcess.StartInfo.FileName = "Script1.bat";
                        BatProcess.Start();
                        BatProcess.WaitForExit();
                        BatProcess.StartInfo.FileName = "Script2.bat";
                        BatProcess.Start();
                        BatProcess.WaitForExit();
                        MessageBox.Show("Shortcuts Successfully made!");


                    }
                }
                if (!CreateVDCheckBox.Checked)
                {

                    File.WriteAllText("temp2.txt", SelectExePath); //Complete exe path, to get icon from exe file for shortcut.
                    File.WriteAllText("temp3.txt", $"\"{SelectExe}\"{args}"); //Selected path WITHOUT VD Streamer, for non Virtual Desktop users.
                    File.WriteAllText("gdir.txt", gamedir); //Game directory, for "working directory" and "target path" usages.
                    BatProcess.StartInfo.FileName = "Script2.bat";
                    BatProcess.Start();
                    BatProcess.WaitForExit();
                    MessageBox.Show("Shortcut Successfully made!");
                }

            }
        }

        //we really should vc if you are going to do more c# stuff in the future, also try to name your stuff from forms, instead of button1 name it what it does
        //dont worry tho, you dont have any experience with coding so ur doing really great, and doing big stuff in c# is very hard
        //if you dont have any prior coding language

        private void selectExeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Games |*.exe"; //only show .exe files or shortcuts
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                gamedir = Path.GetDirectoryName(openFileDialog.FileName);
                filenoexe = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                openFileDialog.InitialDirectory = gameDirTextBox.Text;
                gameDirTextBox.Text = openFileDialog.FileName;
                SelectExePath = openFileDialog.FileName;
                SelectExe = System.IO.Path.GetFileName(openFileDialog.FileName);
                hasGameSelected = true;
                foundGame = true;
                gamefoldername = Path.GetFileName(openFileDialog.FileName);
                File.WriteAllText("gname.txt", gamefoldername);

                //If game exe is selected, this will remove the Game.Exe from it and just leave us with the directory that contains it-
                //which is ONCE AGAIN for target folder purposes.
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!CreateVDCheckBox.Checked)
            {
                MessageBox.Show("You must check Create Virtual Desktop shortcut box!");
                return;
            }
            Properties.Settings.Default.VDEXE = "\"" + @"C:\Program Files\Virtual Desktop Streamer\VirtualDesktop.Streamer.exe" + "\"";
            MessageBox.Show("VD Path set to default");
            //VD Streamer Directory Reset button
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save(); //and saves it to options file.
            File.Delete("temp.txt");
            File.Delete("temp2.txt");
            File.Delete("temp3.txt");
            File.Delete("GDir.txt");
            File.Delete("gname.txt");
            File.Delete("customexe.txt");
            File.Delete("filename.txt");
            File.Delete("tempSteam.txt");
        }



        private void CreateVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CreateVDCheckBox.Checked)
            {
                AgainstCheckbox.Enabled = false;
                label10.Visible = true;
                label8.Visible = true;
                vdPathResetButton.Visible = true;
                vdFolderButton.Visible = true;

            }
            if (!CreateVDCheckBox.Checked)
            {
                AgainstCheckbox.Enabled = true;
                label10.Visible = false;
                label8.Visible = false;
                vdPathResetButton.Visible = false;
                vdFolderButton.Visible = false;
            }
        }


        private void CustomLaunchExeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Program to launch game against |*.exe"; //only show .exe files or shortcuts
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CustomLaunchExe = openFileDialog.FileName;
                hasCustomLaunchExeSet = true;
                //If game exe is selected, this will remove the Game.Exe from it and just leave us with the directory that contains it-
                //which is ONCE AGAIN for target folder purposes.
            }
            else
            {
                MessageBox.Show("You must select a custom exe with Custom Exe box checked");
                return;


            }
        }

        private void AgainstCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AgainstCheckbox.Checked)
            {
                CustomLaunchExeButton.Visible = true;
                CreateVDCheckBox.Enabled = false;
            }
            if (!AgainstCheckbox.Checked)
            {
                CustomLaunchExeButton.Visible = false;
                hasCustomLaunchExeSet = false;
                CreateVDCheckBox.Enabled = true;
            }
            
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
            fileDialog.Title = "Select VD exe (VirtualDesktop.Streamer.exe)";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.VDEXE = $"\"" + fileDialog.FileName + "\""; //If folder name chosen for custom streamer loc, it replaces setting here
                Properties.Settings.Default.Save(); //and saves it to options file.
            }



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Updater.AppName = "ShortcutMaker";
            Updater.Repostory = "harryeffinpotter/Shortcut-Maker";
            Updater.Update();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
   
}