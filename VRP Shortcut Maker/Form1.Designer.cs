
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
            this.selectGameButton.Location = new System.Drawing.Point(63, 150);
            this.selectGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectGameButton.Name = "selectGameButton";
            this.selectGameButton.Size = new System.Drawing.Size(249, 28);
            this.selectGameButton.TabIndex = 1;
            this.selectGameButton.Text = "Find Game Exe";
            this.selectGameButton.UseVisualStyleBackColor = false;
            this.selectGameButton.Click += new System.EventHandler(this.selectGameButton_Click);
            // 
            // gameDirTextBox
            // 
            this.gameDirTextBox.BackColor = System.Drawing.Color.White;
            this.gameDirTextBox.Location = new System.Drawing.Point(16, 117);
            this.gameDirTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameDirTextBox.Name = "gameDirTextBox";
            this.gameDirTextBox.Size = new System.Drawing.Size(341, 22);
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
            this.label1.Location = new System.Drawing.Point(-3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
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
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select game\'s MAIN directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.Thistle;
            this.label3.Location = new System.Drawing.Point(52, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
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
            this.label4.Location = new System.Drawing.Point(79, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
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
            this.label5.Location = new System.Drawing.Point(20, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "(Not required, one per line, e.g., -NoWindow)";
            // 
            // runProgramButton
            // 
            this.runProgramButton.BackColor = System.Drawing.Color.PaleGreen;
            this.runProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runProgramButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.runProgramButton.Location = new System.Drawing.Point(63, 758);
            this.runProgramButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runProgramButton.Name = "runProgramButton";
            this.runProgramButton.Size = new System.Drawing.Size(249, 49);
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
            this.vdFolderButton.Location = new System.Drawing.Point(193, 454);
            this.vdFolderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vdFolderButton.Name = "vdFolderButton";
            this.vdFolderButton.Size = new System.Drawing.Size(92, 32);
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
            this.selectExeButton.Location = new System.Drawing.Point(63, 185);
            this.selectExeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectExeButton.Name = "selectExeButton";
            this.selectExeButton.Size = new System.Drawing.Size(249, 28);
            this.selectExeButton.TabIndex = 2;
            this.selectExeButton.Text = "Manually Select Game Exe";
            this.selectExeButton.UseVisualStyleBackColor = false;
            this.selectExeButton.Visible = false;
            this.selectExeButton.Click += new System.EventHandler(this.selectExeButton_Click);
            // 
            // argsRichTextBox
            // 
            this.argsRichTextBox.BackColor = System.Drawing.Color.White;
            this.argsRichTextBox.Location = new System.Drawing.Point(16, 542);
            this.argsRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.argsRichTextBox.Name = "argsRichTextBox";
            this.argsRichTextBox.Size = new System.Drawing.Size(340, 143);
            this.argsRichTextBox.TabIndex = 7;
            this.argsRichTextBox.Text = "";
            // 
            // vdPathResetButton
            // 
            this.vdPathResetButton.BackColor = System.Drawing.Color.White;
            this.vdPathResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vdPathResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vdPathResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.vdPathResetButton.Location = new System.Drawing.Point(88, 454);
            this.vdPathResetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vdPathResetButton.Name = "vdPathResetButton";
            this.vdPathResetButton.Size = new System.Drawing.Size(87, 31);
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
            this.label10.Location = new System.Drawing.Point(79, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 20);
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
            this.label11.Location = new System.Drawing.Point(187, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 18);
            this.label11.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label14.Location = new System.Drawing.Point(293, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 29);
            this.label14.TabIndex = 2;
            this.label14.Text = "v1.2.2";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Thistle;
            this.label15.Location = new System.Drawing.Point(1, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "VRP-HarryEffinPotter";
            // 
            // AgainstCheckbox
            // 
            this.AgainstCheckbox.AutoSize = true;
            this.AgainstCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.AgainstCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.AgainstCheckbox.ForeColor = System.Drawing.Color.LightCoral;
            this.AgainstCheckbox.Location = new System.Drawing.Point(31, 222);
            this.AgainstCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgainstCheckbox.Name = "AgainstCheckbox";
            this.AgainstCheckbox.Size = new System.Drawing.Size(297, 21);
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
            this.CustomNameCheckBox.Location = new System.Drawing.Point(31, 690);
            this.CustomNameCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomNameCheckBox.Name = "CustomNameCheckBox";
            this.CustomNameCheckBox.Size = new System.Drawing.Size(290, 24);
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
            this.label6.Location = new System.Drawing.Point(91, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Optional settings";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // customNameTextBox
            // 
            this.customNameTextBox.Location = new System.Drawing.Point(16, 714);
            this.customNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customNameTextBox.Name = "customNameTextBox";
            this.customNameTextBox.Size = new System.Drawing.Size(341, 22);
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
            this.CreateVDCheckBox.Location = new System.Drawing.Point(32, 370);
            this.CreateVDCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateVDCheckBox.Name = "CreateVDCheckBox";
            this.CreateVDCheckBox.Size = new System.Drawing.Size(273, 24);
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
            this.CustomLaunchExeButton.Location = new System.Drawing.Point(137, 249);
            this.CustomLaunchExeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomLaunchExeButton.Name = "CustomLaunchExeButton";
            this.CustomLaunchExeButton.Size = new System.Drawing.Size(100, 28);
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
            this.checkBox1.Location = new System.Drawing.Point(32, 346);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(284, 24);
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
            this.label8.Location = new System.Drawing.Point(59, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 18);
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
            this.label7.Location = new System.Drawing.Point(45, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "(Not Required, Settings persist!)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(371, 818);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(389, 865);
            this.MinimumSize = new System.Drawing.Size(389, 865);
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

