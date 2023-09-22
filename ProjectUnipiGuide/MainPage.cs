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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GenInfo_Click(object sender, EventArgs e)
        {
            GenInfoPage newform = new GenInfoPage();
            newform.Show();
            this.Hide();
        }

        private void Schools_Click(object sender, EventArgs e)
        {
            Schools newform = new Schools();
            newform.Show();
            this.Hide();
        }

        private void Services_Click(object sender, EventArgs e)
        {
            ServicesPage newform = new ServicesPage();
            newform.Show();
            this.Hide();
        }
    }
}
