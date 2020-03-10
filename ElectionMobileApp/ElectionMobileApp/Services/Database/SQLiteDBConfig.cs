using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ElectionMobileApp.Models;
using SQLite;

namespace ElectionMobileApp.Services
{
    public class SQLiteDBConfig : ISQLite
    {
        private SQLiteConnection _database;
        public SQLiteConnection GetConnection()
        {
            if(_database==null)
            {
                var dbName = "Services.sqlite";
                var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                var path = Path.Combine(dbPath, dbName);
                _database = new SQLiteConnection(path);
            }
            
            return _database;
        }
        //public void createVoterInformationExtendedTable()
        //{
        //    GetConnection().CreateTable<VoterInformationExtended>();
        //}

    }
}
