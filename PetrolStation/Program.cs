using PetrolStation;

namespace PetrolStation
{
    class Program
    {
        public void Main(string[] args)
        {
            string[] _fuelType = { "Petrol", "Diesel", "LPG" };
            string[] _vehicleTypes = { "Car", "Van", "Lorry" };

            Random random = new Random();

            Car car = new Car("Petrol", random.Next(1,25));
            Console.WriteLine(car.VehicleInfo);
            Console.WriteLine(car.VehicleInfo2());

            var Lorry = new HVG(100);
            Console.WriteLine(Lorry.VehicleInfo);
            Console.WriteLine(Lorry.VehicleInfo2());
          
        }
    }
}