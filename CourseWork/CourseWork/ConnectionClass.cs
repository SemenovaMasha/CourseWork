using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    static class ConnectionClass
    {
        public static SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\mydb.sqlite;Version=3");

        static ConnectionClass()
        {
        }
        public static void executeQuery(string s)
        {
            sql.Open();

            SQLiteCommand sc = new SQLiteCommand(s, sql);

            sc.ExecuteNonQuery();
            sql.Close();
        }
        public static DataTable getResult(string s)
        {
            sql.Open();
            SQLiteCommand sc = new SQLiteCommand
                  (s, sql);

            SQLiteDataReader sdr = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);

            sdr.Close();

            sql.Close();

            return dt;
        }
    }
}
