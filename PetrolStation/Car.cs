﻿using System;
using PetrolStation;


namespace PetrolStation
{
    class Car : Vehicle  
    {
        private readonly Random random = new Random();
        private int startingFuel;
        private string[]? FuelType { get; set; }
        private string? VehicleFuelType { get; set; }

        public Car(string vehicleFuelType, int startingFuel, int newVehicleCreation = 1500, int vehicleTankSize = 50, string typeofVehicle = "Car")
            : base(vehicleFuelType, typeofVehicle, vehicleTankSize, startingFuel, newVehicleCreation)

        {
            
            
        }

        public Car(int vehicleTankSize = 50, string typeofVehicle = "Car")
           : base()

        {
            Random random = new Random();
            startingFuel = random.Next(0, 25);
            FuelType = new string[] { "Diesel", "Petrol", "LPG" };
            VehicleFuelType = FuelType[random.Next(0,2)];
        }

        public override string VehicleInfo
        {
            get => $"Vehicle is a Car running on {VehicleFuelType} with a tank size of 50 and with a starting fuel of {startingFuel}";
        }
    }

}