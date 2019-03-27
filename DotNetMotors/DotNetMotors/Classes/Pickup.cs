using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Pickup : Truck, IReverseGear, IAllWheelDrive
    {
        bool Canopy;

        public override bool ChugFuel()
        {
            Console.WriteLine("Chugalug");
            return true;
        }

        public override bool Drive()
        {
            Console.WriteLine("Driving");
            return true;
        }

        public bool DriveBackwards()
        {
            Console.WriteLine("Backin it up");
            return true;
        }

        public override bool Haul()
        {
            Console.WriteLine("Hauling");
            return true;
        }

        public override bool Honk()
        {
            Console.WriteLine("Honking");
            return true;
        }

        public bool InstallCanopy()
        {
            if (Canopy) Console.WriteLine("You've got a canopy!");
            return true;
        }

        public bool RemoveCanopy()
        {
            if (Canopy) Console.WriteLine("No longer have a canopy");
            return true;
        }

        public bool UseAllWheels()
        {
            Console.WriteLine("Extra Traction!");
            return true;
        }
    }
}
