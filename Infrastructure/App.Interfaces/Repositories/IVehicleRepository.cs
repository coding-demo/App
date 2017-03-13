using App.DataModels;
using System.Collections.Generic;

namespace App.Interfaces.Repositories
{
    public interface IVehicleRepository
    {

        List<Vehicle> GetAllVehicles();

        Vehicle GetSpecificVehicleBy(int id);

        Vehicle SaveVehicleData(Vehicle data);


    }
}
