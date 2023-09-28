using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUnipiGuide
{
    public partial class Schools : Form
    {
        private bool needToExitApp = true;

        public Schools()
        {
            InitializeComponent();
            this.Activated += this.OnActivated; 
        }

        private void ComputerScience_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.ManagementStudies.Visible = true;
            this.MaritimeStudies.Visible = true;
            this.FinanceStudies.Visible = true;
            this.ComputerScience.Visible = false;
            this.Economics.Visible = false;
            this.Management.Visible = false;
            this.InternationalStudies.Visible = false;
            this.TourismStudies.Visible = false;
            this.Maritime.Visible = false;
            this.IndustrialManagement.Visible = false;
            this.Banking.Visible = false;
            this.Statistics.Visible = false;
            this.Informatics.Visible = true;
            this.DigitalSystems.Visible = true;
            this.ResumeLayout(false);
            this.PerformLayout();
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
            needToExitApp = false;
            Close();
            if (UserState.IsGuest == true)
            {
                form.btnCalendar.Visible = false;
            }
            else
            {
                form.btnCalendar.Visible = true;
            }
        }

        private void Schools_Load(object sender, EventArgs e)
        {
           // Debug.WriteLine("Loaded");
        }

        private void ManagementStudies_Click(object sender, EventArgs e)
        {
            this.ManagementStudies.Visible = false;
            this.MaritimeStudies.Visible = true;
            this.FinanceStudies.Visible = true;
            this.ComputerScience.Visible = true;
            this.Economics.Visible = true;
            this.Management.Visible = true;
            this.InternationalStudies.Visible = true;
            this.TourismStudies.Visible = true;
            this.Maritime.Visible = false;
            this.IndustrialManagement.Visible = false;
            this.Banking.Visible = false;
            this.Statistics.Visible = false;
            this.Informatics.Visible = false;
            this.DigitalSystems.Visible = false;


        }

        private void Maritime_CheckedChanged(object sender, EventArgs e)
        {
            MaritimePage form = new MaritimePage();
            form.Show();
            this.Hide();
        }

        private void MaritimeStudies_Click(object sender, EventArgs e)
        {
            this.ManagementStudies.Visible = true;
            this.MaritimeStudies.Visible = false;
            this.FinanceStudies.Visible = true;
            this.ComputerScience.Visible = true;
            this.Economics.Visible = false;
            this.Management.Visible = false;
            this.InternationalStudies.Visible = false;
            this.TourismStudies.Visible = false;
            this.Maritime.Visible = true;
            this.IndustrialManagement.Visible = true;
            this.Banking.Visible = false;
            this.Statistics.Visible = false;
            this.Informatics.Visible = false;
            this.DigitalSystems.Visible = false;
        }

        private void FinanceStudies_Click(object sender, EventArgs e)
        {
            this.ManagementStudies.Visible = true;
            this.MaritimeStudies.Visible = true;
            this.FinanceStudies.Visible = false;
            this.ComputerScience.Visible = true;
            this.Economics.Visible = false;
            this.Management.Visible = false;
            this.InternationalStudies.Visible = false;
            this.TourismStudies.Visible = false;
            this.Maritime.Visible = false;
            this.IndustrialManagement.Visible = false;
            this.Banking.Visible = true;
            this.Statistics.Visible = true;
            this.Informatics.Visible = false;
            this.DigitalSystems.Visible = false;
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
            this.Hide();
        }

        private void IndustrialManagement_CheckedChanged(object sender, EventArgs e)
        {
            IndustrialManagementPage form = new IndustrialManagementPage();
            form.Show();
            this.Hide();
        }

        private void Banking_CheckedChanged(object sender, EventArgs e)
        {
            BankingStudiesPage form = new BankingStudiesPage();
            form.Show();
            this.Hide();
        }

        private void Statistics_CheckedChanged(object sender, EventArgs e)
        {
            StatisticsSciencePage form = new StatisticsSciencePage();
            form.Show();
            this.Hide();
        }

        private void Economics_CheckedChanged(object sender, EventArgs e)
        {
            EconomicsPage form = new EconomicsPage();
            form.Show();
            this.Hide();
        }

        private void OnActivated(object sender, EventArgs e)
        {
            this.ComputerScience.Visible = true;
            this.Informatics.Visible = false;
            this.DigitalSystems.Visible = false;
            this.DigitalSystems.Checked = false;
        }

        private void Schools_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                Application.Exit();
            }
        }

        private void DigitalSystems_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radiobutton = sender as RadioButton;
            if (radiobutton.Checked == true)
            {

                PsSOverviewPage form = new PsSOverviewPage();
                if (form != null)
                {
                    if (!DesignMode)
                    {
                        form.Tag = this;
                        form.Show(this);
                        this.Hide();
                    }
                }
            }
        }
    }
}
