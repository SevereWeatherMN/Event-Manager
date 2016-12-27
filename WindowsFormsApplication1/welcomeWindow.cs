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

namespace WindowsFormsApplication1
{
    public partial class welcomeWindow : Form
    {
        public welcomeWindow()
        {
            InitializeComponent();
        }

        private void welcomeMsg_Click(object sender, EventArgs e)
        {

        }

        private void welcomeWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Archive_Builder aw = new Archive_Builder();
            aw.Show();
         
        }

    



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SSRC aw = new SSRC();
            aw.Show();
        }

        private void instructionTxt_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow aw = new aboutWindow();
            aw.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsWindow sw = new settingsWindow();
            sw.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpWindow hw = new helpWindow();
            hw.Show();
        }
    }
}
