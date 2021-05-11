using RPSClinicalApp.Droid.Persistence;
using RPSClinicalApp.Persistence;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
[assembly: Dependency(typeof(SqliteDBConn))]
namespace RPSClinicalApp.Droid.Persistence
{
    public class SqliteDBConn : ISqliteDB
    {
        public SQLiteConnection GetSQLiteConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "HealthCareDB.db3");
            return new SQLiteConnection(path);
        }
    }
}