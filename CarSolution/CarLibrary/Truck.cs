namespace CarLibrary
{
    public class Truck : Car
    {
        public double LoadCapacity { get; set; }

        public Truck(string brand, string model, string color, double engineCapacity, double loadCapacity)
            : base(brand, model, color, engineCapacity, "Truck")
        {
            LoadCapacity = loadCapacity;
        }

        public string GetTruckInfo()
        {
            return $"{GetCarInfo()}, Load Capacity: {LoadCapacity} tons";
        }
    }
}
