using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPSClinicalApp.Persistence
{
    public interface ISqliteDB
    {
        SQLiteConnection GetSQLiteConnection();
    }
}
