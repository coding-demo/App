using App.DataModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Database
{
    public class VehicleTable
    {

        public static List<Vehicle> Records = new List<Vehicle>();

        public Vehicle Single(int id)
        {
            return Records.Where(i => i.Id == id).SingleOrDefault();
        }

        public List<Vehicle> All()
        {
            return Records;
        }

        public Vehicle Add(Vehicle row)
        {
            Records.Add(row);

            return row;
        }


    }
}
