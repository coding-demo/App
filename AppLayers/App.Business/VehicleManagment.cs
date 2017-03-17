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


        public void DeleteVehicleBy(int id)
        {
            _repo.DeleteVehicle(id);
             
        }

        public List<Vehicle> GetAllVehicles()
        {
            return _repo.GetAll();
        }

        public Vehicle GetVehicleBy(int id)
        {
            return _repo.FilterBy(id);
        }

        public Vehicle SaveVehicle(Vehicle data)
        {
            return _repo.SaveVehicleData(data);
        }

        public bool UpdateVehicle(Vehicle data)
        {

            return _repo.UpdateVehicleData(data);
        }
    }
}
