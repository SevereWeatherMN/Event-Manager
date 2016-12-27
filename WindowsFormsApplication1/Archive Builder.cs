using System;
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
using System.Text;

namespace WindowsFormsApplication1
{
    public partial class Archive_Builder : Form
    {
        public Archive_Builder()
        {
            InitializeComponent();
        }

        private void Archive_Builder_Load (object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("C:/tmp");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
            System.IO.Directory.CreateDirectory(@"C:\tmp");
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
            DirectoryInfo dir = new DirectoryInfo(@richTextBox7Media.Text);
            if (!Directory.Exists(@"C:\tmp\Media"))
            {
                Directory.CreateDirectory(@"C:\tmp\Media");
            }
            // Get the files in the directory and copy them to the new location.

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(@"C:\tmp\Media", file.Name);
                file.CopyTo(temppath, false);
            }
            DirectoryInfo dire = new DirectoryInfo(@richTextBoxNexrad.Text);
            if (!Directory.Exists(@"C:\tmp\NEXRAD Data"))
            {
                Directory.CreateDirectory(@"C:\tmp\NEXRAD Data");
            }
            // Get the files in the directory and copy them to the new location.
            FileInfo[] filez = dire.GetFiles();
            foreach (FileInfo file in filez)
            {
                string tempath = Path.Combine(@"C:\tmp\NEXRAD Data", file.Name);
                file.CopyTo(tempath, false);
            }
            DirectoryInfo direc = new DirectoryInfo(@richTextBoxStmRpt.Text);
            if (!Directory.Exists(@"C:\tmp\Storm Reports"))
            {
                Directory.CreateDirectory(@"C:\tmp\Storm Reports");
            }
            // Get the files in the directory and copy them to the new location.

            FileInfo[] filess = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(@"C:\tmp\Storm Reports", file.Name);
                file.CopyTo(temppath, false);
            }
            // Declare path to zip and path to zip to.
            string zipDir = @"c:/tmp/";
            string zipPath = @richTextBoxExpt.Text + "/" + string.Format("{0:yyyy-MM-dd_hh:mm:ss:tt}", DateTime.Now) + Properties.Settings.Default.ArchiveName.ToString() + ".zip";
            //Perform zip.
            ZipFile.CreateFromDirectory(zipDir, zipPath, CompressionLevel.Fastest, false);


            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www.contoso.com/test.htm");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // Credentials are taken from settings and are added in.
            request.Credentials = new NetworkCredential(Properties.Settings.Default.Username.ToString(), Properties.Settings.Default.Password.ToString());

            // Copy the contents of the file to the request stream.
            StreamReader sourceStream = new StreamReader("testfile.txt");
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();
            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);

            response.Close();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void somethingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            welcomeWindow ww = new welcomeWindow();
            ww.Show();
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
