using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUnipiGuide
{
    public partial class KathightesSelectOptionPlPage : Form
    {
        private bool needToExitApp = true;

        public KathightesSelectOptionPlPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KathigitesPlPage secondForm = new KathigitesPlPage();
            secondForm.btnLoadAnaplhrwtes.Visible = true;
            secondForm.btnEpikouroi.Visible = true;
            secondForm.btnKathigites.Visible = true;
            secondForm.btnOmotimoi.Visible = false;
            secondForm.lbMelhDep.Text = "ΜΕΛΗ ΔΕΠ";

            secondForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KathigitesPlPage secondForm = new KathigitesPlPage();
            secondForm.btnLoadAnaplhrwtes.Visible = false;
            secondForm.btnEpikouroi.Visible = false;
            secondForm.btnKathigites.Visible = false;
            secondForm.btnOmotimoi.Visible = true;
            secondForm.lbMelhDep.Text = "ΟΜΟΤΙΜΟΙ ΚΑΘΗΓΗΤΕΣ";
            secondForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς η οποία δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";

            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlMenuPage form = new PlMenuPage();
            form.Show();
            needToExitApp = false;
            Close();
        }

        private void KathightesSelectOptionPlPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                Application.Exit();
            }
        }
    }
}
