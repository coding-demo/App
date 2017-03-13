using App.Interfaces.DataAccess;
using App.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {


        public VehicleRepository(IDataBaseAccess database)
        {

        }
            
    }
}
