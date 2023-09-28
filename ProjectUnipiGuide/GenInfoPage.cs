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
    public partial class GenInfoPage : Form
    {
        private bool needToExitApp = true;

        public GenInfoPage()
        {
            InitializeComponent();
        }

        private void History_Click(object sender, EventArgs e)
        {
            UniHistoryPage newform = new UniHistoryPage();
            newform.Show();
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
            MainPage form = new MainPage();
            form.Show();
            needToExitApp = false;
            Close();
            if (UserState.IsGuest == true)
            {
                form.btnCalendar.Visible = false;
            }
            else 
            {
                form.btnCalendar.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LocationPage form = new LocationPage();
            form.Show();
            this.Hide();
        }

        private void GenInfoPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                Application.Exit();
            }
        }
    }
}
