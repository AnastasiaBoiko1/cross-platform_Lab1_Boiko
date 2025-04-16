using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarLibrary;

[TestClass]
public class CarTests
{
    [TestMethod]
    public void TestCarSpeedChange()
    {
        // Arrange
        Car car = new Car("Toyota", "Camry", "Red", 2.5, "Passenger");

        // Act
        car.ChangeSpeed(50);

        // Assert
        Assert.AreEqual(50, car.CurrentSpeed);
    }

    [TestMethod]
    public void TestPassengerCarInfo()
    {
        // Arrange
        PassengerCar passengerCar = new PassengerCar("Toyota", "Camry", "Red", 2.5, 5);

        // Act
        string result = passengerCar.GetPassengerCarInfo();

        // Assert
        Assert.AreEqual("Brand: Toyota, Model: Camry, Color: Red, Engine Capacity: 2.5L, Current Speed: 0 km/h, Passengers: 5", result);
    }
}
