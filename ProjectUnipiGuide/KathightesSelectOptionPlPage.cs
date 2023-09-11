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
    public partial class KathightesSelectOptionPlPage : Form
    {
        private readonly string userSelectedOption;

        public KathightesSelectOptionPlPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KathigitesPlPage secondForm = new KathigitesPlPage();
            secondForm.btnLoadAnaplhrwtes.Visible = true;
            secondForm.btnEpikouroi.Visible = true;
            secondForm.btnKathigites.Visible = true;
            secondForm.btnOmotimoi.Visible = false;
            secondForm.lbMelhDep.Text = "ΜΕΛΗ ΔΕΠ";
            //secondForm.btnLoadAnaplhrwtes.Hide();
            //secondForm.btnEpikouroi.Hide();
            //secondForm.btnKathigites.Hide();
            //secondForm.btnOmotimoi.Visible = true;
            //secondForm.lbMelhDep.Text = "ΟΜΟΤΙΜΟΙ ΚΑΘΗΓΗΤΕΣ";
            secondForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KathigitesPlPage secondForm = new KathigitesPlPage();
            secondForm.btnLoadAnaplhrwtes.Visible = false;
            secondForm.btnEpikouroi.Visible = false;
            secondForm.btnKathigites.Visible = false;
            secondForm.btnOmotimoi.Visible = true;
            secondForm.lbMelhDep.Text = "ΟΜΟΤΙΜΟΙ ΚΑΘΗΓΗΤΕΣ";
            secondForm.Show();
            this.Hide();
        }
    }
}
