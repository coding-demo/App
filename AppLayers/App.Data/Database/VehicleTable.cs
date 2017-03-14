using App.DataModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Database
{
    /// <summary>
    /// Simulation of a table in a SQL Database
    /// </summary>
    public static class VehicleTable
    {

        public static DataTable Table = new DataTable("Vehicles");
     
        public static void InitVehicleTable()
        {
            //create the table definition if not already created
            if (Table.Columns.Count <= 0)
            {
                Table.Columns.Add(new DataColumn("Id", typeof(int)));
                Table.Columns.Add(new DataColumn("Year", typeof(int)));
                Table.Columns.Add(new DataColumn("Make", typeof(string)));
                Table.Columns.Add(new DataColumn("Model", typeof(string)));
                Table.PrimaryKey = new DataColumn[] { Table.Columns["Id"] };

                Table.Rows.Add(1, 2013, "Honda", "Accord");
                Table.Rows.Add(2, 2013, "Chevy", "Malibu");
            }
        }

 
        public static DataRow Select(int id)
        {
            return Table.Select("Id=" + id.ToString()).SingleOrDefault();
        }

        public static List<DataRow> Select()
        {
            return Table.Select().ToList();
        }

        public static void Insert(DataRow row)
        {
            Table.Rows.Add(row);
        }

        public static void Update(DataRow record)
        {
            throw new NotImplementedException();
        }

        public static void Delete(int id)
        {
            throw new NotImplementedException();
        }


    }
}
