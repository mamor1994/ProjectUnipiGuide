using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectUnipiGuide
{
    public partial class EconomicsPage : Form
    {
        public EconomicsPage()
        {
            InitializeComponent();
        }

        private void EconomicsPage_Load(object sender, EventArgs e)
        {
            infotext.GotFocus += infotext_GotFocus;
        }

        private void infotext_GotFocus(object sender, EventArgs e)
        {
            ((System.Windows.Forms.TextBox)sender).Parent.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schools form = new Schools();
            form.Show();
            this.Hide();
        }
    }
}
