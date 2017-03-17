using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace App.Data.Database
{
    /// <summary>
    /// Simulation of a table in a SQL Database
    /// </summary>
    public static class VehicleTable
    {
        private static int _incrementingRowId;
        public static DataTable Table = new DataTable("Vehicles");
     
        public static void InitVehicleTable()
        {
            //create the table definition if not already created
            if (Table.Columns.Count <= 0)
            {
                Table = GetVehicleTableStructure();

                Table.Rows.Add(1, 2013, "Honda", "Accord");
                Table.Rows.Add(2, 2013, "Chevy", "Malibu");
                _incrementingRowId = 2;
            }
        }

        public static DataTable GetVehicleTableStructure()
        {
            DataTable tab = new DataTable();
            tab.Columns.Add(new DataColumn("Id", typeof(int)));
            tab.Columns.Add(new DataColumn("Year", typeof(int)));
            tab.Columns.Add(new DataColumn("Make", typeof(string)));
            tab.Columns.Add(new DataColumn("Model", typeof(string)));
            tab.PrimaryKey = new DataColumn[] { tab.Columns["Id"] };

            return tab;
        }

        public static DataRow Select(int id)
        {
            return Table.Select("Id=" + id.ToString()).SingleOrDefault();
        }

        public static List<DataRow> Select()
        {
            return Table.Select().ToList();
        }

        public static DataRow Insert(DataRow row)
        {
            _incrementingRowId++;
            row[0] = _incrementingRowId;
            Table.ImportRow(row);

            return row;
        }

        public static bool Update(DataRow record)
        {
            DataRow row = Table.Select("Id=" + record["Id"]).FirstOrDefault();

            if (row != null)
            {
                row["Year"] = record["Year"];
                row["Make"] = record["Make"];
                row["Model"] = record["Model"];
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static void Delete(int id)
        {
            var row = Table.Select("Id=" + id.ToString());
            Table.Rows.Find(id).Delete();
            Table.AcceptChanges();
        }


    }
}
