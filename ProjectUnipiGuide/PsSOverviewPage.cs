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
    public partial class PsSOverviewPage : Form
    {
        public PsSOverviewPage()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private string[] historyTexts = new string[]
        {
            "Το Τμήμα Ψηφιακών Συστημάτων του Πανεπιστημίου Πειραιώς ιδρύθηκε το 1999 και καλύπτει δύο σημαντικούς κλάδους της Ψηφιακής Οικονομίας και της Κοινωνίας της Γνώσης:\r\n\r\n1. τον κλάδο των Δικτυοκεντρικών Συστημάτων και Υπηρεσιών\r\n2. τον κλάδο των Τηλεπικοινωνιακών Συστημάτων και Δικτύων\r\n\r\nΗ μετάβαση στην Κοινωνία της Πληροφορίας και της Γνώσης απαιτεί την ανάδειξη εξειδικευμένων επιστημόνων ικανών να συμβάλλουν στην ανάπτυξη, υλοποίηση και διαχείριση συστημάτων σύγχρονης ψηφιακής τεχνολογίας.",
            "Στη βάση αυτή έχει σχεδιαστεί το Προπτυχιακό Πρόγραμμα Σπουδών του Τμήματος, σύμφωνα με το οποίο λειτουργούν οι παρακάτω κατευθύνσεις σπουδών:\r\n\r\n1. Κατεύθυνση «Τηλεπικοινωνίες & Δίκτυα» (Τ&Δ)\r\n2. Κατεύθυνση «Συστήματα Λογισμικού & Δεδομένων» (ΣΛΔ)\r\n3. Κατεύθυνση «Υπολογιστικές Υποδομές & Υπηρεσίες» (ΥΥΥ)\r\n4. Οριζόντια Κατεύθυνση «Ασφάλεια» (ΑΣΦ)",
            "Το Τμήμα Ψηφιακών Συστημάτων προσφέρει τετραετές Πρόγραμμα Προπτυχιακών Σπουδών το οποίο αντιστοιχεί σε 240 πιστωτικές μονάδες του Ευρωπαϊκού Συστήματος Μεταφοράς και Συσσώρευσης Πιστωτικών Μονάδων (ECTS) και απονέμει, με την επιτυχή ολοκλήρωσή του, Πτυχίο στα \"Ψηφιακά Συστήματα\".\r\n\r\nΕπιπλέον, το Τμήμα Ψηφιακών Συστημάτων προσφέρει πέντε Προγράμματα Μεταπτυχιακών Σπουδών (Π.Μ.Σ.):\r\n\r\n1.Προγράμματα Μεταπτυχιακών Σπουδών (Π.Μ.Σ.)\r\n2. Οι Διδακτορικές Σπουδές του Τμήματος οδηγούν στην απόκτηση Διδακτορικού Διπλώματος."
        };
        private int currentIndex = 0;
        private int currentCharacterIndex = 0;
        private string currentText = "";
        private int pauseCounter = 0;
        private int pauseDuration = 20;

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
            //PlMenuPage form = new PlMenuPage();
            //form.Show();
            this.Hide();
        }
    }
}
