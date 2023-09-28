using System; 
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectUnipiGuide
{
    public partial class PhotosPage : Form
    {
        private const int Delay = 2000; 
        private int currentImageIndex = 0;
        private bool needToExitApp = true;


        private readonly List<string> imagePaths = new List<string>
        {
            @"../../../images/image1.jfif", 
            @"../../../images/image2.jfif",
            @"../../../images/image3.jfif",
            @"../../../images/image4.jfif",
            @"../../../images/image5.jfif",
            @"../../../images/image6.jfif",
            @"../../../images/image7.jfif",
            @"../../../images/image8.jfif",
            @"../../../images/image9.jfif"
        };
        
        public PhotosPage()
        {
            InitializeComponent();

            timer1.Interval = Delay;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (currentImageIndex < imagePaths.Count - 1)
            {
                currentImageIndex++;
            }
            else
            {
                currentImageIndex = 0;
            }

            ShowImage();
        }

        private void ShowImage()
        {
                var path = imagePaths[currentImageIndex];
                var image = Image.FromFile(path);
                pictureBox1.Image = image;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς ο οποίος δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";

            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Dispose();
            Application.Exit();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage form = new MainPage();
            form.Show();
            needToExitApp = false;
            Close();
            timer1.Stop();
            if (UserState.IsGuest == true)
            {
                form.btnCalendar.Visible = false;
            }
            else
            {
                form.btnCalendar.Visible = true;
            }
        }

        private void PhotosPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needToExitApp)
            {
                Application.Exit();
            }
        }
    }
}
