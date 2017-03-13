using App.DataModels;
using App.Interfaces.Business;
using App.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business
{


    public class VehicleManagment : IVehicleManagment
    {
        private readonly IVehicleRepository _repo;

        public VehicleManagment(IVehicleRepository repo)
        {
            _repo = repo;
        }


        public bool DeleteVehicleBy(int id)
        {
            return true;
        }

        public List<Vehicle> GetAllVehicles()
        {
            return new List<Vehicle>();
        }

        public Vehicle GetVehicleBy(int id)
        {
            return new Vehicle();
        }

        public Vehicle SaveVehicle(Vehicle data)
        {
            return new Vehicle();
        }

        public bool UpdateVehicle(Vehicle data)
        {
            return true;
        }
    }
}
