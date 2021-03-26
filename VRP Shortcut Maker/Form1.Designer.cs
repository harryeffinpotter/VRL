
namespace VRP_Shortcut_Maker
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.runProgramButton = new System.Windows.Forms.Button();
            this.vdFolderButton = new System.Windows.Forms.Button();
            this.selectExeButton = new System.Windows.Forms.Button();
            this.argsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.vdPathResetButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.AgainstCheckbox = new System.Windows.Forms.CheckBox();
            this.CustomNameCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateVDCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomLaunchExeButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectGameButton
            // 
            this.selectGameButton.AutoEllipsis = true;
            this.selectGameButton.BackColor = System.Drawing.Color.White;
            this.selectGameButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.selectGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.selectGameButton.Location = new System.Drawing.Point(47, 122);
            this.selectGameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectGameButton.Name = "selectGameButton";
            this.selectGameButton.Size = new System.Drawing.Size(187, 23);
            this.selectGameButton.TabIndex = 1;
            this.selectGameButton.Text = "Find Game Exe";
            this.selectGameButton.UseVisualStyleBackColor = false;
            this.selectGameButton.Click += new System.EventHandler(this.selectGameButton_Click);
            // 
            // gameDirTextBox
            // 
            this.gameDirTextBox.BackColor = System.Drawing.Color.White;
            this.gameDirTextBox.Location = new System.Drawing.Point(12, 95);
            this.gameDirTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameDirTextBox.Name = "gameDirTextBox";
            this.gameDirTextBox.Size = new System.Drawing.Size(257, 20);
            this.gameDirTextBox.TabIndex = 0;
            this.gameDirTextBox.Text = "Selecting the game folder is required...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(-2, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Shortcut Maker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select game\'s MAIN directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.Thistle;
            this.label3.Location = new System.Drawing.Point(39, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "(E.G.: C:\\Games\\Half-Life Alyx)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(59, 402);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Custom Arguments";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.Color.Thistle;
            this.label5.Location = new System.Drawing.Point(15, 422);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "(Not required, one per line, e.g., -NoWindow)";
            // 
            // runProgramButton
            // 
            this.runProgramButton.BackColor = System.Drawing.Color.PaleGreen;
            this.runProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runProgramButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.runProgramButton.Location = new System.Drawing.Point(47, 616);
            this.runProgramButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.runProgramButton.Name = "runProgramButton";
            this.runProgramButton.Size = new System.Drawing.Size(187, 40);
            this.runProgramButton.TabIndex = 9;
            this.runProgramButton.Text = "Make Shortcuts";
            this.runProgramButton.UseVisualStyleBackColor = false;
            this.runProgramButton.Click += new System.EventHandler(this.runProgramButton_Click);
            // 
            // vdFolderButton
            // 
            this.vdFolderButton.BackColor = System.Drawing.Color.White;
            this.vdFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vdFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.vdFolderButton.Location = new System.Drawing.Point(145, 369);
            this.vdFolderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vdFolderButton.Name = "vdFolderButton";
            this.vdFolderButton.Size = new System.Drawing.Size(69, 26);
            this.vdFolderButton.TabIndex = 6;
            this.vdFolderButton.Text = "Set exe";
            this.vdFolderButton.UseVisualStyleBackColor = false;
            this.vdFolderButton.Visible = false;
            this.vdFolderButton.Click += new System.EventHandler(this.vdFolderButton_Click_1);
            // 
            // selectExeButton
            // 
            this.selectExeButton.BackColor = System.Drawing.Color.White;
            this.selectExeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectExeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectExeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.selectExeButton.Location = new System.Drawing.Point(47, 150);
            this.selectExeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectExeButton.Name = "selectExeButton";
            this.selectExeButton.Size = new System.Drawing.Size(187, 23);
            this.selectExeButton.TabIndex = 2;
            this.selectExeButton.Text = "Manually Select Game Exe";
            this.selectExeButton.UseVisualStyleBackColor = false;
            this.selectExeButton.Visible = false;
            this.selectExeButton.Click += new System.EventHandler(this.selectExeButton_Click);
            // 
            // argsRichTextBox
            // 
            this.argsRichTextBox.BackColor = System.Drawing.Color.White;
            this.argsRichTextBox.Location = new System.Drawing.Point(12, 440);
            this.argsRichTextBox.Name = "argsRichTextBox";
            this.argsRichTextBox.Size = new System.Drawing.Size(256, 117);
            this.argsRichTextBox.TabIndex = 7;
            this.argsRichTextBox.Text = "";
            // 
            // vdPathResetButton
            // 
            this.vdPathResetButton.BackColor = System.Drawing.Color.White;
            this.vdPathResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vdPathResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdPathResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.vdPathResetButton.Location = new System.Drawing.Point(66, 369);
            this.vdPathResetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vdPathResetButton.Name = "vdPathResetButton";
            this.vdPathResetButton.Size = new System.Drawing.Size(65, 25);
            this.vdPathResetButton.TabIndex = 5;
            this.vdPathResetButton.Text = "Default";
            this.vdPathResetButton.UseVisualStyleBackColor = false;
            this.vdPathResetButton.Visible = false;
            this.vdPathResetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Cyan;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(59, 331);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "VD Streamer install dir";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(140, 136);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label14.Location = new System.Drawing.Point(220, 2);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 24);
            this.label14.TabIndex = 2;
            this.label14.Text = "v1.2.1";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Thistle;
            this.label15.Location = new System.Drawing.Point(1, 21);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "VRP-HarryEffinPotter";
            // 
            // AgainstCheckbox
            // 
            this.AgainstCheckbox.AutoSize = true;
            this.AgainstCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.AgainstCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.AgainstCheckbox.ForeColor = System.Drawing.Color.LightCoral;
            this.AgainstCheckbox.Location = new System.Drawing.Point(23, 180);
            this.AgainstCheckbox.Name = "AgainstCheckbox";
            this.AgainstCheckbox.Size = new System.Drawing.Size(235, 17);
            this.AgainstCheckbox.TabIndex = 16;
            this.AgainstCheckbox.Text = "(Advanced users) custom launch exe";
            this.AgainstCheckbox.UseVisualStyleBackColor = false;
            this.AgainstCheckbox.CheckedChanged += new System.EventHandler(this.AgainstCheckbox_CheckedChanged);
            // 
            // CustomNameCheckBox
            // 
            this.CustomNameCheckBox.AutoSize = true;
            this.CustomNameCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.CustomNameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomNameCheckBox.ForeColor = System.Drawing.Color.White;
            this.CustomNameCheckBox.Location = new System.Drawing.Point(23, 561);
            this.CustomNameCheckBox.Name = "CustomNameCheckBox";
            this.CustomNameCheckBox.Size = new System.Drawing.Size(234, 20);
            this.CustomNameCheckBox.TabIndex = 7;
            this.CustomNameCheckBox.Text = "Enter custom name(Optional)  ";
            this.CustomNameCheckBox.UseVisualStyleBackColor = false;
            this.CustomNameCheckBox.CheckedChanged += new System.EventHandler(this.CustomNameCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(68, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Optional settings";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // customNameTextBox
            // 
            this.customNameTextBox.Location = new System.Drawing.Point(12, 580);
            this.customNameTextBox.Name = "customNameTextBox";
            this.customNameTextBox.Size = new System.Drawing.Size(257, 20);
            this.customNameTextBox.TabIndex = 8;
            this.customNameTextBox.Visible = false;
            // 
            // CreateVDCheckBox
            // 
            this.CreateVDCheckBox.AutoSize = true;
            this.CreateVDCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.CreateVDCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::VRP_Shortcut_Maker.Properties.Settings.Default, "VDChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CreateVDCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CreateVDCheckBox.ForeColor = System.Drawing.Color.White;
            this.CreateVDCheckBox.Location = new System.Drawing.Point(24, 301);
            this.CreateVDCheckBox.Name = "CreateVDCheckBox";
            this.CreateVDCheckBox.Size = new System.Drawing.Size(233, 21);
            this.CreateVDCheckBox.TabIndex = 3;
            this.CreateVDCheckBox.Text = "Virtual Desktop compatibility";
            this.CreateVDCheckBox.UseVisualStyleBackColor = false;
            this.CreateVDCheckBox.CheckedChanged += new System.EventHandler(this.CreateVDCheckBox_CheckedChanged);
            // 
            // CustomLaunchExeButton
            // 
            this.CustomLaunchExeButton.BackColor = System.Drawing.Color.White;
            this.CustomLaunchExeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomLaunchExeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.CustomLaunchExeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CustomLaunchExeButton.Location = new System.Drawing.Point(103, 202);
            this.CustomLaunchExeButton.Name = "CustomLaunchExeButton";
            this.CustomLaunchExeButton.Size = new System.Drawing.Size(75, 23);
            this.CustomLaunchExeButton.TabIndex = 21;
            this.CustomLaunchExeButton.Text = "Set exe";
            this.CustomLaunchExeButton.UseVisualStyleBackColor = false;
            this.CustomLaunchExeButton.Visible = false;
            this.CustomLaunchExeButton.Click += new System.EventHandler(this.CustomLaunchExeButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(24, 281);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(245, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Standard SteamVR arguments";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Thistle;
            this.label8.Location = new System.Drawing.Point(44, 350);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "(If not sure, leave as Default)";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Thistle;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Location = new System.Drawing.Point(34, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "(Not Required, Settings persist!)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(280, 673);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CustomLaunchExeButton);
            this.Controls.Add(this.customNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomNameCheckBox);
            this.Controls.Add(this.AgainstCheckbox);
            this.Controls.Add(this.CreateVDCheckBox);
            this.Controls.Add(this.vdPathResetButton);
            this.Controls.Add(this.argsRichTextBox);
            this.Controls.Add(this.selectExeButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.vdFolderButton);
            this.Controls.Add(this.runProgramButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameDirTextBox);
            this.Controls.Add(this.selectGameButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(296, 712);
            this.MinimumSize = new System.Drawing.Size(296, 712);
            this.Name = "Form1";
            this.Text = "VRLauncher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectGameButton;
        private System.Windows.Forms.TextBox gameDirTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button runProgramButton;
        private System.Windows.Forms.Button vdFolderButton;
        private System.Windows.Forms.Button selectExeButton;
        private System.Windows.Forms.RichTextBox argsRichTextBox;
        private System.Windows.Forms.Button vdPathResetButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox CreateVDCheckBox;
        private System.Windows.Forms.CheckBox AgainstCheckbox;
        private System.Windows.Forms.CheckBox CustomNameCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customNameTextBox;
        private System.Windows.Forms.Button CustomLaunchExeButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

