using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class settingsWindow : Form
    {
        public settingsWindow()
        {
            InitializeComponent();
        }

        private void settingsWindow_Load(object sender, EventArgs e)
        {
            textBoxArchName.Text = Properties.Settings.Default.ArchiveName;
            textBoxUsername.Text = Properties.Settings.Default.Username;
            textBoxPsswd.Text = Properties.Settings.Default.Password;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ArchiveName = textBoxArchName.Text;
            Properties.Settings.Default.Username = textBoxUsername.Text;
            Properties.Settings.Default.Password = textBoxPsswd.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void textBoxArchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsermane_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPsswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loading ld = new Loading();
            ld.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TimeZone = comboBoxTimeZone.Text;
            Properties.Settings.Default.Save();
            string title = Properties.Settings.Default.TimeZone.ToString();
            var first3Chars = title.Length <= 3 ? title : title.Substring(0, 3);
            textBoxTZSelected.Text = first3Chars;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
