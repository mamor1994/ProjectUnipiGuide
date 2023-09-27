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
    public partial class PlMenuPage : Form
    {
        public PlMenuPage()
        {
            InitializeComponent();
        }

        private void btnPlOverviewPage_Click(object sender, EventArgs e)
        {
            PlOverviewPage newForm = new PlOverviewPage();
            newForm.Show();
            this.Hide();
        }

        private void btnPlProfessorsPage_Click(object sender, EventArgs e)
        {
            KathightesSelectOptionPlPage newForm = new KathightesSelectOptionPlPage();
            newForm.Show();
            this.Hide();
        }

        private void btnPlPage_Click(object sender, EventArgs e)
        {
            WebPlPage newForm = new WebPlPage();
            newForm.Show();
            this.Hide();
        }

        private void btnPlVideoPage_Click(object sender, EventArgs e)
        {
            VideoPlPage newForm = new VideoPlPage();
            newForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς ο οποίος δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";

            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void PlMenuPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
