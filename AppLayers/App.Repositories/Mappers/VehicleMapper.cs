using App.Interfaces.Repositories.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using App.DataModels;
using App.Data.Database;

namespace App.Repositories.Mappers
{

    /// <summary>
    /// Manual mapping here. Use AutoMapper or similar in actual projects.
    /// </summary>
    public class VehicleMapper  : IDataMapper<Vehicle>
    {
        public DataTable MapDtoListToTable(List<Vehicle> list)
        {
            throw new NotImplementedException();
        }

        public DataRow MapDtoToRow(Vehicle type)
        {
            DataTable tab = VehicleTable.GetVehicleTableStructure();
            tab.Rows.Add(type.Id,type.Year, type.Make, type.Model);

            return tab.Rows[0];
        }

        public Vehicle MapToDto(DataTable table)
        {
            var row = table.Rows[0];
            return new Vehicle
            {
                Id = row.Field<int>(0),
                Year = row.Field<int>(1),
                Make = row.Field<string>(2),
                Model = row.Field<string>(3)
            };
        }

        public List<Vehicle> MapToDtoList(DataTable table)
        {
            List<Vehicle> v = new List<Vehicle>();

            foreach (DataRow row in table.Rows)
            {
                v.Add(new Vehicle
                {   Id = row.Field<int>(0),
                    Year = row.Field<int>(1),
                    Make = row.Field<string>(2),
                    Model = row.Field<string>(3)
                });
            }

            return v;
        }
    }

}
