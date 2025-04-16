namespace CarLibrary
{
    public class PassengerCar : Car
    {
        public int PassengerCapacity { get; set; }

        public PassengerCar(string brand, string model, string color, double engineCapacity, int passengerCapacity)
            : base(brand, model, color, engineCapacity, "PassengerCar")
        {
            PassengerCapacity = passengerCapacity;
        }

        public string GetPassengerCarInfo()
        {
            return $"{GetCarInfo()}, Passengers: {PassengerCapacity}";
        }
    }
}

