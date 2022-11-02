namespace PetrolStation
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] _fuelType = { "Petrol", "Diesel", "LPG" };
            string[] _vehicleTypes = { "Car", "Van", "Lorry" };

            int fuelGenerator = new Random().Next(3);
            int vehicleGenerator = new Random().Next(3);

            Vehicle myObj = new Vehicle(_fuelType[fuelGenerator], _vehicleTypes[vehicleGenerator], 50, 12);
            Console.WriteLine(myObj.VehicleInfo);


            //Console.WriteLine(_vehicleTypes[vehicleGenerator]);
            //Console.WriteLine(_fuelType[fuelGenerator]);

        }
    }
}