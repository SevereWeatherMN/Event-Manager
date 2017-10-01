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
using WindowsFormsApplication1.Properties;
using System.Net;
using System.Web;
using System.Device.Location;


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
            nameTextBox.Text = Properties.Settings.Default.NameFN;
            richTextBoxExpt.Text = Properties.Settings.Default.LocalExportFN;
            richTextBoxNetwk.Text = Properties.Settings.Default.NetwkExportFN;
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
            settingsWindow sw = new settingsWindow();
            sw.Show();
        }

        private void browseBtnMedia_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog3.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBoxExpt.Text = folderBrowserDialog3.SelectedPath;
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
                richTextBoxNetwk.Text = folderBrowserDialog4.SelectedPath;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //saves entries into settings
            Properties.Settings.Default.NameFN = nameTextBox.Text;
            Properties.Settings.Default.LocalExportFN = richTextBoxExpt.Text;
            Properties.Settings.Default.NetwkExportFN = richTextBoxNetwk.Text;
            Properties.Settings.Default.Save();

            Loading ld = new Loading();
            ld.Show();

            string[] linees = { "Field Note Generated by Weather Event Manager Beta, Build 0.4.3", "===============================================================", "  ", "Event Submitted By: " + nameTextBox.Text, "Date: " + Properties.Settings.Default.Year.ToString() + "-" + Properties.Settings.Default.Month.ToString() + "-" + Properties.Settings.Default.Day.ToString(), "Time: " + richTextBoxTime.Text + " " + Properties.Settings.Default.TimeZone.ToString(), "Event Category: " + eventCategory.Text, "Location: " + Properties.Settings.Default.Location.ToString(), " ", "Description:", richTextBox5.Text };
            System.IO.File.WriteAllLines(@"C:/tmp" + "/" + Properties.Settings.Default.FileName.ToString() + "-" + richTextBoxFileName.Text + ".txt", linees);

            string[] lines = { "Field Note Generated by Weather Event Manager Beta, Build 0.4.3", "===============================================================", "  ", "Event Submitted By: " + nameTextBox.Text, "Date: " + Properties.Settings.Default.Year.ToString() + "-" + Properties.Settings.Default.Month.ToString() + "-" + Properties.Settings.Default.Day.ToString(), "Time: " + richTextBoxTime.Text + " " + Properties.Settings.Default.TimeZone.ToString(), "Event Category: " + eventCategory.Text, "Location: " + Properties.Settings.Default.Location.ToString(), " ", "Description:", richTextBox5.Text };
            System.IO.File.WriteAllLines(@richTextBoxExpt.Text + "/" + Properties.Settings.Default.FileName.ToString() + "-" + richTextBoxFileName.Text + ".txt", lines);
            using (WebClient client = new WebClient())
                try
                {
                    //Prevent overwriting files on the server-not working yet

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(@richTextBoxNetwk.Text + "/" + Properties.Settings.Default.FileName.ToString() + "-" + richTextBoxFileName.Text + ".txt");
                    request.Credentials = new NetworkCredential(@Properties.Settings.Default.Username.ToString(), @Properties.Settings.Default.Password.ToString());
                    request.Method = WebRequestMethods.Ftp.GetDateTimestamp;

                    try
                    {
                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    }
                    catch (WebException ex)
                    {
                        FtpWebResponse response = (FtpWebResponse)ex.Response;
                        if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                        {
                            client.Credentials = new NetworkCredential(@Properties.Settings.Default.Username.ToString(), @Properties.Settings.Default.Password.ToString());
                            client.UploadFile(@richTextBoxNetwk.Text + "/" + Properties.Settings.Default.FileName.ToString() + "-" + richTextBoxFileName.Text + ".txt", "STOR", @"C:/tmp/" + Properties.Settings.Default.FileName.ToString() + "-" + richTextBoxFileName.Text + ".txt");
                        {
                            MessageBox.Show("Operation Completed Successfully!", "Field Note Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("NETWORK ERROR: Unable to contact FTP server. Either the server or the directory is unavailable.", "Field Note Generator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            ld.Close();

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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            welcomeWindow ww = new welcomeWindow();
            ww.Show();
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpWindow hw = new helpWindow();
            hw.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            welcomeWindow ww = new welcomeWindow();
            ww.Show();
            this.Close();
        }

        private void toolTip5_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip4_Popup(object sender, PopupEventArgs e)
        {

        }

        private void richTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBoxLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLocation.Checked == true)
            {
            //Adds GeoLocation to text box
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            //Do not suppress prompt, and wait 1000 milliseconds to start.
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = watcher.Position.Location;

            if (coord.IsUnknown != true)
            {
                String coordstring = coord.Latitude.ToString() + ", " + coord.Longitude.ToString();
                Properties.Settings.Default.Location = coordstring;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("The location service did not provide a valid latitude and longitude. Using previously detected coordinates...", "Field Note Generator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            richTextBoxLocation.Text = Properties.Settings.Default.Location;
            }
            if (checkBoxLocation.Checked == false)
            {
                richTextBoxLocation.Clear();
            }
        }

        private void checkBoxTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTime.Checked == true)
            {
                DateTime dtNow = DateTime.Now;
                richTextBoxTime.Text = dtNow.ToShortTimeString();
                Properties.Settings.Default.Time = dtNow.ToShortTimeString();
                Properties.Settings.Default.Save();
            }
            if (checkBoxTime.Checked == false)
            {
                richTextBoxTime.Clear();
            }
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked == true)
            {
                DateTime dtnow2 = DateTime.Now;
                String month = dtnow2.Month.ToString();
                comboBoxMonth.Text = month;
                String day = dtnow2.Day.ToString();
                comboBoxDay.Text = day;
                String year = dtnow2.Year.ToString();
                comboBoxYear.Text = year;
                Properties.Settings.Default.Month = comboBoxMonth.Text;
                Properties.Settings.Default.Day = comboBoxDay.Text;
                Properties.Settings.Default.Year = comboBoxYear.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}


