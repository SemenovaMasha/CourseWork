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
        public static int ID;

        static ConnectionClass()
        {
        }
        public static void setConnectionString(string path)
        {
            sql = new SQLiteConnection(@"Data Source="+path+";Version=3");
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
            SQLiteCommand sc = new SQLiteCommand(s, sql);

            SQLiteDataReader sdr = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);

            sdr.Close();

            sql.Close();

            return dt;
        }

        public static void createEmptyDataBase(string path)
        {
            SQLiteConnection.CreateFile(path);
            sql = new SQLiteConnection(@"Data Source=" + path + ";Version=3");

            executeQuery
            ("create table Material(ID INTEGER PRIMARY KEY autoincrement, Name TEXT, Volume INTEGER); " +
            "create table Providers(ID INTEGER PRIMARY KEY autoincrement, Name TEXT, Address TEXT , Phone TEXT, Mail TEXT);" +
            "create table ProvidersList(ID INTEGER PRIMARY KEY autoincrement, ProviderID integer, Material TEXT , Price integer, Volume integer, Time integer);"+
            "create table Client(ID INTEGER PRIMARY KEY autoincrement, Name text, Surname text,Patronymic text,Mail text,Address text,Phone text,Login text,Password text);" +
            "create table Purchase(ID INTEGER PRIMARY KEY autoincrement, ProviderID integer, Material text, Volume integer, Price integer,Data text);" +
            "create table Products(ID INTEGER PRIMARY KEY autoincrement,Type text,Material text,VolMaterial integer,DopMaterial text,VolDopMaterial integer,Price integer,Status text,Image text);" +
            "create table Orders(ID INTEGER PRIMARY KEY autoincrement,ClientID integer,ProductID integer, Price integer,Status text,Data text);");
        }
    }
}
