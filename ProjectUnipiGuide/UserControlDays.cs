using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUnipiGuide
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        String connectionString = "Data source=calendar.db;Version=3;";
        private readonly EventPage currentEventPage = new EventPage(); 


        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayEvent();
        }

        public void days(int numday)
        {
            lbdays.Text = numday+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            //static_day = lbdays.Text;
            //timer1.Start();
            //currentEventPage.ShowDialog();
        }

        private void displayEvent()
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            String selectSQL = "Select * FROM Events WHERE date = ?";
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = selectSQL;
            command.Parameters.AddWithValue("date", CalendarPage.static_year + "-" + CalendarPage.static_month + "-" + lbdays.Text);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                lbevent.Text = reader["event"].ToString();
            }
            reader.Close();
            command.Dispose();
            connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
