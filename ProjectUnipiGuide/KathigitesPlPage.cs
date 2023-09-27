using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUnipiGuide
{
    public partial class KathigitesPlPage : Form
    {
        public KathigitesPlPage()
        {
            InitializeComponent();
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach(ListViewItem item in listViewPeople.Items)
                        {
                            await tw.WriteLineAsync(item.SubItems[0].Text + "\t" + item.SubItems[1].Text);
                        }
                    MessageBox.Show("Your data has been successfully exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnLoadAnaplhrwtes_Click(object sender, EventArgs e)
        {
            lbKathightes.Text = "Αναπληρωτές Καθηγητές";

            listViewPeople.Items.Clear();

            ListViewItem item1 = new ListViewItem("Αλέπης Ευθύμιος");
            item1.SubItems.Add("Τμήμα Πληροφορικής");
            item1.SubItems.Add("540/ΚΕΚΤ");
            item1.SubItems.Add("+30 210 4142311");
            item1.SubItems.Add("talepis@unipi.gr");
            listViewPeople.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Βουγιουκλίδου Άννα");
            item2.SubItems.Add("Τμήμα Πληροφορικής");
            item2.SubItems.Add("4ος/ΖΕΑΣ");
            item2.SubItems.Add("+30 210 4142407");
            item2.SubItems.Add("avou@unipi.gr");
            listViewPeople.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Κοτζανικολάου Παναγιώτης");
            item3.SubItems.Add("Τμήμα Πληροφορικής");
            item3.SubItems.Add("302/ΓΛ126");
            item3.SubItems.Add("+30 210 4142123");
            item3.SubItems.Add("pkotzani@unipi.gr");
            listViewPeople.Items.Add(item3);

            ListViewItem item4 = new ListViewItem("Πατσάκης Κωνσταντίνος");
            item4.SubItems.Add("Τμήμα Πληροφορικής");
            item4.SubItems.Add("540/ΚΕΚΤ");
            item4.SubItems.Add("+30 210 4142261");
            item4.SubItems.Add("kpatsak@unipi.gr");
            listViewPeople.Items.Add(item4);

            ListViewItem item5 = new ListViewItem("Σακκόπουλος Ευάγγελος");
            item5.SubItems.Add("Τμήμα Πληροφορικής");
            item5.SubItems.Add("543/ΚΕΚΤ");
            item5.SubItems.Add("+30 210 4142312");
            item5.SubItems.Add("sakkopul@unipi.gr");
            listViewPeople.Items.Add(item5);

            ListViewItem item6 = new ListViewItem("Ψαράκης Μιχαήλ");
            item6.SubItems.Add("Τμήμα Πληροφορικής");
            item6.SubItems.Add("302/ΓΛ126");
            item6.SubItems.Add("+30 210 4142425");
            item6.SubItems.Add("mpsarak@unipi.gr");
            listViewPeople.Items.Add(item6);
        }

        private void btnEpikouroi_Click(object sender, EventArgs e)
        {
            lbKathightes.Text = "Επίκουροι Καθηγητές";
            listViewPeople.Items.Clear();

            ListViewItem item1 = new ListViewItem("Βενέτης Ιωάννης");
            item1.SubItems.Add("Τμήμα Πληροφορικής");
            item1.SubItems.Add("542/ΚΕΚΤ");
            item1.SubItems.Add("+30 210 4142262");
            item1.SubItems.Add("venetis@unipi.gr");
            listViewPeople.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Πικράκης Άγγελος");
            item2.SubItems.Add("Τμήμα Πληροφορικής");
            item2.SubItems.Add("505/ΚΕΚΤ");
            item2.SubItems.Add("+30 210 4142128");
            item2.SubItems.Add("pikrakis@unipi.gr");
            listViewPeople.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Σωτηρόπουλος Διονύσιος");
            item3.SubItems.Add("Τμήμα Πληροφορικής");
            item3.SubItems.Add("543/ΚΕΚΤ");
            item3.SubItems.Add("+30 210 4142314");
            item3.SubItems.Add("dsotirop@unipi.gr");
            listViewPeople.Items.Add(item3);

            ListViewItem item4 = new ListViewItem("Τασούλας Ιωάννης");
            item4.SubItems.Add("Τμήμα Πληροφορικής");
            item4.SubItems.Add("542/ΚΕΚΤ");
            item4.SubItems.Add("+30 210 4142313");
            item4.SubItems.Add("jtas@unipi.gr");
            listViewPeople.Items.Add(item4);
        }

        private void btnKathigites_Click(object sender, EventArgs e)
        {
            lbKathightes.Text = "Καθηγητές";

            listViewPeople.Items.Clear();

            ListViewItem item1 = new ListViewItem("Αποστόλου Δημήτριος");
            item1.SubItems.Add("Τμήμα Πληροφορικής");
            item1.SubItems.Add("303/ΓΛ126");
            item1.SubItems.Add("+30 210 4142476");
            item1.SubItems.Add("dapost@unipi.gr");
            listViewPeople.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Βέργαδος Δημήτριος");
            item2.SubItems.Add("Τμήμα Πληροφορικής");
            item2.SubItems.Add("104/ΓΛ126");
            item2.SubItems.Add("+30 210 4142479");
            item2.SubItems.Add("vergados@unipi.gr");
            listViewPeople.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Βίρβου Μαρία");
            item3.SubItems.Add("Τμήμα Πληροφορικής");
            item3.SubItems.Add("507/ΚΕΚΤ");
            item3.SubItems.Add("+30 210 4142269");
            item3.SubItems.Add("mvirvou@unipi.gr");
            listViewPeople.Items.Add(item3);

            ListViewItem item4 = new ListViewItem("Δουληγέρης Χρήστος");
            item4.SubItems.Add("Τμήμα Πληροφορικής");
            item4.SubItems.Add("302/ΚΕΚΤ");
            item4.SubItems.Add("+30 210 4142137");
            item4.SubItems.Add("cdoulig@unipi.gr");
            listViewPeople.Items.Add(item4);

            ListViewItem item5 = new ListViewItem("Θεοδωρίδης Ιωάννης");
            item5.SubItems.Add("Τμήμα Πληροφορικής");
            item5.SubItems.Add("501/ΚΕΚΤ");
            item5.SubItems.Add("+30 210 4142449");
            item5.SubItems.Add("ytheod@unipi.gr");
            listViewPeople.Items.Add(item5);

            ListViewItem item6 = new ListViewItem("Κωνσταντόπουλος Χαράλαμπος");
            item6.SubItems.Add("Τμήμα Πληροφορικής");
            item6.SubItems.Add("104/ΓΛ126");
            item6.SubItems.Add("+30 210 4142124");
            item6.SubItems.Add("konstant@unipi.gr");
            listViewPeople.Items.Add(item6);

            ListViewItem item7 = new ListViewItem("Μεταξιώτης Κωνσταντίνος");
            item7.SubItems.Add("Τμήμα Πληροφορικής");
            item7.SubItems.Add("303/ΓΛ126");
            item7.SubItems.Add("+30 210 4142578");
            item7.SubItems.Add("kmetax@unipi.gr");
            listViewPeople.Items.Add(item7);

            ListViewItem item8 = new ListViewItem("Παναγιωτόπουλος Θεμιστοκλής");
            item8.SubItems.Add("Τμήμα Πληροφορικής");
            item8.SubItems.Add("541/ΚΕΚΤ");
            item8.SubItems.Add("+30 210 4142146");
            item8.SubItems.Add("themisp@unipi.gr");
            listViewPeople.Items.Add(item8);

            ListViewItem item9 = new ListViewItem("Πολέμη Δέσποινα");
            item9.SubItems.Add("Τμήμα Πληροφορικής");
            item9.SubItems.Add("502/ΚΕΚΤ");
            item9.SubItems.Add("+30 210 4142270");
            item9.SubItems.Add("dpolemi@unipi.gr");
            listViewPeople.Items.Add(item9);

            ListViewItem item10 = new ListViewItem("Τσιχριντζής Γεώργιος");
            item10.SubItems.Add("Τμήμα Πληροφορικής");
            item10.SubItems.Add("506/ΚΕΚΤ");
            item10.SubItems.Add("+30 210 4142322");
            item10.SubItems.Add("geoatsi@unipi.gr");
            listViewPeople.Items.Add(item10);
        }

        private void btnOmotimoi_Click(object sender, EventArgs e)
        {
            lbKathightes.Text = "";
            listViewPeople.Items.Clear();

            ListViewItem item1 = new ListViewItem("Αλεξανδρής Νικόλαος");
            item1.SubItems.Add("Τμήμα Πληροφορικής");
            item1.SubItems.Add("");
            item1.SubItems.Add("");
            item1.SubItems.Add("alexandr@unipi.gr");
            listViewPeople.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Ασημακόπουλος Νικήτας");
            item2.SubItems.Add("Τμήμα Πληροφορικής");
            item2.SubItems.Add("");
            item2.SubItems.Add("");
            item2.SubItems.Add("assinik@unipi.gr");
            listViewPeople.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Γεωργιακόδης Μιχαήλ");
            item3.SubItems.Add("Τμήμα Πληροφορικής");
            item3.SubItems.Add("");
            item3.SubItems.Add("");
            item3.SubItems.Add("");
            listViewPeople.Items.Add(item3);

            ListViewItem item4 = new ListViewItem("Γεωργιακώδης Φώτιος");
            item4.SubItems.Add("Τμήμα Πληροφορικής");
            item4.SubItems.Add("");
            item4.SubItems.Add("");
            item4.SubItems.Add("mgeor@unipi.gr");
            listViewPeople.Items.Add(item4);

            ListViewItem item5 = new ListViewItem("Παναγιωτόπουλος Αντώνιος");
            item5.SubItems.Add("Τμήμα Πληροφορικής");
            item5.SubItems.Add("");
            item5.SubItems.Add("");
            item5.SubItems.Add("antonios@unipi.gr");
            listViewPeople.Items.Add(item5);

            ListViewItem item6 = new ListViewItem("Παναγιωτόπουλος Ιωάννης-Χρήστος");
            item6.SubItems.Add("Τμήμα Πληροφορικής");
            item6.SubItems.Add("");
            item6.SubItems.Add("");
            item6.SubItems.Add("jcp@unipi.gr");
            listViewPeople.Items.Add(item6);

            ListViewItem item7 = new ListViewItem("Τσικούρας Παναγιώτης-Γεώργιος");
            item7.SubItems.Add("Τμήμα Πληροφορικής");
            item7.SubItems.Add("");
            item7.SubItems.Add("");
            item7.SubItems.Add("pgtsik@unipi.gr");
            listViewPeople.Items.Add(item7);

            ListViewItem item8 = new ListViewItem("Φούντας Ευάγγελος");
            item8.SubItems.Add("Τμήμα Πληροφορικής");
            item8.SubItems.Add("");
            item8.SubItems.Add("");
            item8.SubItems.Add("efountas@unipi.gr");
            listViewPeople.Items.Add(item8);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KathightesSelectOptionPlPage form = new KathightesSelectOptionPlPage();
            form.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς η οποία δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KathigitesPlPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
