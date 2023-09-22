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
    public partial class PlMenuPage : Form
    {
        public PlMenuPage()
        {
            InitializeComponent();
        }

        private void btnPlOverviewPage_Click(object sender, EventArgs e)
        {
            PlOverviewPage newForm = new PlOverviewPage();
            newForm.ShowDialog();
        }

        private void btnPlProfessorsPage_Click(object sender, EventArgs e)
        {
            KathightesSelectOptionPlPage newForm = new KathightesSelectOptionPlPage();
            newForm.ShowDialog();
        }

        private void btnPlPage_Click(object sender, EventArgs e)
        {
            WebPlPage newForm = new WebPlPage();
            newForm.ShowDialog();
        }

        private void btnPlVideoPage_Click(object sender, EventArgs e)
        {
            VideoPlPage newForm = new VideoPlPage();
            newForm.ShowDialog();
        }
    }
}
