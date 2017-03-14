using System;
using System.Collections.Generic;
using App.DataModels;
using App.Interfaces.DataAccess;
using App.Interfaces.Repositories;
using App.Interfaces.Repositories.Mappers;
using System.Data;

namespace App.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly IDataBaseAccess _database;
        private readonly IDataMapper<Vehicle> _mapper;

        public VehicleRepository(IDataBaseAccess database, IDataMapper<Vehicle> mapper)
        {
            _database = database;
            _mapper = mapper;
        }

        public List<Vehicle> GetAll()
        {
            DataTable dt = new DataTable();
            var rows = _database.GetRecords();

            dt = rows.CopyToDataTable();

            var list = _mapper.MapToDTOList(dt);
            return list;
        }

        public Vehicle FilterBy(int id)
        {
            throw new NotImplementedException();
        }

        public Vehicle SaveVehicleData(Vehicle data)
        {
            throw new NotImplementedException();
        }
    }
}
