using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjectUnipiGuide
{
    public partial class EventPage : Form
    {
        String connectionString = "Data source=calendar.db;Version=3;";

        public EventPage()
        {
            InitializeComponent();
        }

        private void EventPage_Load(object sender, EventArgs e)
        {
            txdate.Text = CalendarPage.static_year + "-" + CalendarPage.static_month + "-" + UserControlDays.static_day;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            String selectSQL = "INSERT INTO Events(date,event)values(?,?)";
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = selectSQL;
            command.Parameters.AddWithValue("date",txdate.Text);
            command.Parameters.AddWithValue("event", txevent.Text);
            command.ExecuteNonQuery();
            if (txevent.Text.Trim() == "")
            {
                MessageBox.Show("Fill in the event field");
            }
            else
            {
                MessageBox.Show("Saved");
                this.Close();
            }
            command.Dispose();
            connection.Close();
        }
    }
}
