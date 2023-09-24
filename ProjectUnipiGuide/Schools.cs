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
    public partial class Schools : Form
    {
        public Schools()
        {
            InitializeComponent();
        }

        private void ComputerScience_Click(object sender, EventArgs e)
        {
            ManagementStudies.Visible = true;
            MaritimeStudies.Visible = true;
            FinanceStudies.Visible = true;
            ComputerScience.Visible = false;
            Economics.Visible = false;
            Management.Visible = false;
            InternationalStudies.Visible = false;
            TourismStudies.Visible = false;
            Maritime.Visible = false;
            IndustrialManagement.Visible = false;
            Banking.Visible = false;
            Statistics.Visible = false;
            Informatics.Visible = true;
            DigitalSystems.Visible = true;
        }

        private void Informatics_CheckedChanged(object sender, EventArgs e)
        {
            PlMenuPage newform = new PlMenuPage();
            newform.Show();
            this.Hide();
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

        private void Schools_Load(object sender, EventArgs e)
        {

        }

        private void ManagementStudies_Click(object sender, EventArgs e)
        {
            ManagementStudies.Visible = false;
            MaritimeStudies.Visible = true;
            FinanceStudies.Visible = true;
            ComputerScience.Visible = true;
            Economics.Visible = true;
            Management.Visible = true;
            InternationalStudies.Visible = true;
            TourismStudies.Visible = true;
            Maritime.Visible = false;
            IndustrialManagement.Visible = false;
            Banking.Visible = false;
            Statistics.Visible = false;
            Informatics.Visible = false;
            DigitalSystems.Visible = false;


        }

        private void Maritime_CheckedChanged(object sender, EventArgs e)
        {
            MaritimePage form = new MaritimePage();
            form.Show();
            this.Close();
        }

        private void MaritimeStudies_Click(object sender, EventArgs e)
        {
            ManagementStudies.Visible = true;
            MaritimeStudies.Visible = false;
            FinanceStudies.Visible = true;
            ComputerScience.Visible = true;
            Economics.Visible = false;
            Management.Visible = false;
            InternationalStudies.Visible = false;
            TourismStudies.Visible = false;
            Maritime.Visible = true;
            IndustrialManagement.Visible = true;
            Banking.Visible = false;
            Statistics.Visible = false;
            Informatics.Visible = false;
            DigitalSystems.Visible = false;
        }

        private void FinanceStudies_Click(object sender, EventArgs e)
        {
            ManagementStudies.Visible = true;
            MaritimeStudies.Visible = true;
            FinanceStudies.Visible = false;
            ComputerScience.Visible = true;
            Economics.Visible = false;
            Management.Visible = false;
            InternationalStudies.Visible = false;
            TourismStudies.Visible = false;
            Maritime.Visible = false;
            IndustrialManagement.Visible = false;
            Banking.Visible = true;
            Statistics.Visible = true;
            Informatics.Visible = false;
            DigitalSystems.Visible = false;
        }

        private void Management_CheckedChanged(object sender, EventArgs e)
        {
            BusinessAdministrationPage form = new BusinessAdministrationPage();
            form.Show();
            this.Hide();
        }

        private void InternationalStudies_CheckedChanged(object sender, EventArgs e)
        {
            InternationalStudiesPage form = new InternationalStudiesPage();
            form.Show();
            this.Hide();
        }

        private void TourismStudies_CheckedChanged(object sender, EventArgs e)
        {
            TourismStudiesPage form = new TourismStudiesPage();
            form.Show();
            this.Close();
        }

        private void IndustrialManagement_CheckedChanged(object sender, EventArgs e)
        {
            IndustrialManagementPage form = new IndustrialManagementPage();
            form.Show();
            this.Close();
        }

        private void Banking_CheckedChanged(object sender, EventArgs e)
        {
            BankingStudiesPage form = new BankingStudiesPage();
            form.Show();
            this.Close();
        }

        private void Statistics_CheckedChanged(object sender, EventArgs e)
        {
            StatisticsSciencePage form = new StatisticsSciencePage();
            form.Show();
            this.Close();
        }

        private void Economics_CheckedChanged(object sender, EventArgs e)
        {
            EconomicsPage form = new EconomicsPage();
            form.Show();
            this.Close();
        }
    }
}
