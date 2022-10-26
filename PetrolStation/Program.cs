using PetrolStation;

class Program
{
    public void Main(string[] args)
    {
        string[] _fuelType = { "Petrol", "Diesel", "LPG" };
        string[] _vehicleTypes = { "Car", "Van", "Lorry" };

        int fuelGenerator = new Random().Next(3);
        int vehicleGenerator = new Random().Next(3);

        Vehicle myObj = new Vehicle("Petrol","Car", 50, 12);
        Console.WriteLine(myObj.VehicleInfo);

        Console.WriteLine(_vehicleTypes[vehicleGenerator]);
        Console.WriteLine(_fuelType[fuelGenerator]);

    }
}
