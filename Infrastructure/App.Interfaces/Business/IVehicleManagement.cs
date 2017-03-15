using App.DataModels;
using System.Collections.Generic;

namespace App.Interfaces.Business
{

    public interface IVehicleManagment
    {
        List<Vehicle> GetAllVehicles();
        Vehicle GetVehicleBy(int id);
        Vehicle SaveVehicle(Vehicle data);
        bool UpdateVehicle(Vehicle data);
        void DeleteVehicleBy(int id);
    }
}
