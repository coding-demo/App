using App.DataModels;
using System.Collections.Generic;

namespace App.Interfaces.Repositories
{
    public interface IVehicleRepository
    {

        List<Vehicle> GetAll();

        Vehicle FilterBy(int id);

        Vehicle SaveVehicleData(Vehicle data);

        void DeleteVehicle(int id);

        bool UpdateVehicleData(Vehicle data);

    }
}
