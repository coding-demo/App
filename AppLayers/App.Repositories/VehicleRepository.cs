using System.Collections.Generic;
using App.DataModels;
using App.Interfaces.DataAccess;
using App.Interfaces.Repositories;
using App.Interfaces.Repositories.Mappers;
using System.Data;
using App.Data.Database;

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

            return _mapper.MapToDtoList(dt);
        }

        public Vehicle FilterBy(int id)
        {
            var row = _database.GetRowById(id);

            return _mapper.MapToDto(CreateTableFromRow(row));
        }

        public Vehicle SaveVehicleData(Vehicle data)
        {
            //creates a record to be inserted
            var recordToInsert = _mapper.MapDtoToRow(data);

            //inserts and returns inserted record
            var insertedRow = _database.InsertRecord(recordToInsert);

            //convert inserted row to DTO
            return _mapper.MapToDto(CreateTableFromRow(insertedRow));
        }

        public bool UpdateVehicleData(Vehicle data)
        {
            var recordToUpdate = _mapper.MapDtoToRow(data);

            return  _database.UpdateRecord(recordToUpdate);

        }

        /// <summary>
        /// converts row to table 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private DataTable CreateTableFromRow(DataRow row)
        {
            var tab = VehicleTable.GetVehicleTableStructure();
            tab.ImportRow(row);

            return tab;
        }

        public void DeleteVehicle(int id)
        {
            VehicleTable.Delete(id);
        }
    }
}
