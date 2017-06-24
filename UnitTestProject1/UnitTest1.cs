using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cars_OpensourcetestingCluster;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double distance = 100;
            double fuel_used = 20;
            double expected = 20;
            var Test_Vehicle = new Vehicle(1, "Ford", "GTX", "2007", "dkedfe33", distance, 0, fuel_used, 0, 0);
            double actual = Test_Vehicle.Fuel_Economy();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            int distance = 100;
            int vehicle_id = 1;
            int fuel_used = 20;
            double expected = 100;
            
            var test1 = new PerKmRental(1, 100, 20);

            double actual = test1.Price();

            Assert.AreEqual(expected, actual);
        }
    }
}
