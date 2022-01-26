using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var isSucc = false;
            var nOfWheels = 0;
            while (!isSucc)
            {
                Console.WriteLine("How many wheels does it have?");
                isSucc = int.TryParse(Console.ReadLine(), out nOfWheels);
            }

            IVehicle vehicle = VehicleFactory.GetVehicle(nOfWheels);
            vehicle.Drive();
        }
    }
}
