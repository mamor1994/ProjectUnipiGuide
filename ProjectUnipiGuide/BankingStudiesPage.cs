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
    public partial class BankingStudiesPage : Form
    {
        public BankingStudiesPage()
        {
            InitializeComponent();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schools schools = new Schools();
            schools.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς ο οποίος δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";

            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BankingStudiesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
