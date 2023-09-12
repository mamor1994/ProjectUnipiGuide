using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace ProjectUnipiGuide
{
    public partial class EntrancePage : Form
    {
        SoundPlayer player = new SoundPlayer("sounds/mysound.wav");

        public EntrancePage()
        {
            InitializeComponent();
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

        private void Episkepths_Click(object sender, EventArgs e)
        {
            player.Stop();
            PhotosPage newForm = new PhotosPage();
            newForm.Show();
            this.Hide();
        }

        private void EggegrammenosXrhsths_Click(object sender, EventArgs e)
        {
            player.Stop();
            LoginPage newForm = new LoginPage();
            newForm.Show();
            this.Hide();
        }

        private void EntrancePage_Load(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
