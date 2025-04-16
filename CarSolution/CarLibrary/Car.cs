namespace CarLibrary
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double EngineCapacity { get; set; }
        public double CurrentSpeed { get; set; }
        public string CarType { get; set; }

        public Car(string brand, string model, string color, double engineCapacity, string carType)
        {
            Brand = brand;
            Model = model;
            Color = color;
            EngineCapacity = engineCapacity;
            CarType = carType;
            CurrentSpeed = 0;
        }

        public void ChangeSpeed(double speedChange)
        {
            CurrentSpeed += speedChange;
        }

        public virtual string GetCarInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Color: {Color}, Engine Capacity: {EngineCapacity}L, Current Speed: {CurrentSpeed} km/h";
        }
    }
}
