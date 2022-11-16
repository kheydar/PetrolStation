using System;

namespace PetrolStation
{
    public class Vehicle
    {

        string VehicleFuelType { get; set; }
        string TypeofVehicle { get; set; }
        int VehicleTankSize { get; set; }
        int StartingFuel { get; set; }
        int NewVehicleCreation { get; set; }
        string[]? randFuelType { get; set; }
        string[]? randVehicle { get; set; }

        Random random = new Random();


        public Vehicle(string vehicleFuelType, string typeofVehicle, int vehicleTankSize, int startingFuel, int newVehicleCreation = 1500)
        {
            VehicleFuelType = vehicleFuelType;
            TypeofVehicle = typeofVehicle;
            VehicleTankSize = vehicleTankSize;
            StartingFuel = startingFuel;
            NewVehicleCreation = newVehicleCreation;
        }

        public Vehicle()
        {
            randFuelType = new string[] { "Diesel", "Petrol", "LPG" };
            VehicleFuelType = randFuelType[random.Next(0, 2)];
            randVehicle = new string[] { "Car", "Van", "HVG" };
            TypeofVehicle = randVehicle[random.Next(0, 2)];
            VehicleTankSize = random.Next(50, 150);
            StartingFuel = random.Next(0, 150);
            NewVehicleCreation = random.Next(1500, 2200);
        }

        public string VehicleInfo
        {
            get => $"Vehicle is a {TypeofVehicle} that uses {VehicleFuelType} with a tank size of {VehicleTankSize} and with a starting fuel of {StartingFuel}";
        }
        

    }
}

/*
Rules
Cars - maximum 50 litres
Vans - maximum 80 litres
HGV - maximum 150 litres

HGV only use Diesel.
Vans on both Diesel and LPG.
Cars can use any type of fuel.

Newly created vehicles will be created with a random amount of fuel already
in their tank (which cannot be greater than a half of their total tank capacity).
Fuelling time will be based on the above amount.
*/