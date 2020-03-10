using System;
using System.Collections.Generic;
using System.Text;

namespace ElectionMobileApp.Services
{
    public interface ISQLiteCRUD<T>
    {
        void Create();
        int Update(T data);
        int Delete(T ID);
        T Get(int ID);
        int Insert(T data);
    }
}
