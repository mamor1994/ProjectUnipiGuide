using Newtonsoft.Json;
using ProjectUnipiGuide.JsonHelpers;
using ProjectUnipiGuide.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectUnipiGuide
{
    public partial class LoginPage : Form
    {

        private readonly string connectionString = AppSettingsHelper.Get().ConnectionStrings.DatabaseConnection;
        SQLiteConnection connection;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (emailBox.Text.Trim() == "" && passwordBox.Text.Trim() == "")
                {
                    string message = "Το email και ο κωδικός είναι κενά. Προσπάθησε ξανά.";
                    MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailBox.Clear();
                    passwordBox.Clear();
                    emailBox.Focus();
                    emailBox.HideSelection = false;
                }
                else if (emailBox.Text.Length == 0)
                {
                    string message = "Το email είναι κενό. Προσπάθησε ξανά.";
                    MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailBox.Clear();
                    passwordBox.Clear();
                    emailBox.Focus();
                }
                else if (passwordBox.Text.Length == 0)
                {
                    string message = "Ο κωδικός είναι κενός. Προσπάθησε ξανά.";
                    MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailBox.Clear();
                    passwordBox.Clear();
                    emailBox.Focus();
                }
                else
                {
                    connection.Open();
                    String email = emailBox.Text;
                    String password = passwordBox.Text;
                    String selectSQL = "Select * FROM Student WHERE email=@email and password=@password";
                    SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {                        
                        string message = "Συνδέθηκες επιτυχώς!";
                        MessageBox.Show(message, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainPage form = new MainPage();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        string message = "Λάθος στοιχεία. Προσπάθησε ξανά.";
                        MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        emailBox.Clear();
                        passwordBox.Clear();
                        emailBox.Focus();
                    }

                    reader.Close();
                    command.Dispose();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Σφάλμα κατά τη διαδικασία: " + ex.Message, "ERROR");
            }
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            emailBox.Clear();
            passwordBox.Clear();
            emailBox.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς η οποία δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntrancePage form = new EntrancePage();
            form.Show();
            this.Hide();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
