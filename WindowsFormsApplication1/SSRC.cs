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
            System.IO.Directory.CreateDirectory(@"C:\tmp");

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

        private void checkBoxRadar_CheckedChanged(object sender, EventArgs e)
        {

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
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog4.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox9.Text = folderBrowserDialog4.SelectedPath;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //create text file in tmp and write the input to it
            string[] lines = { "Report Generated by Weather Event Manager Beta, Build 0.0.5", "===========================================================", "  ",  "Event Submitted By: " + nameTextBox.Text, "Date: " + richTextBox3.Text, "Event Title: " + richTextBox4.Text, " ", "Description:", " ", richTextBox5.Text };
            System.IO.File.WriteAllLines(@richTextBox6.Text + "/" + richTextBox1.Text + ".txt", lines);
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

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
    
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
     

        }
    }
}


