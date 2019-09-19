using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicketLibrary;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPrice()
        {
            //Arrange
            Car car = new Car();
            double price;


            //Act
            price = car.Price();





            //Assert
            Assert.AreEqual(240, price);


            
        }

        [TestMethod]
        public void TestMethodVehicleType()
        {
            //Arrange
            Car car = new Car();
            string vehicletype;

            //Act
            vehicletype = car.VehicleType();

            //Assert
            Assert.AreEqual("Car", vehicletype);

        }

        [TestMethod]
        public void TestMethodPriceMC()
        {
            //Arrange
            MC mC = new MC();
            double price;

            //Act
            price = mC.Price();

            //Assert
            Assert.AreEqual(125, price);

            
            
            
        }
        [TestMethod]
        public void TestMethodVehicleMC()
        {
            //Arrange
            MC mC = new MC();
            string vehicle;

            //Act
            vehicle = mC.Vehicle();

            //Assert
            Assert.AreEqual("MC", vehicle);

        }
        [TestMethod]
        public void TestMethodPlate()
        {
            Car car = new Car();

            Assert.ThrowsException<Exception>(() =>
            {
                string c = "12345678";
                car.LicensePlate = c;
            });

        }
        
        

        




    }
}
