using System;
using PetrolStation;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {

            //var obj = new Vehicle();
            //Console.WriteLine(obj.VehicleInfo);

            var car = new Car();
            Console.WriteLine(car.VehicleInfo);

            var Van = new Van();
            Console.WriteLine(Van.VehicleInfo);


            var Lorry = new HVG();
            Console.WriteLine(Lorry.VehicleInfo);

        }
    }
}
