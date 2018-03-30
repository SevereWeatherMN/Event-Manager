namespace WindowsFormsApplication1
{
    partial class FieldNoteGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldNoteGenerator));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveArchiveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBoxNetwk = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonReturnFN = new System.Windows.Forms.Button();
            this.buttonExitFN = new System.Windows.Forms.Button();
            this.instructionTxt = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog4 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBoxExpt = new System.Windows.Forms.RichTextBox();
            this.nameTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.locationLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxLocation = new System.Windows.Forms.RichTextBox();
            this.checkBoxLocation = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.eventCategory = new System.Windows.Forms.ComboBox();
            this.richTextBoxTime = new System.Windows.Forms.RichTextBox();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.labelNameReminder = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filetoolStripMenuItem,
            this.printToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filetoolStripMenuItem
            // 
            this.filetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveArchiveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filetoolStripMenuItem.Name = "filetoolStripMenuItem";
            this.filetoolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filetoolStripMenuItem.Text = "File";
            this.filetoolStripMenuItem.Click += new System.EventHandler(this.filetoolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveArchiveToolStripMenuItem_Click);
            // 
            // saveArchiveAsToolStripMenuItem
            // 
            this.saveArchiveAsToolStripMenuItem.Name = "saveArchiveAsToolStripMenuItem";
            this.saveArchiveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveArchiveAsToolStripMenuItem.Text = "Save As...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.printToolStripMenuItem.Text = "Settings";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date:";
            this.toolTip4.SetToolTip(this.label2, "Insert the date here.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            this.toolTip5.SetToolTip(this.label3, "The name of the submitter goes here.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Event Category:";
            this.toolTip3.SetToolTip(this.label4, "Put the general category of the event here (tornado, flood, damaging wind gust, e" +
        "tc.)");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description:";
            this.toolTip2.SetToolTip(this.label5, "Write your observations here. Be sure to be descriptive.");
            // 
            // richTextBox5
            // 
            this.richTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox5.Location = new System.Drawing.Point(82, 383);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox5.Size = new System.Drawing.Size(390, 68);
            this.richTextBox5.TabIndex = 13;
            this.richTextBox5.Text = "";
            this.richTextBox5.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(13, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(460, 2);
            this.label6.TabIndex = 14;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Select Local Export Location:";
            this.toolTip1.SetToolTip(this.label10, "Select a location on your computer to export a Field Note.");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 526);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Enter Network Location:";
            this.toolTip1.SetToolTip(this.label11, "Select a location on your network to upload a Field Note.");
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // richTextBoxNetwk
            // 
            this.richTextBoxNetwk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNetwk.Location = new System.Drawing.Point(149, 523);
            this.richTextBoxNetwk.Name = "richTextBoxNetwk";
            this.richTextBoxNetwk.Size = new System.Drawing.Size(323, 20);
            this.richTextBoxNetwk.TabIndex = 31;
            this.richTextBoxNetwk.Text = "";
            this.richTextBoxNetwk.WordWrap = false;
            this.richTextBoxNetwk.TextChanged += new System.EventHandler(this.richTextBox9_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 617);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 32);
            this.button5.TabIndex = 33;
            this.button5.Text = "Finish";
            this.toolTip1.SetToolTip(this.button5, "Compile a Field Note and perform the requested data transfer.");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(13, 555);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(458, 2);
            this.label12.TabIndex = 34;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // buttonReturnFN
            // 
            this.buttonReturnFN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReturnFN.Location = new System.Drawing.Point(179, 617);
            this.buttonReturnFN.Name = "buttonReturnFN";
            this.buttonReturnFN.Size = new System.Drawing.Size(125, 32);
            this.buttonReturnFN.TabIndex = 43;
            this.buttonReturnFN.Text = "Return to Home";
            this.toolTip1.SetToolTip(this.buttonReturnFN, "Return to the home window to choose another option.");
            this.buttonReturnFN.UseVisualStyleBackColor = true;
            this.buttonReturnFN.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonExitFN
            // 
            this.buttonExitFN.Location = new System.Drawing.Point(342, 617);
            this.buttonExitFN.Name = "buttonExitFN";
            this.buttonExitFN.Size = new System.Drawing.Size(130, 32);
            this.buttonExitFN.TabIndex = 44;
            this.buttonExitFN.Text = "Exit";
            this.toolTip1.SetToolTip(this.buttonExitFN, "Exit the program.");
            this.buttonExitFN.UseVisualStyleBackColor = true;
            this.buttonExitFN.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // instructionTxt
            // 
            this.instructionTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.instructionTxt.Location = new System.Drawing.Point(18, 35);
            this.instructionTxt.Name = "instructionTxt";
            this.instructionTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.instructionTxt.Size = new System.Drawing.Size(460, 62);
            this.instructionTxt.TabIndex = 0;
            this.instructionTxt.Text = resources.GetString("instructionTxt.Text");
            this.instructionTxt.Click += new System.EventHandler(this.instructionTxt_Click);
            // 
            // richTextBoxExpt
            // 
            this.richTextBoxExpt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxExpt.Location = new System.Drawing.Point(168, 487);
            this.richTextBoxExpt.Name = "richTextBoxExpt";
            this.richTextBoxExpt.Size = new System.Drawing.Size(239, 20);
            this.richTextBoxExpt.TabIndex = 40;
            this.richTextBoxExpt.Text = "";
            this.richTextBoxExpt.WordWrap = false;
            this.richTextBoxExpt.TextChanged += new System.EventHandler(this.richTextBox6_TextChanged_1);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(61, 130);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.nameTextBox.Size = new System.Drawing.Size(411, 20);
            this.nameTextBox.TabIndex = 41;
            this.nameTextBox.Text = "";
            this.nameTextBox.WordWrap = false;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(15, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 2);
            this.label7.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(413, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 20);
            this.button3.TabIndex = 29;
            this.button3.Text = "Browse...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(18, 318);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(54, 13);
            this.locationLabel.TabIndex = 46;
            this.locationLabel.Text = "Location :";
            this.toolTip3.SetToolTip(this.locationLabel, "Put the general category of the event here (tornado, flood, damaging wind gust, e" +
        "tc.)");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Time:";
            this.toolTip3.SetToolTip(this.label9, "Put the general category of the event here (tornado, flood, damaging wind gust, e" +
        "tc.)");
            // 
            // toolTip4
            // 
            this.toolTip4.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip4_Popup);
            // 
            // toolTip5
            // 
            this.toolTip5.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip5_Popup);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(15, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 2);
            this.label1.TabIndex = 45;
            // 
            // richTextBoxLocation
            // 
            this.richTextBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLocation.Location = new System.Drawing.Point(77, 315);
            this.richTextBoxLocation.Name = "richTextBoxLocation";
            this.richTextBoxLocation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxLocation.Size = new System.Drawing.Size(198, 20);
            this.richTextBoxLocation.TabIndex = 47;
            this.richTextBoxLocation.Text = "";
            this.richTextBoxLocation.WordWrap = false;
            this.richTextBoxLocation.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_2);
            // 
            // checkBoxLocation
            // 
            this.checkBoxLocation.AutoSize = true;
            this.checkBoxLocation.Location = new System.Drawing.Point(291, 318);
            this.checkBoxLocation.Name = "checkBoxLocation";
            this.checkBoxLocation.Size = new System.Drawing.Size(182, 17);
            this.checkBoxLocation.TabIndex = 48;
            this.checkBoxLocation.Text = "Detect Coordinates Automatically";
            this.checkBoxLocation.UseVisualStyleBackColor = true;
            this.checkBoxLocation.CheckedChanged += new System.EventHandler(this.checkBoxLocation_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(13, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(460, 2);
            this.label8.TabIndex = 49;
            // 
            // eventCategory
            // 
            this.eventCategory.FormattingEnabled = true;
            this.eventCategory.Items.AddRange(new object[] {
            "Tornado",
            "Hail",
            "Wind Gust",
            "Heavy Rainfall",
            "Heavy Snowfall",
            "Dense Fog",
            "Other (Please Specify)"});
            this.eventCategory.Location = new System.Drawing.Point(106, 200);
            this.eventCategory.Name = "eventCategory";
            this.eventCategory.Size = new System.Drawing.Size(366, 21);
            this.eventCategory.TabIndex = 50;
            // 
            // richTextBoxTime
            // 
            this.richTextBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTime.Location = new System.Drawing.Point(77, 280);
            this.richTextBoxTime.Name = "richTextBoxTime";
            this.richTextBoxTime.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxTime.Size = new System.Drawing.Size(198, 20);
            this.richTextBoxTime.TabIndex = 51;
            this.richTextBoxTime.Text = "";
            this.richTextBoxTime.WordWrap = false;
            this.richTextBoxTime.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged_1);
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Location = new System.Drawing.Point(291, 283);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(146, 17);
            this.checkBoxTime.TabIndex = 53;
            this.checkBoxTime.Text = "DetectTime Automatically";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            this.checkBoxTime.CheckedChanged += new System.EventHandler(this.checkBoxTime_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(13, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Time and Location";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(15, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "General Information";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(12, 346);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "Notes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(13, 459);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 67;
            this.label16.Text = "Exporting";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBoxYear.Location = new System.Drawing.Point(167, 164);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(62, 21);
            this.comboBoxYear.TabIndex = 68;
            this.comboBoxYear.Text = "YYYY";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(61, 164);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(47, 21);
            this.comboBoxMonth.TabIndex = 69;
            this.comboBoxMonth.Text = "MM";
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDay.Location = new System.Drawing.Point(114, 164);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(47, 21);
            this.comboBoxDay.TabIndex = 70;
            this.comboBoxDay.Text = "DD";
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(246, 167);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(149, 17);
            this.checkBoxDate.TabIndex = 72;
            this.checkBoxDate.Text = "Detect Date Automatically";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // labelNameReminder
            // 
            this.labelNameReminder.AcceptsTab = true;
            this.labelNameReminder.BackColor = System.Drawing.SystemColors.Control;
            this.labelNameReminder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelNameReminder.Enabled = false;
            this.labelNameReminder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNameReminder.Location = new System.Drawing.Point(16, 579);
            this.labelNameReminder.Name = "labelNameReminder";
            this.labelNameReminder.ReadOnly = true;
            this.labelNameReminder.Size = new System.Drawing.Size(456, 32);
            this.labelNameReminder.TabIndex = 73;
            this.labelNameReminder.Text = "*The filename will consist of the date, time, and organization tag as specified i" +
    "n settings.";
            this.labelNameReminder.TextChanged += new System.EventHandler(this.labelNameReminder_TextChanged);
            // 
            // FieldNoteGenerator
            // 
            this.AcceptButton = this.button5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonReturnFN;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.labelNameReminder);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.checkBoxTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richTextBoxTime);
            this.Controls.Add(this.eventCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxLocation);
            this.Controls.Add(this.richTextBoxLocation);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExitFN);
            this.Controls.Add(this.buttonReturnFN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.richTextBoxExpt);
            this.Controls.Add(this.instructionTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBoxNetwk);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FieldNoteGenerator";
            this.Text = "Field Note Generator";
            this.Load += new System.EventHandler(this.SSRC_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBoxNetwk;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem filetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveArchiveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label instructionTxt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog4;
        private System.Windows.Forms.RichTextBox richTextBoxExpt;
        private System.Windows.Forms.RichTextBox nameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button buttonReturnFN;
        private System.Windows.Forms.Button buttonExitFN;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.RichTextBox richTextBoxLocation;
        private System.Windows.Forms.CheckBox checkBoxLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox eventCategory;
        private System.Windows.Forms.RichTextBox richTextBoxTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.RichTextBox labelNameReminder;
    }
}

