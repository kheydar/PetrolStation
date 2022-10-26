using System;
using PetrolStation;

namespace PetrolStation
{
    class Van : Vehicle
    {
        public Van(string fuel, string type, int size, int startingFuel, int newVehicleCreation, int vehicleTankSize = 80)
            : base(fuel, type, size, startingFuel, newVehicleCreation)
        {
            //int vehicleTankSize = 80;
            
        }
    }

}