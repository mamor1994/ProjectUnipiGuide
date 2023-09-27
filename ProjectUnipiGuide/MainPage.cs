using ProjectUnipiGuide.DAL;
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
    public partial class MainPage : Form
    {

        public MainPage()
        {
            InitializeComponent(); 
        }

        private void GenInfo_Click(object sender, EventArgs e)
        {
            GenInfoPage newform = new GenInfoPage();
            newform.Show();
            this.Hide();
        }

        private void Schools_Click(object sender, EventArgs e)
        {
            Schools newform = new Schools();
            newform.Show();
            this.Hide();
        }

        private void Services_Click(object sender, EventArgs e)
        {
            ServicesPage newform = new ServicesPage();
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
            EntrancePage form = new EntrancePage();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ByeByePage form = new ByeByePage();
            form.Show();
            this.Hide();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            CalendarPage form = new CalendarPage();
            form.Show();
            this.Hide();
        }

        private void btnPhotos_Click(object sender, EventArgs e)
        {
            PhotosPage form = new PhotosPage();
            form.Show();
            this.Hide();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            UserReviewPage form = new UserReviewPage();
            form.Show();
            this.Hide();

            if (UserState.IsGuest)
            {
                form.btnAdd.Hide();
                form.btnRefresh.Hide();
            }
            else
            {
                form.btnAdd.Show();
                form.btnRefresh.Show();
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
