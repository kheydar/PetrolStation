using PetrolStation;

namespace PetrolStation
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] _fuelType = { "Petrol", "Diesel", "LPG" };
            string[] _vehicleTypes = { "Car", "Van", "Lorry" };

            Random random = new Random();
            Car car = new Car();




            Vehicle myObj = new Vehicle(_fuelType[random.Next(1,3)], _vehicleTypes[random.Next(1, 3)], 50, 12);
            Console.WriteLine(myObj.VehicleInfo);

            Vehicle myObj2 = new Vehicle(_fuelType[random.Next(1, 3)], _vehicleTypes[random.Next(1, 3)], 50, 12);
            Console.WriteLine(myObj2.VehicleInfo);

            Vehicle myObj3 = new Vehicle(_fuelType[random.Next(1, 3)], _vehicleTypes[random.Next(1, 3)], 50, 12);
            Console.WriteLine(myObj3.VehicleInfo);

            //Console.WriteLine(_vehicleTypes[vehicleGenerator]);
            //Console.WriteLine(_fuelType[fuelGenerator]);

        }
    }
}