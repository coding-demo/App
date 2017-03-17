using System.Collections.Generic;
using App.Interfaces.DataAccess;
using App.Data.Database;
using System.Data;

namespace App.Data
{
    /// <summary>
    /// The Data Access Layer
    /// </summary>
    public class SqlDatabase : IDataBaseAccess
    {
        public SqlDatabase()
        {
            VehicleTable.InitVehicleTable();
        }

 
        public List<DataRow> GetRecords()
        {
            return VehicleTable.Select();
        }

        public DataRow GetRowById(int id)
        {
            return VehicleTable.Select(id);
        }

        public DataRow InsertRecord(DataRow record)
        {
            return VehicleTable.Insert(record);
        }

        public bool UpdateRecord(DataRow record)
        {
            return VehicleTable.Update(record);
        }

        public void DeleteRecord(int id)
        {
            VehicleTable.Delete(id);
        }

    }
}
