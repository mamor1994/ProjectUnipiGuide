﻿using System;
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
    public partial class EntrancePage : Form
    {
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
            PhotosPage newForm = new PhotosPage();
            newForm.Show();
            this.Hide();
        }

        private void EggegrammenosXrhsths_Click(object sender, EventArgs e)
        {
            LoginPage newForm = new LoginPage();
            newForm.Show();
            this.Hide();
        }

    }
}