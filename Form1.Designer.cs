
namespace VRL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectGameButton = new System.Windows.Forms.Button();
            this.gameDirTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.runProgramButton = new System.Windows.Forms.Button();
            this.vdFolderButton = new System.Windows.Forms.Button();
            this.selectExeButton = new System.Windows.Forms.Button();
            this.vdPathResetButton = new System.Windows.Forms.Button();
            this.VDDIRLBL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CustomNameCheckBox = new System.Windows.Forms.CheckBox();
            this.customNameTextBox = new System.Windows.Forms.TextBox();
            this.VDDIRLBL2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TopLABEL = new System.Windows.Forms.Label();
            this.DesktopBox = new System.Windows.Forms.CheckBox();
            this.CreateVDCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowVDDIR = new System.Windows.Forms.CheckBox();
            this.AirCheckbox = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.argsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // selectGameButton
            // 
            this.selectGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.selectGameButton.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.selectGameButton.FlatAppearance.BorderSize = 0;
            this.selectGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectGameButton.Font = new System.Drawing.Font("Trebuchet MS", 10.75F, System.Drawing.FontStyle.Bold);
            this.selectGameButton.ForeColor = System.Drawing.Color.Black;
            this.selectGameButton.Location = new System.Drawing.Point(262, 78);
            this.selectGameButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.selectGameButton.Name = "selectGameButton";
            this.selectGameButton.Size = new System.Drawing.Size(73, 26);
            this.selectGameButton.TabIndex = 1;
            this.selectGameButton.Text = "Browse";
            this.selectGameButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectGameButton.UseVisualStyleBackColor = false;
            this.selectGameButton.Click += new System.EventHandler(this.selectGameButton_Click);
            // 
            // gameDirTextBox
            // 
            this.gameDirTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(8)))));
            this.gameDirTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameDirTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.gameDirTextBox.ForeColor = System.Drawing.Color.White;
            this.gameDirTextBox.Location = new System.Drawing.Point(9, 47);
            this.gameDirTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gameDirTextBox.Name = "gameDirTextBox";
            this.gameDirTextBox.Size = new System.Drawing.Size(326, 26);
            this.gameDirTextBox.TabIndex = 0;
            this.gameDirTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gameDirTextBox.TextChanged += new System.EventHandler(this.gameDirTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(-4, -4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "VRL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(5, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Custom Launch Arguments:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // runProgramButton
            // 
            this.runProgramButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.runProgramButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.runProgramButton.FlatAppearance.BorderSize = 3;
            this.runProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runProgramButton.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.runProgramButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(11)))));
            this.runProgramButton.Location = new System.Drawing.Point(43, 525);
            this.runProgramButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.runProgramButton.Name = "runProgramButton";
            this.runProgramButton.Size = new System.Drawing.Size(259, 40);
            this.runProgramButton.TabIndex = 8;
            this.runProgramButton.Text = "Make Launchers";
            this.runProgramButton.UseVisualStyleBackColor = false;
            this.runProgramButton.Click += new System.EventHandler(this.runProgramButton_Click);
            // 
            // vdFolderButton
            // 
            this.vdFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.vdFolderButton.FlatAppearance.BorderSize = 0;
            this.vdFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vdFolderButton.Font = new System.Drawing.Font("Trebuchet MS", 10.75F, System.Drawing.FontStyle.Bold);
            this.vdFolderButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vdFolderButton.Location = new System.Drawing.Point(174, 284);
            this.vdFolderButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.vdFolderButton.Name = "vdFolderButton";
            this.vdFolderButton.Size = new System.Drawing.Size(69, 26);
            this.vdFolderButton.TabIndex = 11;
            this.vdFolderButton.Text = "Browse";
            this.vdFolderButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vdFolderButton.UseVisualStyleBackColor = false;
            this.vdFolderButton.Visible = false;
            this.vdFolderButton.Click += new System.EventHandler(this.vdFolderButton_Click_1);
            // 
            // selectExeButton
            // 
            this.selectExeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.selectExeButton.FlatAppearance.BorderSize = 0;
            this.selectExeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectExeButton.Font = new System.Drawing.Font("Trebuchet MS", 10.75F, System.Drawing.FontStyle.Bold);
            this.selectExeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectExeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selectExeButton.Location = new System.Drawing.Point(115, 78);
            this.selectExeButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.selectExeButton.Name = "selectExeButton";
            this.selectExeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectExeButton.Size = new System.Drawing.Size(143, 26);
            this.selectExeButton.TabIndex = 2;
            this.selectExeButton.Text = "Manually Select Exe";
            this.selectExeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectExeButton.UseVisualStyleBackColor = false;
            this.selectExeButton.Visible = false;
            this.selectExeButton.Click += new System.EventHandler(this.selectExeButton_Click);
            this.selectExeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.selectExeButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.selectExeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // vdPathResetButton
            // 
            this.vdPathResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.vdPathResetButton.FlatAppearance.BorderSize = 0;
            this.vdPathResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vdPathResetButton.Font = new System.Drawing.Font("Trebuchet MS", 10.75F, System.Drawing.FontStyle.Bold);
            this.vdPathResetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vdPathResetButton.Location = new System.Drawing.Point(101, 284);
            this.vdPathResetButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.vdPathResetButton.Name = "vdPathResetButton";
            this.vdPathResetButton.Size = new System.Drawing.Size(69, 26);
            this.vdPathResetButton.TabIndex = 10;
            this.vdPathResetButton.Text = "Reset to Default";
            this.vdPathResetButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vdPathResetButton.UseVisualStyleBackColor = false;
            this.vdPathResetButton.Visible = false;
            this.vdPathResetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // VDDIRLBL
            // 
            this.VDDIRLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VDDIRLBL.AutoSize = true;
            this.VDDIRLBL.BackColor = System.Drawing.Color.Transparent;
            this.VDDIRLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VDDIRLBL.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold);
            this.VDDIRLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.VDDIRLBL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VDDIRLBL.Location = new System.Drawing.Point(42, 240);
            this.VDDIRLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VDDIRLBL.Name = "VDDIRLBL";
            this.VDDIRLBL.Size = new System.Drawing.Size(260, 23);
            this.VDDIRLBL.TabIndex = 3;
            this.VDDIRLBL.Text = "VD Streamer Custom Location";
            this.VDDIRLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VDDIRLBL.Visible = false;
            this.VDDIRLBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.VDDIRLBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.VDDIRLBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(164, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.label14.Location = new System.Drawing.Point(-3, 581);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 22);
            this.label14.TabIndex = 2;
            this.label14.Text = "2.1";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.label15.Location = new System.Drawing.Point(274, 581);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 22);
            this.label15.TabIndex = 11;
            this.label15.Text = "FF@-HFP";
            this.label15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // CustomNameCheckBox
            // 
            this.CustomNameCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(11)))));
            this.CustomNameCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustomNameCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.CustomNameCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomNameCheckBox.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.CustomNameCheckBox.ForeColor = System.Drawing.Color.White;
            this.CustomNameCheckBox.Location = new System.Drawing.Point(9, 494);
            this.CustomNameCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomNameCheckBox.Name = "CustomNameCheckBox";
            this.CustomNameCheckBox.Size = new System.Drawing.Size(126, 23);
            this.CustomNameCheckBox.TabIndex = 7;
            this.CustomNameCheckBox.Text = "Custom Name";
            this.CustomNameCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomNameCheckBox.UseVisualStyleBackColor = false;
            this.CustomNameCheckBox.CheckedChanged += new System.EventHandler(this.CustomNameCheckBox_CheckedChanged);
            // 
            // customNameTextBox
            // 
            this.customNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(11)))));
            this.customNameTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.customNameTextBox.ForeColor = System.Drawing.Color.White;
            this.customNameTextBox.Location = new System.Drawing.Point(129, 494);
            this.customNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customNameTextBox.Name = "customNameTextBox";
            this.customNameTextBox.Size = new System.Drawing.Size(206, 26);
            this.customNameTextBox.TabIndex = 7;
            this.customNameTextBox.Visible = false;
            // 
            // VDDIRLBL2
            // 
            this.VDDIRLBL2.AutoSize = true;
            this.VDDIRLBL2.BackColor = System.Drawing.Color.Transparent;
            this.VDDIRLBL2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.VDDIRLBL2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.VDDIRLBL2.Location = new System.Drawing.Point(13, 262);
            this.VDDIRLBL2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VDDIRLBL2.Name = "VDDIRLBL2";
            this.VDDIRLBL2.Size = new System.Drawing.Size(319, 18);
            this.VDDIRLBL2.TabIndex = 23;
            this.VDDIRLBL2.Text = "If VDStreamer is installed to custom DIR set it here";
            this.VDDIRLBL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VDDIRLBL2.Visible = false;
            this.VDDIRLBL2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.VDDIRLBL2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.VDDIRLBL2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(5, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Select Platform(s):";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // TopLABEL
            // 
            this.TopLABEL.BackColor = System.Drawing.Color.Transparent;
            this.TopLABEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopLABEL.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold);
            this.TopLABEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.TopLABEL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TopLABEL.Location = new System.Drawing.Point(5, 22);
            this.TopLABEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TopLABEL.Name = "TopLABEL";
            this.TopLABEL.Size = new System.Drawing.Size(326, 24);
            this.TopLABEL.TabIndex = 16;
            this.TopLABEL.Text = "Select Game Directory:";
            this.TopLABEL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.TopLABEL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.TopLABEL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // DesktopBox
            // 
            this.DesktopBox.AutoSize = true;
            this.DesktopBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(11)))));
            this.DesktopBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.DesktopBox.FlatAppearance.BorderSize = 5;
            this.DesktopBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.DesktopBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DesktopBox.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.DesktopBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.DesktopBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DesktopBox.Location = new System.Drawing.Point(9, 192);
            this.DesktopBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DesktopBox.Name = "DesktopBox";
            this.DesktopBox.Size = new System.Drawing.Size(224, 22);
            this.DesktopBox.TabIndex = 5;
            this.DesktopBox.Text = "Don\'t create desktop shortcut.";
            this.DesktopBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DesktopBox.UseVisualStyleBackColor = false;
            this.DesktopBox.CheckedChanged += new System.EventHandler(this.DesktopBox_CheckedChanged);
            // 
            // CreateVDCheckBox
            // 
            this.CreateVDCheckBox.AutoSize = true;
            this.CreateVDCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(11)))));
            this.CreateVDCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.CreateVDCheckBox.FlatAppearance.BorderSize = 0;
            this.CreateVDCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CreateVDCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CreateVDCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateVDCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateVDCheckBox.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.CreateVDCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.CreateVDCheckBox.Location = new System.Drawing.Point(109, 137);
            this.CreateVDCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateVDCheckBox.Name = "CreateVDCheckBox";
            this.CreateVDCheckBox.Size = new System.Drawing.Size(125, 22);
            this.CreateVDCheckBox.TabIndex = 5;
            this.CreateVDCheckBox.Text = "Virtual Desktop";
            this.CreateVDCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateVDCheckBox.UseVisualStyleBackColor = false;
            this.CreateVDCheckBox.CheckedChanged += new System.EventHandler(this.CreateVDCheckBox_CheckedChanged);
            // 
            // ShowVDDIR
            // 
            this.ShowVDDIR.AutoSize = true;
            this.ShowVDDIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(11)))));
            this.ShowVDDIR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowVDDIR.FlatAppearance.BorderSize = 5;
            this.ShowVDDIR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.ShowVDDIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowVDDIR.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.ShowVDDIR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.ShowVDDIR.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ShowVDDIR.Location = new System.Drawing.Point(9, 212);
            this.ShowVDDIR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowVDDIR.Name = "ShowVDDIR";
            this.ShowVDDIR.Size = new System.Drawing.Size(317, 22);
            this.ShowVDDIR.TabIndex = 5;
            this.ShowVDDIR.Text = "Select if you installed VD to custom dir on PC";
            this.ShowVDDIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowVDDIR.UseVisualStyleBackColor = false;
            this.ShowVDDIR.CheckedChanged += new System.EventHandler(this.ShowVDDIR_CheckedChanged);
            // 
            // AirCheckbox
            // 
            this.AirCheckbox.AutoSize = true;
            this.AirCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(11)))));
            this.AirCheckbox.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.AirCheckbox.FlatAppearance.BorderSize = 0;
            this.AirCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.AirCheckbox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AirCheckbox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AirCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AirCheckbox.Font = new System.Drawing.Font("Trebuchet MS", 10.5F, System.Drawing.FontStyle.Bold);
            this.AirCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.AirCheckbox.Location = new System.Drawing.Point(9, 137);
            this.AirCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AirCheckbox.Name = "AirCheckbox";
            this.AirCheckbox.Size = new System.Drawing.Size(100, 22);
            this.AirCheckbox.TabIndex = 5;
            this.AirCheckbox.Text = "Link/Airlink";
            this.AirCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AirCheckbox.UseVisualStyleBackColor = false;
            this.AirCheckbox.CheckedChanged += new System.EventHandler(this.AirCheckbox_CheckedChanged);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 2;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.closeButton.Location = new System.Drawing.Point(318, -5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(29, 31);
            this.closeButton.TabIndex = 24;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(5, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Options:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // argsRichTextBox
            // 
            this.argsRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(1)))), ((int)(((byte)(8)))));
            this.argsRichTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.argsRichTextBox.ForeColor = System.Drawing.Color.White;
            this.argsRichTextBox.Location = new System.Drawing.Point(9, 349);
            this.argsRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.argsRichTextBox.Name = "argsRichTextBox";
            this.argsRichTextBox.Size = new System.Drawing.Size(326, 141);
            this.argsRichTextBox.TabIndex = 6;
            this.argsRichTextBox.Text = "s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(345, 600);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.AirCheckbox);
            this.Controls.Add(this.VDDIRLBL2);
            this.Controls.Add(this.customNameTextBox);
            this.Controls.Add(this.CustomNameCheckBox);
            this.Controls.Add(this.CreateVDCheckBox);
            this.Controls.Add(this.ShowVDDIR);
            this.Controls.Add(this.DesktopBox);
            this.Controls.Add(this.vdPathResetButton);
            this.Controls.Add(this.argsRichTextBox);
            this.Controls.Add(this.selectExeButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.vdFolderButton);
            this.Controls.Add(this.runProgramButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VDDIRLBL);
            this.Controls.Add(this.TopLABEL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameDirTextBox);
            this.Controls.Add(this.selectGameButton);
            this.Controls.Add(this.label15);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(345, 850);
            this.MinimumSize = new System.Drawing.Size(345, 571);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "  ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectGameButton;
        private System.Windows.Forms.TextBox gameDirTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button runProgramButton;
        private System.Windows.Forms.Button vdFolderButton;
        private System.Windows.Forms.Button selectExeButton;
        private System.Windows.Forms.Button vdPathResetButton;
        private System.Windows.Forms.Label VDDIRLBL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox CustomNameCheckBox;
        private System.Windows.Forms.TextBox customNameTextBox;
        private System.Windows.Forms.Label VDDIRLBL2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label TopLABEL;
        private System.Windows.Forms.CheckBox DesktopBox;
        private System.Windows.Forms.CheckBox CreateVDCheckBox;
        private System.Windows.Forms.CheckBox ShowVDDIR;
        private System.Windows.Forms.CheckBox AirCheckbox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox argsRichTextBox;
    }
}

