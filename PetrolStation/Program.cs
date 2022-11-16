using System;
using PetrolStation;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {

            var obj = new Vehicle();
            Console.WriteLine(obj.VehicleInfo);

            Car car = new Car();
            Console.WriteLine(car.VehicleInfo);


            var Lorry = new HVG();
            Console.WriteLine(Lorry.VehicleInfo);

        }
    }
}

//Warning CS7022: The entry point of the program is global code; ignoring 'Program.Main(string[])' entry point. (CS7022) (PetrolStation)