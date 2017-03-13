using App.DataModels;
using App.Interfaces.Business;
using App.Interfaces.Repositories;
using System.Collections.Generic;

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
