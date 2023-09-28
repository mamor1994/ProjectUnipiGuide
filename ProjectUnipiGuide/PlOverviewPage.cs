using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUnipiGuide
{
    public partial class PlOverviewPage : Form
    {
        private bool needToExitApp = true;


        private string[] historyTexts = new string[]
        {
            "Το Τμήμα Πληροφορικής του Πανεπιστημίου Πειραιώς ιδρύθηκε με ΦΕΚ του 1991 και λειτουργεί από το 1992. Είναι ένα από τα αρχαιότερα Τμήματα Πληροφορικής στην Ελλάδα.\r\n\r\nΟι βασικοί άξονες του Τμήματος είναι η εκπαίδευση και η έρευνα. Η εκπαίδευση, παρέχεται σε 3 επίπεδα. Στο πρώτο επίπεδο παρέχονται οι προπτυχιακές σπουδές με την εισαγωγή φοιτητών από τις Πανελλαδικές εξετάσεις της χώρας που οδηγούν στην απόκτηση Πτυχίου Πληροφορικής. Στο δεύτερο επίπεδο παρέχονται μεταπτυχιακές σπουδές που οδηγούν στην απόκτηση Μεταπτυχιακού Διπλώματος Ειδίκευσης και στο τρίτο επίπεδο παρέχονται διδακτορικές σπουδές που οδηγούν στην απόκτηση διδακτορικού διπλώματος.",
            "Το ΠΡΟΓΡΑΜΜΑ ΠΡΟΠΤΥΧΙΑΚΩΝ ΣΠΟΥΔΩΝ (ΠΠΣ) παρέχει στέρεα εκπαίδευση σε όλα τα αντικείμενα της σύγχρονης επιστήμης της Πληροφορικής σύμφωνα με τις τρέχουσες εξελίξεις της Πληροφορικής παγκοσμίως. Στο 3ο έτος σπουδών δίνεται η δυνατότητα επιλογής μιας κατεύθυνσης από 3 κατευθύνσεις:\r\n\r\n1. Τεχνολογία Λογισμικού και Ευφυή Συστήματα,\r\n\r\n2. Πληροφοριακά συστήματα και Υπηρεσίες και\r\n\r\n3. Δίκτυα και Υπολογιστικά Συστήματα.",
            "Ακόμα δίνεται η δυνατότητα απόκτησης Διδακτικής Επάρκειας για να μπορούν οι απόφοιτοι του Τμήματος να διδάσκουν Πληροφορική σε επίπεδο δευτεροβάθμιας και πρωτοβάθμιας εκπαίδευσης.\r\n\r\nΤο Τμήμα Πληροφορικής του Πανεπιστημίου Πειραιώς οργανώνει και λειτουργεί 4 ΠΡΟΓΡΑΜΜΑΤΑ ΜΕΤΑΠΤΥΧΙΑΚΩΝ ΣΠΟΥΔΩΝ (ΠΜΣ):\r\n\r\n1. ΠΜΣ \"Προηγμένα Συστήματα Πληροφορικής - Ανάπτυξη Λογισμικού και Τεχνητής Νοημοσύνης\"\r\n2. ΠΜΣ \"Ψηφιακός Πολιτισμός, Έξυπνες Πόλεις, IoT και Προηγμένες Ψηφιακές Τεχνολογίες\"\r\n3. ΠΜΣ \"Κυβερνοασφάλεια και Επιστήμη Δεδομένων\"\r\n4. ΠΜΣ \"Πληροφορική\", το οποίο είναι ένα πρόγραμμα που απευθύνεται σε αποφοίτους άλλων επιστημών που επιθυμούν να εξειδικευτούν στην Πληροφορική."
        };
        private int currentIndex = 0;
        private int currentCharacterIndex = 0;
        private string currentText = "";
        private int pauseCounter = 0;
        private int pauseDuration = 20;

        public PlOverviewPage()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void UpdatePlOverviewText()
        {
            if (currentCharacterIndex < historyTexts[currentIndex].Length)
            {
                currentText += historyTexts[currentIndex][currentCharacterIndex];
                label1.Text = currentText;
                currentCharacterIndex++;
            }
            else
            {
                if (pauseCounter < pauseDuration)
                {
                    pauseCounter++;
                }
                else
                {
                    currentIndex = (currentIndex + 1) % historyTexts.Length;
                    currentCharacterIndex = 0;
                    currentText = "";
                    pauseCounter = 0;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdatePlOverviewText();
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
            PlMenuPage form = new PlMenuPage();
            form.Show();
            needToExitApp = false;
            Close();
        }

        private void PlOverviewPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                Application.Exit();
            }
        }
    }
}
