using ProjectUnipiGuide.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectUnipiGuide.DAL
{
    static class Connection
    {
       
        public static SQLiteConnection Connect(string connectionString)
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
