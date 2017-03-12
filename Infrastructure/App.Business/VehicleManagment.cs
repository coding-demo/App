using App.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{
    public interface IVehicleManagment
    {

        List<Vehicle> GetAllVehicles();
        Vehicle GetVehicleBy(int id);
        Vehicle SaveVehicle(Vehicle data);
        bool UpdateVehicle(Vehicle data);
        bool DeleteVehicleBy(int id);



    }
    public class VehicleManagment : IVehicleManagment
    {
        public bool DeleteVehicleBy(int id)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetAllVehicles()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicleBy(int id)
        {
            throw new NotImplementedException();
        }

        public Vehicle SaveVehicle(Vehicle data)
        {
            throw new NotImplementedException();
        }

        public bool UpdateVehicle(Vehicle data)
        {
            throw new NotImplementedException();
        }
    }
}
