using System;
using CarLibrary;

namespace CarConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PassengerCar passengerCar = new PassengerCar("Toyota", "Camry", "Red", 2.5, 5);
            Console.WriteLine(passengerCar.GetPassengerCarInfo());
            passengerCar.ChangeSpeed(50);
            Console.WriteLine("After speed change: " + passengerCar.GetCarInfo());

            Truck truck = new Truck("Volvo", "FMX", "Blue", 8.0, 20);
            Console.WriteLine(truck.GetTruckInfo());
            truck.ChangeSpeed(80);
            Console.WriteLine("After speed change: " + truck.GetCarInfo());

            Console.ReadKey();
        }
    }
}

