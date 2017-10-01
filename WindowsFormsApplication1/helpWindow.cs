using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WindowsFormsApplication1
{
    public partial class helpWindow : Form
    {
        public helpWindow()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow aw = new aboutWindow();
            aw.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void helpWindow_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Font font1 = new Font("Arial", 12, GraphicsUnit.Point))
            {
                Rectangle rect1 = new Rectangle(30, 10, 800, 1100);

                // Create a StringFormat object with the each line of text, and the block of text centered on the page.
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                // Draw the text and the surrounding rectangle.
                e.Graphics.DrawString(richTextBoxHelp.Text, font1, Brushes.Black, rect1, stringFormat);
                e.Graphics.DrawRectangle(Pens.White, rect1);
            }
        }
        private void richTextBoxHelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}