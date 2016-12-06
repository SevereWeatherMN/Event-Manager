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
    public partial class SSRC : Form
    {
        public SSRC()
        {
            InitializeComponent();
        }

        private void SSRC_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\CodenameStratus");

        }

        private void tdxtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //This makes the "add media checkbox" enable the "browse for media" option
        private void checkBoxMedia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMedia.Checked == true)
            {
                browseBtnMedia.Enabled = true;
            }
            if (checkBoxMedia.Checked == false)
            {
                browseBtnMedia.Enabled = false;
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filetoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                browseBtnRadar.Enabled = true;
            }
        }

        private void checkBoxRadar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {

            }



            if (checkBox3.Checked == false)
            {
                browseBtnRadar.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textMediaDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                browseBtnRadar.Enabled = true;
            }



            if (checkBox3.Checked == false)
            {
                browseBtnRadar.Enabled = false;
            }
        }

        private void instructionTxt_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            settingsWindow sw = new settingsWindow();
            sw.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow aw = new aboutWindow();
            aw.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void browseBtnMedia_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox7.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog3.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox6.Text = folderBrowserDialog3.SelectedPath;
            }
        }

        private void browseBtnRadar_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox8.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog4.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox6.Text = folderBrowserDialog4.SelectedPath;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string[] lines = { "Report Generated by Codename Stratus", "====================================", "Event Submitted By: " + richTextBox2.Text, "Date: " + richTextBox3.Text, "Event Title: " + richTextBox4.Text, " ", "Description:", " ", richTextBox5.Text };
            System.IO.File.WriteAllLines(@"C:\CodenameStratus\test.txt", lines);
            //System.IO.Directory.Move(@richTextBox7.Text, @"C:\CodenameStratus\Media");
            DirectoryInfo dir = new DirectoryInfo(@richTextBox7.Text);
            if (!Directory.Exists(@"C:\CodenameStratus\Media"))
            {
                Directory.CreateDirectory(@"C:\CodenameStratus\Media");
            }
            // Get the files in the directory and copy them to the new location.


            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(@"C:\CodenameStratus\Media", file.Name);
                file.CopyTo(temppath, false);
            }
            DirectoryInfo dire = new DirectoryInfo(@richTextBox8.Text);
            if (!Directory.Exists(@"C:\CodenameStratus\NEXRAD Data"))
            {
                Directory.CreateDirectory(@"C:\CodenameStratus\NEXRAD Data");
            }
            // Get the files in the directory and copy them to the new location.
            FileInfo[] filez = dire.GetFiles();
            foreach (FileInfo file in filez)
            {
                string tempath = Path.Combine(@"C:\CodenameStratus\NEXRAD Data", file.Name);
                file.CopyTo(tempath, false);
            }
            //String[] filenames = { "ReadMe.txt", "c:\\data\\collection.csv", "c:\\reports\\AnnualSummary.pdf" };
            //using (ZipFile zip = new ZipFile())
            {
                //zip.AddFiles(filenames);
                //zip.Save("Archive.zip");
            }
        }
        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


