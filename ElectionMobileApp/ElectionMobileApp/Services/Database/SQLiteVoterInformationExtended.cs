using ElectionMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElectionMobileApp.Services
{
    public class SQLiteVoterInformationExtended : SQLiteDBConfig, ISQLiteCRUD<VoterInformationExtended>
    {
        public SQLiteVoterInformationExtended()
        {
            Create();
        }
        public void Create()
        {
            GetConnection().CreateTable<VoterInformationExtended>();
        }

        public int Delete(VoterInformationExtended data)
        {
           return GetConnection().Delete(data);
        }

        public VoterInformationExtended Get(int ID)
        {
           return GetConnection().Table<VoterInformationExtended>().Where(i => i.ID == ID).FirstOrDefault();
        }

        public int Insert(VoterInformationExtended data)
        {
            try
            {
                return GetConnection().Insert(data);
            }
            catch(Exception er)
            {
               return Update(data);
            }
        }
       
        public int Update(VoterInformationExtended data)
        {
            return GetConnection().Update(data);
        }
    }
}
