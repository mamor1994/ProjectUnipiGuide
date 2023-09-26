using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUnipiGuide
{
    public partial class VideoPlPage : Form
    {
        private int clickCounter = 0; 

        public VideoPlPage()
        {
            InitializeComponent();
        }

        private void VideoPlPage_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "media/csunipi.mp4";
            axWindowsMediaPlayer1.uiMode = "none";
        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, _WMPOCXEvents_ClickEvent e)
        {
            clickCounter++; 

            if (clickCounter % 2 == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlMenuPage form = new PlMenuPage();
            form.Show();
            this.Hide();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς ο οποίος δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
