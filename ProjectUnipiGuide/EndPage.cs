using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace ProjectUnipiGuide
{
    public partial class EndPage : Form
    {
        private SpeechSynthesizer synthesizer;

        public EndPage()
        {
            InitializeComponent();
            synthesizer = new SpeechSynthesizer();
            
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            string textToSpeak = "Thanks for your time";
            synthesizer.SpeakAsync(textToSpeak);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            synthesizer.Dispose();
            Application.Exit();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage form = new MainPage();
            form.Show();
            this.Hide();
            timer1.Stop();
            synthesizer.Dispose();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς η οποία δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EndPage_Load(object sender, EventArgs e)
        {
            string textToSpeak = "Thanks for your time";
            synthesizer.SpeakAsync(textToSpeak);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            synthesizer.Dispose();
            Application.Exit();
        }

        private void EndPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
