using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class CargoVan : Van, IReverseGear
    {
        bool LadderRack;

        public override bool ChugFuel()
        {
            Console.WriteLine("Nom Nom Nom, Gimme Dat Gas");
            return true;
        }

        public override bool Drive()
        {
            Console.WriteLine("Vroom Vroom");
            return true;
        }

        public bool DriveBackwards()
        {
            Console.WriteLine("Beep beep beep beeep beeep");
            return true;
        }

        public override bool Haul()
        {
            Console.WriteLine("Thunk");
            return true;
        }

        public override bool Honk()
        {
            Console.WriteLine("Bwaaaaaap");
            return true;
        }

        public bool LowerLadders()
        {
            if (LadderRack) Console.WriteLine("Dropping Ladders");
            return true;
        }

        public bool RaiseLadders()
        {
            if (LadderRack) Console.WriteLine("Raising Ladders");
            return true;
        }
    }
}
