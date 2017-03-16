using App.Business;
using App.DataModels;
using App.Interfaces.Business;
using App.Interfaces.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Tests
{
    public class VehicleManagmentTests
    {


        public void GetAllVehiclesTest()
        {
            var mockRepo = new Mock<IVehicleRepository>();
            
            mockRepo.Setup(vm => vm.GetAll()).Returns(mockRepo.Object.GetAll());

            var vehicleManagement = new VehicleManagment(mockRepo);
        }


        //new List<Vehicle>()
        //    {
        //        new Vehicle() { Id = 1, Make = "Tesla", Model = "Model S", Year = 2017 },
        //        new Vehicle() { Id = 1, Make = "Tesla", Model = "Model X", Year = 2017 },
        //        new Vehicle() { Id = 1, Make = "Tesla", Model = "Energy", Year = 2017 },
        //    }

    //public class MockedVehicleRepository : IVehicleRepository
    //{
    //    public void DeleteVehicle(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Vehicle FilterBy(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Vehicle> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Vehicle SaveVehicleData(Vehicle data)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
}
