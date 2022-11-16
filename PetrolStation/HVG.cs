using System;
using PetrolStation;


namespace PetrolStation
{
    class HVG : Vehicle
    {
        private readonly Random random = new Random();
        private int startingFuel;
        private string[]? FuelType { get; set; }
        private string? VehicleFuelType { get; set; }

        public HVG(int startingFuel, int newVehicleCreation = 1500, int vehicleTankSize = 150, string vehicleFuelType = "Diesel", string typeofVehicle = "HVG")
            : base(vehicleFuelType, typeofVehicle, vehicleTankSize, startingFuel, newVehicleCreation)

        {


        }

        public HVG(int vehicleTankSize = 150, string vehicleFuelType = "Diesel", string typeofVehicle = "HVG")
           : base()

        {
            Random random = new Random();
            startingFuel = random.Next(0, 75);

        }

    }

}