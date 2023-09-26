using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using ProjectUnipiGuide.JsonHelpers;

namespace ProjectUnipiGuide.DAL
{
    class ClassDAL
    {
        private readonly string connectionString = AppSettingsHelper.Get().ConnectionStrings.DbReviewsConnection;

        public bool AddItemsToTable(Image img, string title, string subtitle)
        {
            var connection = Connection.Connect(connectionString);
            if (ConnectionState.Closed == connection.State)
            {
                connection.Open();
            }
            String query = "Insert into dbReviewsTable(Title, SubTitle, Image)values(@Title,@SubTitle,@Image)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Title", title.Trim());
                    cmd.Parameters.AddWithValue("SubTitle", subtitle.Trim());

                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    cmd.Parameters.AddWithValue("@Image", ms.ToArray());

                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch
            {
                throw;
            }     
            
        }

        public DataTable ReadItemsTable()
        {
            var connection = Connection.Connect(connectionString);
            if (ConnectionState.Closed == connection.State)
            {
                connection.Open() ;
            }
            string query = "SELECT * FROM dbReviewsTable";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            try
            {
                using (SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }   
    }
}
