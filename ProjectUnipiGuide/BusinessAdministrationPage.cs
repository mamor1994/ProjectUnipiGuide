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
    public partial class BusinessAdministrationPage : Form
    {
        public BusinessAdministrationPage()
        {
            InitializeComponent();

        }
        private void SetMarginsForLines(int startLine, int endLine, int rightMargin)
        {
            int start = richTextBox1.GetFirstCharIndexFromLine(startLine);
            int end = richTextBox1.GetFirstCharIndexFromLine(endLine + 1); // +1 γιατί θέλουμε το τέλος της τελευταίας γραμμής

            richTextBox1.Select(start, end - start);
            richTextBox1.SelectionRightIndent = rightMargin;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void BusinessAdministrationPage_Load(object sender, EventArgs e)
        {
            richTextBox1.GotFocus += richTextBox1_GotFocus;
            SetMarginsForLines(1, 6, 200); 
        }
        private void richTextBox1_GotFocus(object sender, EventArgs e)
        {
            ((RichTextBox)sender).Parent.Focus();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schools schools = new Schools();
            schools.Show();
            this.Hide();
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
    }   
}
