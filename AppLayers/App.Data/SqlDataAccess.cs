using System;
using System.Collections.Generic;
using App.DataModels;
using App.Interfaces.DataAccess;

namespace App.Data
{

    public class SqlDatabase : IDataBaseAccess
    {
        public List<object> GetRecords()
        {
            throw new NotImplementedException();
        }

        public object GetRowById(int id)
        {
            throw new NotImplementedException();
        }

        public object InsertRecord(object record)
        {
            throw new NotImplementedException();
        }
    }
}
