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
            ComputerScience.Visible = false;
            Informatics.Visible = true;
            DigitalSystems.Visible = true;
        }

        private void Informatics_CheckedChanged(object sender, EventArgs e)
        {
            PlMenuPage newform = new PlMenuPage();
            newform.Show();
            this.Hide();
        }
    }
}
