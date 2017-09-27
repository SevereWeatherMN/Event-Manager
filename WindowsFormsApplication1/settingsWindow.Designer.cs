namespace WindowsFormsApplication1
{
    partial class settingsWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsWindow));
            this.instructionTxt = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPsswd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxArchName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxTimeZone = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTZSelected = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructionTxt
            // 
            this.instructionTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.instructionTxt.Location = new System.Drawing.Point(12, 9);
            this.instructionTxt.Name = "instructionTxt";
            this.instructionTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.instructionTxt.Size = new System.Drawing.Size(400, 43);
            this.instructionTxt.TabIndex = 61;
            this.instructionTxt.Text = "These settings should be set up properly and not need modification. Your credenti" +
    "als will be saved each time the program runs.";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(73, 73);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(338, 20);
            this.textBoxUsername.TabIndex = 62;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsermane_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "FTP Server Login Information";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 2);
            this.label2.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Username:";
            // 
            // textBoxPsswd
            // 
            this.textBoxPsswd.Location = new System.Drawing.Point(73, 99);
            this.textBoxPsswd.Name = "textBoxPsswd";
            this.textBoxPsswd.Size = new System.Drawing.Size(338, 20);
            this.textBoxPsswd.TabIndex = 66;
            this.textBoxPsswd.UseSystemPasswordChar = true;
            this.textBoxPsswd.TextChanged += new System.EventHandler(this.textBoxPsswd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Password:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(337, 322);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 68;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(256, 322);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 69;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Data Management";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(11, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 2);
            this.label6.TabIndex = 71;
            // 
            // textBoxArchName
            // 
            this.textBoxArchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArchName.Location = new System.Drawing.Point(164, 256);
            this.textBoxArchName.Name = "textBoxArchName";
            this.textBoxArchName.Size = new System.Drawing.Size(247, 20);
            this.textBoxArchName.TabIndex = 72;
            this.textBoxArchName.TextChanged += new System.EventHandler(this.textBoxArchName_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Default Archive Name Format:";
            this.toolTip1.SetToolTip(this.label7, "This feature will name all event archives similarily, keeping things organized. Y" +
        "ou could use the name of your storm chasing organization (for example, [Date-Tim" +
        "e]-NWS-SKYWARN-ARCHIVES)");
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(12, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Note: Time and date will be added to the name beginning automatically.";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "Lets each archive have a similar name. Example Name Format: Weather-Event-Archive" +
    "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(175, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 75;
            this.button1.Text = "Temp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(13, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Time Zone";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(11, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(400, 2);
            this.label10.TabIndex = 77;
            // 
            // comboBoxTimeZone
            // 
            this.comboBoxTimeZone.FormattingEnabled = true;
            this.comboBoxTimeZone.Items.AddRange(new object[] {
            "GMT - Greenwich Mean Time    GMT",
            "UTC - Universal Coordinated Time    GMT",
            "HST - Hawaii Standard Time    -10:00",
            "AST - Alaska Standard Time    -9:00",
            "PST - Pacific Standard Time    -8:00",
            "PNT - Phoenix Standard Time    -7:00",
            "MST - Mountain Standard Time\t    -7:00",
            "CST - Central Standard Time    -6:00",
            "EST - Eastern Standard Time    -5:00",
            "IET - Indiana Eastern Standard Time    -5:00",
            "PRT - Puerto Rico and US Virgin Islands Time    -4:00"});
            this.comboBoxTimeZone.Location = new System.Drawing.Point(125, 163);
            this.comboBoxTimeZone.Name = "comboBoxTimeZone";
            this.comboBoxTimeZone.Size = new System.Drawing.Size(286, 21);
            this.comboBoxTimeZone.TabIndex = 78;
            this.comboBoxTimeZone.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Select Time Zone:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "Selected Time Zone:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBoxTZSelected
            // 
            this.textBoxTZSelected.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTZSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTZSelected.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxTZSelected.Location = new System.Drawing.Point(125, 195);
            this.textBoxTZSelected.Name = "textBoxTZSelected";
            this.textBoxTZSelected.Size = new System.Drawing.Size(286, 13);
            this.textBoxTZSelected.TabIndex = 81;
            // 
            // settingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 351);
            this.Controls.Add(this.textBoxTZSelected);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxTimeZone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxArchName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPsswd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.instructionTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsWindow";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionTxt;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPsswd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxArchName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxTimeZone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTZSelected;
    }
}