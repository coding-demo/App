using System;
using System.Collections.Generic;
using App.DataModels;
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

        public void InsertRecord(DataRow record)
        {
            VehicleTable.Insert(record);
        }

        public void UpdateRecord(DataRow record)
        {
            VehicleTable.Update(record);
        }

        public void DeleteRecord(int id)
        {
            VehicleTable.Delete(id);
        }

    }
}
