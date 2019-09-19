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
            //Arrange + Act
            Car car = new Car();


            //Assert
            Assert.ThrowsException<Exception>(() =>
            {
                string c = "12345678";
                car.LicensePlate = c;
            });

        }
        [TestMethod]
        public void TestMethodBrobizz()
        {
            //Arrange
            double expectedResult = 240 * 0.95;

            //Act
            Car car = new Car();
            car.brobizz = true;

            //Assert
            Assert.AreEqual(expectedResult, car.Price());
        }
        
        

        




    }
}
