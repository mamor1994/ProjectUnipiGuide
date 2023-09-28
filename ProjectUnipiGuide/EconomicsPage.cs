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
        private bool needToExitApp = true;

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schools form = new Schools();
            form.Show();
            needToExitApp = false;
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς ο οποίος δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";

            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EconomicsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                Application.Exit();
            }
        }
    }    
}
