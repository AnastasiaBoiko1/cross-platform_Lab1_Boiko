using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class TruckTests
    {
        [TestMethod]
        public void TestTruckConstructor()
        {
            try
            {
                var truck = new Truck("Volvo", "FMX", "Blue", 8.0, 20);

                Assert.AreEqual("Volvo", truck.Brand);
                Assert.AreEqual("FMX", truck.Model);
                Assert.AreEqual("Blue", truck.Color);
                Assert.AreEqual(8.0, truck.EngineCapacity);
                Assert.AreEqual(20, truck.LoadCapacity);
            }
            catch (AssertFailedException ex)
            {
                Console.WriteLine("Constructor test failed: " + ex.Message);
                throw; // важливо: щоб тест відзначився як failed
            }
        }

        [TestMethod]
        public void TestTruckInfoOutput()
        {
            try
            {
                var truck = new Truck("Volvo", "FMX", "Blue", 8.0, 20);
                string expected = "Brand: Volvo, Model: FMX, Color: Blue, Engine Capacity: 8L, Current Speed: 0 km/h, Load Capacity: 20 tons";
                string actual = truck.GetTruckInfo();

                Assert.AreEqual(expected, actual, true, "Truck info output does not match expected value.");
            }
            catch (AssertFailedException ex)
            {
                Console.WriteLine("Info output test failed: " + ex.Message);
                throw;
            }
        }
    }
}



