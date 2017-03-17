using App.DataModels;
using App.Interfaces.Repositories;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace App.Business.Tests
{
    public class VehicleManagmentTests
    {

        [Test]
        public void GetAllVehiclesTest()
        {
            //Arrange
            var mockRepo = new Mock<IVehicleRepository>();
            mockRepo.Setup(vm => vm.GetAll()).Returns(VehicleData());
            var vehicleManagement = new VehicleManagment(mockRepo.Object);

            //Act
            var rowCount = vehicleManagement.GetAllVehicles().Count;

            //Assert
            Assert.AreEqual(3, rowCount);
        }

        [Test]
        public void GetVehicleByIdTest()
        {
            //Arrange
            var mockRepo = new Mock<IVehicleRepository>();
            mockRepo.Setup(vr => vr.FilterBy(It.Is<int>(i => i > 0))).Returns(VehicleData().Find(f => f.Id == 1));
            var vehicleManagement = new VehicleManagment(mockRepo.Object);
            int searchVehicleId = 1;

            //Act
            var data = vehicleManagement.GetVehicleBy(searchVehicleId);

            //Assert
            Assert.AreEqual(searchVehicleId, data.Id);
        }


        private List<Vehicle> VehicleData()
        {
            return new List<Vehicle>()
                {
                    new Vehicle() { Id = 1, Make = "Tesla", Model = "Model S", Year = 2017 },
                    new Vehicle() { Id = 1, Make = "Tesla", Model = "Model X", Year = 2017 },
                    new Vehicle() { Id = 1, Make = "Tesla", Model = "Energy", Year = 2017 },
                };
        }
    }
}
