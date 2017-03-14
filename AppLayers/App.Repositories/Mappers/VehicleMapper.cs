using App.Interfaces.Repositories.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using App.DataModels;

namespace App.Repositories.Mappers
{
    public class VehicleMapper  : IDataMapper<Vehicle>
    {

        
        public DataTable MapDTOListToTable(List<Vehicle> list)
        {
            throw new NotImplementedException();
        }

        public Vehicle MapToDTO(DataTable table)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> MapToDTOList(DataTable table)
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
