using System;
using System.Collections.Generic;
using App.DataModels;
using App.Interfaces.DataAccess;
using App.Interfaces.Repositories;

namespace App.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly IDataBaseAccess _database;

        public VehicleRepository(IDataBaseAccess database)
        {
            _database = database;
        }

        public List<Vehicle> GetAllVehicles()
        {
            //return  _database.GetRecords();
            throw new NotImplementedException();
        }

        public Vehicle GetSpecificVehicleBy(int id)
        {
            throw new NotImplementedException();
        }

        public Vehicle SaveVehicleData(Vehicle data)
        {
            throw new NotImplementedException();
        }
    }
}
