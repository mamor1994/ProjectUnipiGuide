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
    public partial class ServicesPage : Form
    {
        public ServicesPage()
        {
            InitializeComponent();
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
            MainPage form = new MainPage();
            form.Show();
            this.Hide();
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }

        private void sitisitoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Το φοιτητικό εστιατόριο λειτουργεί στο κτίριο της οδού Τσαμαδού 78, στο οποίο σιτίζονται οι δικαιούμενοι δωρεάν σίτιση φοιτητές.\r\n\r\nΚαθορισμός όρων, προϋποθέσεων και διαδικασίας για την παροχή δωρεάν σίτισης στους φοιτητές των Α.Ε.Ι. (ΦΕΚ 1965-18/06/2012-ΤΕΥΧΟΣ Β΄)\r\n\r\nΔωρεάν σίτισης δικαιούνται οι ενεργοί φοιτητές του Πανεπιστημίου Πειραιώς, προπτυχιακοί, μεταπτυχιακοί, υποψήφιοι διδάκτορες, εφόσον δεν είναι ήδη κάτοχοι πτυχίου, μεταπτυχιακού ή διδακτορικού τίτλου αντίστοιχα, με βάση κυρίως την οικογενειακή ή ατομική οικονομική τους κατάσταση και την εντοπιότητα τους.\r\n\r\nΕνεργοί φοιτητές είναι οι :\r\n\r\nΠροπτυχιακοί φοιτητές των οποίων η διάρκεια φοίτησης δεν έχει υπερβεί τη διάρκεια των εξαμήνων που απαιτούνται για τη λήψη του τίτλου σπουδών σύμφωνα με το ενδεικτικό πρόγραμμα σπουδών, προσαυξανόμενη κατά τέσσερα εξάμηνα.\r\nΜεταπτυχιακοί φοιτητές των οποίων η διάρκεια φοίτησης δεν έχει υπερβεί τη διάρκεια του ενδεικτικού προγράμματος σπουδών.\r\nΥποψήφιοι διδάκτορες οι οποίοι διανύουν τα τέσσερα πρώτα έτη στο αντίστοιχο πρόγραμμα.\r\nΟι προϋποθέσεις για δωρεάν σίτιση, τα απαραίτητα δικαιολογητικά καθώς και οι προθεσμίες υποβολής αίτησης για σίτιση ανακοινώνονται από το Τμήμα Φοιτητικής Μέριμνας.";
        }

        private void ygperithalpsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Βάσει του άρθρου 31 του Ν.4452/2017, οι προπτυχιακοί και μεταπτυχιακοί φοιτητές και οι υποψήφιοι διδάκτορες, που δεν έχουν άλλη ιατροφαρμακευτική και νοσοκομειακή περίθαλψη, δικαιούνται πλήρη ιατροφαρμακευτική και νοσοκομειακή περίθαλψη στο Εθνικό Σύστημα Υγείας (Ε.Σ.Υ.), με κάλυψη των σχετικών δαπανών από τον Ε.Ο.Π.Υ.Υ., κατ’ ανάλογη εφαρμογή του άρθρου 33 του Ν. 4368/2016.\r\n\r\nΤηλ.: 2104142065, 2104142089, 2104142088\r\n\r\nΙατροφαρμακευτική και νοσοκομειακή περίθαλψη ανασφάλιστων φοιτητών - Εγκύκλιος 171598/Ζ1-12/10/2017";
        }

        private void ServicesPage_Load(object sender, EventArgs e)
        {
            textBox1.GotFocus += textBox1_GotFocus;
        }

        
        
    }
}
