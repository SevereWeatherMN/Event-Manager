﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class loginWindow : Form
    {
        public loginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            UserWindow uw = new UserWindow();
            uw.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
