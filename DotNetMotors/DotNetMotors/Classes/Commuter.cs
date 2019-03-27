using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    class Commuter : Car
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
    }
}
