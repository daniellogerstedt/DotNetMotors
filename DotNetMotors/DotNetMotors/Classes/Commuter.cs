using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Commuter : Car, IReverseGear, IAllWheelDrive
    {
        public override bool Drive()
        {
            Console.WriteLine("Goin Forward");
            return true;
        }

        public override bool GoFast()
        {
            Console.WriteLine("Zoom Zoom");
            return true;
        }

        public override bool Honk()
        {
            Console.WriteLine("What the BEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEP");
            return true;
        }

        public bool CauseTraffic()
        {
            Console.WriteLine("Standby while I cause an accident");
            return true;
        }

        public bool DriveBackwards()
        {
            Console.WriteLine("Goin Backward Beep");
            return true;
        }

        public bool UseAllWheels()
        {
            Console.WriteLine("More Traction!");
            return true;
        }
    }
}
