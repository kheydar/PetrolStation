using System;
using System.Runtime.ConstrainedExecution;

namespace PetrolStation
{
    public class Vehicle
    {
        string vehicleFuelType { get; set; }
        string vehicleType { get; set; }
        int vehicleTankSize { get; set; }
        int currentFuel { get; set; }
        //int newVehicleCreation = 1500;

        //public Vehicle(string fuel, string type, int size, int startingFuel, int newVehicleCreation = 1500) this way you have a default value
        public Vehicle(string fuel, string type, int size, int startingFuel, int newVehicleCreation = 1500)
        {
            vehicleFuelType = fuel;
            vehicleType = type;
            vehicleTankSize = size;
            currentFuel = startingFuel;
        }

        public string VehicleInfo
        {
            get => $"Vehicle is a {vehicleType} that uses {vehicleFuelType} with a tank size of {vehicleTankSize}";
        }

    }
}

//Rules
//Cars - maximum 50 litres
//Vans - maximum 80 litres
//HGV - maximum 150 litres

//HGV only use Diesel. Vans on both Diesel and LPG. Cars can use any type of fuel.

//Newly created vehicles will be created with a random amount of fuel already
//in their tank (which cannot be greater than a half of their total tank capacity).
//Fuelling time will be based on the above amount.
