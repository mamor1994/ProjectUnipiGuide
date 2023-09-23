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
    public partial class LocationPage : Form
    {
        public LocationPage()
        {
            InitializeComponent();
        }

        private void LocationPage_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("https://www.google.com/maps?q=Πανεπιστήμιο+Πειραιώς");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:publ@unipi.gr");  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Δεν ήταν δυνατό το άνοιγμα του email client. Σφάλμα: " + ex.Message);
            }
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Red;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Firebrick;
        }
    }
}
