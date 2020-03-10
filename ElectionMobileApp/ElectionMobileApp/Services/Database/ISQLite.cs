using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElectionMobileApp.Services
{
    public interface ISQLite
    { 
        SQLiteConnection GetConnection();
    }
}
