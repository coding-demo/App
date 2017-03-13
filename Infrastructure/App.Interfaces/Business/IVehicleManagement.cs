using App.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Interfaces.Business
{

    public interface IVehicleManagment
    {
        List<Vehicle> GetAllVehicles();
        Vehicle GetVehicleBy(int id);
        Vehicle SaveVehicle(Vehicle data);
        bool UpdateVehicle(Vehicle data);
        bool DeleteVehicleBy(int id);
    }
}
