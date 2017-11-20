namespace WindowsFormsApplication1
{
    partial class Archive_Builder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archive_Builder));
            this.richTextBox7Media = new System.Windows.Forms.RichTextBox();
            this.richTextBoxExpt = new System.Windows.Forms.RichTextBox();
            this.checkBoxNexrad = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBoxNetwk = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBoxNexrad = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.browseBtnRadar = new System.Windows.Forms.Button();
            this.nexradDir = new System.Windows.Forms.Label();
            this.checkBoxMedia = new System.Windows.Forms.CheckBox();
            this.mediaDir = new System.Windows.Forms.Label();
            this.browseBtnMedia = new System.Windows.Forms.Button();
            this.buttonFinishAB = new System.Windows.Forms.Button();
            this.instructionTxt = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBoxStmRpt = new System.Windows.Forms.RichTextBox();
            this.stormReportDir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browseButtonExpt = new System.Windows.Forms.Button();
            this.browseButtonSR = new System.Windows.Forms.Button();
            this.browseButtonNexrd = new System.Windows.Forms.Button();
            this.browseButtonMedia = new System.Windows.Forms.Button();
            this.SRBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.NexrdBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MediaBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ExportBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.NetwkBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somethingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonExitAB = new System.Windows.Forms.Button();
            this.buttonReturnAB = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox7Media
            // 
            this.richTextBox7Media.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox7Media.Location = new System.Drawing.Point(146, 273);
            this.richTextBox7Media.Name = "richTextBox7Media";
            this.richTextBox7Media.Size = new System.Drawing.Size(220, 20);
            this.richTextBox7Media.TabIndex = 57;
            this.richTextBox7Media.Text = "";
            this.richTextBox7Media.WordWrap = false;
            this.richTextBox7Media.TextChanged += new System.EventHandler(this.richTextBox7Media_TextChanged);
            // 
            // richTextBoxExpt
            // 
            this.richTextBoxExpt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxExpt.Location = new System.Drawing.Point(157, 323);
            this.richTextBoxExpt.Name = "richTextBoxExpt";
            this.richTextBoxExpt.Size = new System.Drawing.Size(209, 20);
            this.richTextBoxExpt.TabIndex = 56;
            this.richTextBoxExpt.Text = "";
            this.richTextBoxExpt.WordWrap = false;
            this.richTextBoxExpt.TextChanged += new System.EventHandler(this.richTextBoxExpt_TextChanged);
            // 
            // checkBoxNexrad
            // 
            this.checkBoxNexrad.AutoSize = true;
            this.checkBoxNexrad.Location = new System.Drawing.Point(26, 135);
            this.checkBoxNexrad.Name = "checkBoxNexrad";
            this.checkBoxNexrad.Size = new System.Drawing.Size(233, 17);
            this.checkBoxNexrad.TabIndex = 55;
            this.checkBoxNexrad.Text = "Include NEXRAD data (radar files) in upload";
            this.toolTip1.SetToolTip(this.checkBoxNexrad, "Choose weather you want to include NEXRAD Data in your weather event archive.");
            this.checkBoxNexrad.UseVisualStyleBackColor = true;
            this.checkBoxNexrad.CheckedChanged += new System.EventHandler(this.checkBoxNexrad_CheckedChanged);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(10, 385);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(421, 2);
            this.label12.TabIndex = 54;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(446, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 20);
            this.button4.TabIndex = 53;
            this.button4.Text = "Browse...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // richTextBoxNetwk
            // 
            this.richTextBoxNetwk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNetwk.Location = new System.Drawing.Point(140, 354);
            this.richTextBoxNetwk.Name = "richTextBoxNetwk";
            this.richTextBoxNetwk.Size = new System.Drawing.Size(291, 20);
            this.richTextBoxNetwk.TabIndex = 52;
            this.richTextBoxNetwk.Text = "";
            this.richTextBoxNetwk.WordWrap = false;
            this.richTextBoxNetwk.TextChanged += new System.EventHandler(this.richTextBoxNetwk_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Select Network Location:";
            this.toolTip1.SetToolTip(this.label11, "Choose a network location to export your archive (FTP Sever, Network Drive, etc.)" +
        "");
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(446, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 20);
            this.button3.TabIndex = 50;
            this.button3.Text = "Browse...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // richTextBoxNexrad
            // 
            this.richTextBoxNexrad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNexrad.Location = new System.Drawing.Point(188, 239);
            this.richTextBoxNexrad.Name = "richTextBoxNexrad";
            this.richTextBoxNexrad.Size = new System.Drawing.Size(178, 20);
            this.richTextBoxNexrad.TabIndex = 49;
            this.richTextBoxNexrad.Text = "";
            this.richTextBoxNexrad.WordWrap = false;
            this.richTextBoxNexrad.TextChanged += new System.EventHandler(this.richTextBox8_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Select Local Export Location:";
            this.toolTip1.SetToolTip(this.label10, "Choose where you want to export your archive to on your computer.");
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(10, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(421, 2);
            this.label9.TabIndex = 47;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // browseBtnRadar
            // 
            this.browseBtnRadar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBtnRadar.Enabled = false;
            this.browseBtnRadar.Location = new System.Drawing.Point(446, 116);
            this.browseBtnRadar.Name = "browseBtnRadar";
            this.browseBtnRadar.Size = new System.Drawing.Size(60, 20);
            this.browseBtnRadar.TabIndex = 46;
            this.browseBtnRadar.Text = "Browse...";
            this.browseBtnRadar.UseVisualStyleBackColor = true;
            // 
            // nexradDir
            // 
            this.nexradDir.AutoSize = true;
            this.nexradDir.Location = new System.Drawing.Point(23, 242);
            this.nexradDir.Name = "nexradDir";
            this.nexradDir.Size = new System.Drawing.Size(159, 13);
            this.nexradDir.TabIndex = 45;
            this.nexradDir.Text = "Select NEXRAD Data Directory:";
            this.toolTip1.SetToolTip(this.nexradDir, "Choose a directory where NEXRAD files are stored to include them in your archive." +
        "\r\n");
            this.nexradDir.Click += new System.EventHandler(this.nexradDir_Click);
            // 
            // checkBoxMedia
            // 
            this.checkBoxMedia.AutoSize = true;
            this.checkBoxMedia.Location = new System.Drawing.Point(26, 159);
            this.checkBoxMedia.Name = "checkBoxMedia";
            this.checkBoxMedia.Size = new System.Drawing.Size(218, 17);
            this.checkBoxMedia.TabIndex = 44;
            this.checkBoxMedia.Text = "Include Media (Photos/Videos) in upload";
            this.toolTip1.SetToolTip(this.checkBoxMedia, "Choose weather you want to include photos or videos in your weather event archive" +
        ".");
            this.checkBoxMedia.UseVisualStyleBackColor = true;
            this.checkBoxMedia.CheckedChanged += new System.EventHandler(this.checkBoxMedia_CheckedChanged);
            // 
            // mediaDir
            // 
            this.mediaDir.AutoSize = true;
            this.mediaDir.Location = new System.Drawing.Point(23, 276);
            this.mediaDir.Name = "mediaDir";
            this.mediaDir.Size = new System.Drawing.Size(117, 13);
            this.mediaDir.TabIndex = 43;
            this.mediaDir.Text = "Select Media Directory:";
            this.toolTip1.SetToolTip(this.mediaDir, "Choose a directory where photographs and videos are stored to include them in you" +
        "r archive.\r\n");
            this.mediaDir.Click += new System.EventHandler(this.mediaDir_Click);
            // 
            // browseBtnMedia
            // 
            this.browseBtnMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBtnMedia.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.browseBtnMedia.Enabled = false;
            this.browseBtnMedia.Location = new System.Drawing.Point(446, 90);
            this.browseBtnMedia.Name = "browseBtnMedia";
            this.browseBtnMedia.Size = new System.Drawing.Size(60, 20);
            this.browseBtnMedia.TabIndex = 42;
            this.browseBtnMedia.Text = "Browse...";
            this.browseBtnMedia.UseVisualStyleBackColor = true;
            // 
            // buttonFinishAB
            // 
            this.buttonFinishAB.Location = new System.Drawing.Point(10, 402);
            this.buttonFinishAB.Name = "buttonFinishAB";
            this.buttonFinishAB.Size = new System.Drawing.Size(127, 32);
            this.buttonFinishAB.TabIndex = 58;
            this.buttonFinishAB.Text = "Finish";
            this.toolTip1.SetToolTip(this.buttonFinishAB, "Compile the archive and perform the requested operations.");
            this.buttonFinishAB.UseVisualStyleBackColor = true;
            this.buttonFinishAB.Click += new System.EventHandler(this.button5_Click);
            // 
            // instructionTxt
            // 
            this.instructionTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.instructionTxt.Location = new System.Drawing.Point(13, 30);
            this.instructionTxt.Name = "instructionTxt";
            this.instructionTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.instructionTxt.Size = new System.Drawing.Size(418, 67);
            this.instructionTxt.TabIndex = 60;
            this.instructionTxt.Text = resources.GetString("instructionTxt.Text");
            this.instructionTxt.Click += new System.EventHandler(this.instructionTxt_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 112);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 17);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.Text = "Include Field Notes in upload";
            this.toolTip1.SetToolTip(this.checkBox1, "Choose weather you want to include Field Notes in your weather event archive.");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // richTextBoxStmRpt
            // 
            this.richTextBoxStmRpt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxStmRpt.Location = new System.Drawing.Point(165, 206);
            this.richTextBoxStmRpt.Name = "richTextBoxStmRpt";
            this.richTextBoxStmRpt.Size = new System.Drawing.Size(201, 20);
            this.richTextBoxStmRpt.TabIndex = 63;
            this.richTextBoxStmRpt.Text = "";
            this.richTextBoxStmRpt.WordWrap = false;
            this.richTextBoxStmRpt.TextChanged += new System.EventHandler(this.richTextBoxStmRpt_TextChanged);
            // 
            // stormReportDir
            // 
            this.stormReportDir.AutoSize = true;
            this.stormReportDir.Location = new System.Drawing.Point(23, 209);
            this.stormReportDir.Name = "stormReportDir";
            this.stormReportDir.Size = new System.Drawing.Size(136, 13);
            this.stormReportDir.TabIndex = 62;
            this.stormReportDir.Text = "Select Field Note Directory:";
            this.toolTip1.SetToolTip(this.stormReportDir, "Choose a directory where field notes are stored to include them in your archive.");
            this.stormReportDir.Click += new System.EventHandler(this.stormReportDir_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 2);
            this.label1.TabIndex = 64;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(10, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 2);
            this.label2.TabIndex = 65;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // browseButtonExpt
            // 
            this.browseButtonExpt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButtonExpt.Location = new System.Drawing.Point(371, 323);
            this.browseButtonExpt.Name = "browseButtonExpt";
            this.browseButtonExpt.Size = new System.Drawing.Size(60, 20);
            this.browseButtonExpt.TabIndex = 68;
            this.browseButtonExpt.Text = "Browse...";
            this.browseButtonExpt.UseVisualStyleBackColor = true;
            this.browseButtonExpt.Click += new System.EventHandler(this.browseButtonExpt_Click_2);
            // 
            // browseButtonSR
            // 
            this.browseButtonSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButtonSR.Location = new System.Drawing.Point(372, 205);
            this.browseButtonSR.Name = "browseButtonSR";
            this.browseButtonSR.Size = new System.Drawing.Size(60, 20);
            this.browseButtonSR.TabIndex = 69;
            this.browseButtonSR.Text = "Browse...";
            this.browseButtonSR.UseVisualStyleBackColor = true;
            this.browseButtonSR.Click += new System.EventHandler(this.browseButtonSR_Click);
            // 
            // browseButtonNexrd
            // 
            this.browseButtonNexrd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButtonNexrd.Location = new System.Drawing.Point(372, 238);
            this.browseButtonNexrd.Name = "browseButtonNexrd";
            this.browseButtonNexrd.Size = new System.Drawing.Size(60, 20);
            this.browseButtonNexrd.TabIndex = 70;
            this.browseButtonNexrd.Text = "Browse...";
            this.browseButtonNexrd.UseVisualStyleBackColor = true;
            this.browseButtonNexrd.Click += new System.EventHandler(this.browseButtonNexrd_Click);
            // 
            // browseButtonMedia
            // 
            this.browseButtonMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButtonMedia.Location = new System.Drawing.Point(372, 272);
            this.browseButtonMedia.Name = "browseButtonMedia";
            this.browseButtonMedia.Size = new System.Drawing.Size(60, 20);
            this.browseButtonMedia.TabIndex = 71;
            this.browseButtonMedia.Text = "Browse...";
            this.browseButtonMedia.UseVisualStyleBackColor = true;
            this.browseButtonMedia.Click += new System.EventHandler(this.browseButtonMedia_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somethingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // somethingToolStripMenuItem
            // 
            this.somethingToolStripMenuItem.Name = "somethingToolStripMenuItem";
            this.somethingToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.somethingToolStripMenuItem.Text = "Home";
            this.somethingToolStripMenuItem.Click += new System.EventHandler(this.somethingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
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
            // buttonExitAB
            // 
            this.buttonExitAB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExitAB.Location = new System.Drawing.Point(305, 402);
            this.buttonExitAB.Name = "buttonExitAB";
            this.buttonExitAB.Size = new System.Drawing.Size(127, 32);
            this.buttonExitAB.TabIndex = 73;
            this.buttonExitAB.Text = "Exit";
            this.toolTip1.SetToolTip(this.buttonExitAB, "Exit the program.");
            this.buttonExitAB.UseVisualStyleBackColor = true;
            this.buttonExitAB.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReturnAB
            // 
            this.buttonReturnAB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReturnAB.Location = new System.Drawing.Point(157, 402);
            this.buttonReturnAB.Name = "buttonReturnAB";
            this.buttonReturnAB.Size = new System.Drawing.Size(127, 32);
            this.buttonReturnAB.TabIndex = 74;
            this.buttonReturnAB.Text = "Return to Home";
            this.toolTip1.SetToolTip(this.buttonReturnAB, "Return to the home window to choose another option.");
            this.buttonReturnAB.UseVisualStyleBackColor = true;
            this.buttonReturnAB.Click += new System.EventHandler(this.buttonReturnAB_Click);
            // 
            // Archive_Builder
            // 
            this.AcceptButton = this.buttonFinishAB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReturnAB;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.buttonReturnAB);
            this.Controls.Add(this.buttonExitAB);
            this.Controls.Add(this.browseButtonMedia);
            this.Controls.Add(this.browseButtonNexrd);
            this.Controls.Add(this.browseButtonSR);
            this.Controls.Add(this.browseButtonExpt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxStmRpt);
            this.Controls.Add(this.stormReportDir);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.instructionTxt);
            this.Controls.Add(this.buttonFinishAB);
            this.Controls.Add(this.richTextBox7Media);
            this.Controls.Add(this.richTextBoxExpt);
            this.Controls.Add(this.checkBoxNexrad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBoxNetwk);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBoxNexrad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.browseBtnRadar);
            this.Controls.Add(this.nexradDir);
            this.Controls.Add(this.checkBoxMedia);
            this.Controls.Add(this.mediaDir);
            this.Controls.Add(this.browseBtnMedia);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Archive_Builder";
            this.Text = "Weather Event Archive Builder";
            this.Load += new System.EventHandler(this.Archive_Builder_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.RichTextBox richTextBox7Media;
        private System.Windows.Forms.RichTextBox richTextBoxExpt;
        private System.Windows.Forms.CheckBox checkBoxNexrad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBoxNetwk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBoxNexrad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button browseBtnRadar;
        private System.Windows.Forms.Label nexradDir;
        private System.Windows.Forms.CheckBox checkBoxMedia;
        private System.Windows.Forms.Label mediaDir;
        private System.Windows.Forms.Button browseBtnMedia;
        private System.Windows.Forms.Button buttonFinishAB;
        private System.Windows.Forms.Label instructionTxt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBoxStmRpt;
        private System.Windows.Forms.Label stormReportDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseButtonExpt;
        private System.Windows.Forms.Button browseButtonSR;
        private System.Windows.Forms.Button browseButtonNexrd;
        private System.Windows.Forms.Button browseButtonMedia;
        private System.Windows.Forms.FolderBrowserDialog SRBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog NexrdBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog MediaBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog ExportBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog NetwkBrowserDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somethingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button buttonExitAB;
        private System.Windows.Forms.Button buttonReturnAB;
        private System.Windows.Forms.ToolTip toolTip1;
        //private System.Windows.Forms.Button browseButtonExpt;
        //private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
       //browse buttons dont work on archive builder

    }
}