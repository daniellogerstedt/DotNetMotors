using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class StreetBike : MotorCycle
    {
        public override bool Drive()
        {
            Console.WriteLine("Riding");
            return true;
        }

        public override bool GoFast()
        {
            Console.WriteLine("Outrunning State Patrol");
            return true;
        }

        public override bool Honk()
        {
            Console.WriteLine("Beep!");
            return true;
        }

        public override bool LeanLeft()
        {
            Console.WriteLine("Left Turn");
            return true;
        }

        public override bool LeanRight()
        {
            Console.WriteLine("Right Turn");
            return true;
        }

        public override bool Wheelie()
        {
            Console.WriteLine("Poppin");
            return true;
        }

        public bool SharpCorner()
        {
            Console.WriteLine("Cut Sharp");
            return true;
        }
    }
}
