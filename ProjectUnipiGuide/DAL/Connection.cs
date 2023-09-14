using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectUnipiGuide.DAL
{
    class Connection
    {
        public SQLiteConnection connect = new SQLiteConnection("Data Source = dbReviews.db;Version=3;");
    }
}
