using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class aboutWindow : Form
    {
        public aboutWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            Process.Start("http://www.google.com");
        }

        private void RichTextBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.google.com");
        }
    }
}
