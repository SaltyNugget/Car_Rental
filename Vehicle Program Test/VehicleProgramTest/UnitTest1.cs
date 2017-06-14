using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicle_Program;

namespace VehicleProgramTest
{
    [TestClass]
    public class UnitTest1
    {
        //Per Day Rental Test
        [TestMethod]
        public void TestPerDayRental()
        {
            //Assemble
            Testing PerDayRental = new Testing();
            int expectedResult = 200;

            //Act
            int actualResult = PerDayRental.PerDayRental(100, 2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Per Kilometre Rental Test
        [TestMethod]
        public void TestPerKmRental()
        {

            //Assemble
            Testing PerKmRental = new Testing();
            int expectedResult = 28;

            //Act
            int actualResult = PerKmRental.PerKmRental(28, 1);

                //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Fuel Purchase Test
        [TestMethod]
        public void TestFuelPurchase()
        {

            //Assemble
            Testing FuelPurchase = new Testing();
            double expectedResult = 32.50;

            //Act
            double actualResult = FuelPurchase.FuelPurchase(1.30, 25);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
