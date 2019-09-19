using Microsoft.VisualStudio.TestTools.UnitTesting;
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






    }
}
