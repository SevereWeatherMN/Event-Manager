namespace WindowsFormsApplication1
{
    partial class SSRC
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveArchiveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.instructionTxt = new System.Windows.Forms.Label();
            this.labelOutputName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog4 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.nameTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonReturnFN = new System.Windows.Forms.Button();
            this.buttonExitFN = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
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
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(14, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 0);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date:";
            this.toolTip4.SetToolTip(this.label2, "Insert the date here.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            this.toolTip5.SetToolTip(this.label3, "The name of the submitter goes here.");
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox2.Location = new System.Drawing.Point(56, 51);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(373, 20);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            this.richTextBox2.WordWrap = false;
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(59, 143);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox3.Size = new System.Drawing.Size(371, 20);
            this.richTextBox3.TabIndex = 9;
            this.richTextBox3.Text = "";
            this.richTextBox3.WordWrap = false;
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Event:";
            this.toolTip3.SetToolTip(this.label4, "Put the general category of the event here (tornado, flood, damaging wind gust, e" +
        "tc.)");
            // 
            // richTextBox4
            // 
            this.richTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox4.Location = new System.Drawing.Point(59, 181);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox4.Size = new System.Drawing.Size(371, 20);
            this.richTextBox4.TabIndex = 11;
            this.richTextBox4.Text = "";
            this.richTextBox4.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 223);
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
            this.richTextBox5.Location = new System.Drawing.Point(81, 220);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox5.Size = new System.Drawing.Size(348, 71);
            this.richTextBox5.TabIndex = 13;
            this.richTextBox5.Text = "";
            this.richTextBox5.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(418, 2);
            this.label6.TabIndex = 14;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Select Local Export Location:";
            this.toolTip1.SetToolTip(this.label10, "Select a location on your computer to export a storm report.");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Enter Network Location:";
            this.toolTip1.SetToolTip(this.label11, "Select a location on your network to upload a storm report.");
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // richTextBox9
            // 
            this.richTextBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox9.Location = new System.Drawing.Point(148, 363);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(281, 20);
            this.richTextBox9.TabIndex = 31;
            this.richTextBox9.Text = "";
            this.richTextBox9.WordWrap = false;
            this.richTextBox9.TextChanged += new System.EventHandler(this.richTextBox9_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 450);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 32);
            this.button5.TabIndex = 33;
            this.button5.Text = "Finish";
            this.toolTip1.SetToolTip(this.button5, "Compile a storm report and perform the requested data transfer.");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(15, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(418, 2);
            this.label12.TabIndex = 34;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // instructionTxt
            // 
            this.instructionTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.instructionTxt.Location = new System.Drawing.Point(14, 36);
            this.instructionTxt.Name = "instructionTxt";
            this.instructionTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.instructionTxt.Size = new System.Drawing.Size(418, 53);
            this.instructionTxt.TabIndex = 0;
            this.instructionTxt.Text = "You can use this feature to submit storm reports to your server or network drive," +
    " or export to a local location. Fields shouldn\'t be left blank; be sure to be de" +
    "scriptive.";
            this.instructionTxt.Click += new System.EventHandler(this.instructionTxt_Click);
            // 
            // labelOutputName
            // 
            this.labelOutputName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOutputName.AutoSize = true;
            this.labelOutputName.Location = new System.Drawing.Point(15, 414);
            this.labelOutputName.Name = "labelOutputName";
            this.labelOutputName.Size = new System.Drawing.Size(87, 13);
            this.labelOutputName.TabIndex = 38;
            this.labelOutputName.Text = "Output Filename:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(108, 411);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(321, 20);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // richTextBox6
            // 
            this.richTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox6.Location = new System.Drawing.Point(167, 327);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(197, 20);
            this.richTextBox6.TabIndex = 40;
            this.richTextBox6.Text = "";
            this.richTextBox6.WordWrap = false;
            this.richTextBox6.TextChanged += new System.EventHandler(this.richTextBox6_TextChanged_1);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(59, 111);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.nameTextBox.Size = new System.Drawing.Size(370, 20);
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
            this.label7.Location = new System.Drawing.Point(14, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 2);
            this.label7.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(369, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 20);
            this.button3.TabIndex = 29;
            this.button3.Text = "Browse...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonReturnFN
            // 
            this.buttonReturnFN.Location = new System.Drawing.Point(156, 450);
            this.buttonReturnFN.Name = "buttonReturnFN";
            this.buttonReturnFN.Size = new System.Drawing.Size(125, 32);
            this.buttonReturnFN.TabIndex = 43;
            this.buttonReturnFN.Text = "Return to Home";
            this.toolTip1.SetToolTip(this.buttonReturnFN, "Compile a storm report and perform the requested data transfer.");
            this.buttonReturnFN.UseVisualStyleBackColor = true;
            this.buttonReturnFN.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonExitFN
            // 
            this.buttonExitFN.Location = new System.Drawing.Point(299, 450);
            this.buttonExitFN.Name = "buttonExitFN";
            this.buttonExitFN.Size = new System.Drawing.Size(130, 32);
            this.buttonExitFN.TabIndex = 44;
            this.buttonExitFN.Text = "Exit";
            this.toolTip1.SetToolTip(this.buttonExitFN, "Compile a storm report and perform the requested data transfer.");
            this.buttonExitFN.UseVisualStyleBackColor = true;
            this.buttonExitFN.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // SSRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(442, 494);
            this.Controls.Add(this.buttonExitFN);
            this.Controls.Add(this.buttonReturnFN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelOutputName);
            this.Controls.Add(this.instructionTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBox9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SSRC";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem filetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveArchiveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label instructionTxt;
        private System.Windows.Forms.Label labelOutputName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog4;
        private System.Windows.Forms.RichTextBox richTextBox6;
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
    }
}

