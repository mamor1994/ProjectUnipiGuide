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
    public partial class ByeByePage : Form
    {
        public ByeByePage()
        {
            InitializeComponent();
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
            EndPage form = new EndPage();
            form.ShowDialog();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς η οποία δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}