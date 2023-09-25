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
    public partial class ByeByePage : Form
    {
        public ByeByePage()
        {
            InitializeComponent();
            timer1.Interval = 7000;
            timer1.Start();
        }

        private void ByeByePage_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.gif; 
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserState.IsGuest = true;
            MainPage form = new MainPage();
            form.btnCalendar.Visible = false;
            form.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς η οποία δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            EndPage form = new EndPage();
            form.Show();
        }
    }
}
