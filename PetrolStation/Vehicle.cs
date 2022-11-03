using System;
using System.Collections.Generic;

namespace PetrolStation
{
    public class Vehicle
    {
        Random random = new Random();
        string vehicleFuelType { get; set; }
        string typeofVehicle { get; set; }
        int vehicleTankSize { get; set; }
        int currentFuel { get; set; }
      
        public Vehicle(List<string> fuelType, string vehicleType, int tankSize, int startingFuel, int newVehicleCreation)
        {
            newVehicleCreation = random.Next(1500, 2500);
            fuelType = new List<string>() {"Diesel", "Petrol", "LPG"};
            typeofVehicle = vehicleType;
            vehicleTankSize = tankSize;
            currentFuel = startingFuel;
        }

        public string VehicleInfo
        {
            get => $"Vehicle is a {typeofVehicle} that uses {vehicleFuelType} with a tank size of {vehicleTankSize} " +
                $"and with a starting fuel of {currentFuel}";
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