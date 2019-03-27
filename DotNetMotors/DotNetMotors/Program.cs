using System;

namespace DotNetMotors
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes.Commuter commuter = new Classes.Commuter();
            Console.WriteLine("The Commuter is Driving");
            commuter.Drive();

            Classes.Pickup pickup = new Classes.Pickup();
            Console.WriteLine("The Pickup is Hauling");
            pickup.Haul();

            Classes.Racecar racecar = new Classes.Racecar();
            Console.WriteLine("The Racecar is Drafting");
            racecar.Draft();

            Classes.MotorCycle streetBike = new Classes.StreetBike();
            Console.WriteLine("The Street Bike is Doin a Wheelie");
            streetBike.Wheelie();

            Classes.CargoVan cargoVan = new Classes.CargoVan();
            Console.WriteLine("The Cargo Van is Honking");
            cargoVan.Honk();
        }
    }
}
