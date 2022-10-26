using System;
using PetrolStation;

namespace PetrolStation
{
    class Car : Vehicle  
    {
        public Car(string fuel, string type, int size, int startingFuel, int newVehicleCreation, int vehicleTankSize = 50)
            : base(fuel, type, size, startingFuel, newVehicleCreation)
        {
            //int vehicleTankSize = 50;
            //int startingFuel = Random number that is less than 25
        }
    }
}