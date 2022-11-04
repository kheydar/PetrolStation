using System;
using System.Runtime.ConstrainedExecution;

namespace PetrolStation
{
    public class Vehicle
    {
        private static readonly Random random = new Random();

        string VehicleFuelType { get; set; }
        string TypeofVehicle { get; set; }
        int VehicleTankSize { get; set; }
        int StartingFuel { get; set; }
        int NewVehicleCreation { get; set; }
        

        public Vehicle(string vehicleFuelType, string typeofVehicle, int vehicleTankSize, int startingFuel, int newVehicleCreation = 1500)
        {
            this.VehicleFuelType = vehicleFuelType;
            this.TypeofVehicle = typeofVehicle;
            this.VehicleTankSize = vehicleTankSize;
            this.StartingFuel = startingFuel;
            this.NewVehicleCreation = newVehicleCreation;
        }

        public string VehicleInfo
        {
            get => $"Vehicle is a {TypeofVehicle} that uses {VehicleFuelType} with a tank size of {VehicleTankSize} and with a starting fuel of {StartingFuel}";
        }

        public string VehicleInfo2()
        {
            return $"Vehicle is a {TypeofVehicle} that uses {VehicleFuelType} with a tank size of {VehicleTankSize} and with a starting fuel of {StartingFuel}";
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