﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;


namespace WindowsFormsApplication1
{
    public partial class Archive_Builder : Form
    {
        public Archive_Builder()
        {
            InitializeComponent();
        }

        private void Archive_Builder_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\tmp");
        }

        private void Archive_Builder_Load (object sender, EventArgs e)
        {
            browseButtonNexrd.Enabled = false;
            browseButtonMedia.Enabled = false;
            browseButtonSR.Enabled = false;
        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxMedia_CheckedChanged(object sender, EventArgs e)
            //Browse button should be grayed out in the beginning but it isn't.
        {
            {
                if (checkBoxMedia.Checked == false)
                {
                    browseButtonMedia.Enabled = false;
                }
                if (checkBoxMedia.Checked == true)
                {
                    browseButtonMedia.Enabled = true;
                }
              
            }

        }

        private void instructionTxt_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void browseButtonExpt_Click(object sender, EventArgs e)
        {
       
        }

        private void browseButtonNetwk_Click(object sender, EventArgs e)
        {
            DialogResult result = NetwkBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBoxNetwk.Text = NetwkBrowserDialog.SelectedPath;
            }
        }

        private void browseButtonExpt_Click_1(object sender, EventArgs e)
        {
            
        }

        private void richTextBoxStmRpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNexrad_CheckedChanged(object sender, EventArgs e)
        //Browse button should be grayed out in the beginning but it isn't.
        {
            {
                if (checkBoxNexrad.Checked == false)
                {
                    browseButtonNexrd.Enabled = false;
                }

                if (checkBoxNexrad.Checked == true)
                {
                    browseButtonNexrd.Enabled = true;
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //Browse button should be grayed out in the beginning but it isn't.
        {
            {
                if (checkBox1.Checked == false)
                {
                    browseButtonSR.Enabled = false;
                }
                if (checkBox1.Checked == true)
                {
                    browseButtonSR.Enabled = true;
                }
            }

        }

        private void richTextBoxExpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseButtonNexrd_Click(object sender, EventArgs e)
        {
            DialogResult result = NexrdBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBoxNexrad.Text = NexrdBrowserDialog.SelectedPath;
            }
        }

        private void browseButtonSR_Click(object sender, EventArgs e)
        {
            DialogResult result = SRBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBoxStmRpt.Text = SRBrowserDialog.SelectedPath;
            }
        }

        private void browseButtonExpt_Click_2(object sender, EventArgs e)
        {
            DialogResult result = ExportBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBoxExpt.Text = ExportBrowserDialog.SelectedPath;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stormReportDir_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


            System.IO.Directory.CreateDirectory(@"C:\tmp\Storm Reports");
           
        }

        private void richTextBox7Media_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseButtonMedia_Click(object sender, EventArgs e)
        {
            DialogResult result = MediaBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox7Media.Text = MediaBrowserDialog.SelectedPath;
            }
        }

        private void richTextBoxNetwk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void nexradDir_Click(object sender, EventArgs e)
        {

        }

        private void mediaDir_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsWindow sw = new settingsWindow();
            sw.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow aw = new aboutWindow();
            aw.Show();
        }
    }
}
