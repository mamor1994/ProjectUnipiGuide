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

        private readonly List<string> imagePaths = new List<string>
        {
            Path.Combine(Directory.GetCurrentDirectory(), @"images\image1.jfif"), 
            Path.Combine(Directory.GetCurrentDirectory(), @"images\image2.jfif"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\image3.jfif"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\image4.jfif"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\image5.jfif"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\image6.jfif"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\image7.jfif"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\image8.jfif"),
            Path.Combine(Directory.GetCurrentDirectory(), @"images\image9.jfif")
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
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς η οποία δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";

            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            EntrancePage form = new EntrancePage();
            form.Show();
            this.Hide();  
        }
    }
}
