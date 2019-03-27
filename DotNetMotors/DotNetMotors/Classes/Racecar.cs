using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public class Racecar : Car
    {
        public override bool Drive()
        {
            Console.WriteLine("Makin a left turn!");
            return true;
        }

        public override bool GoFast()
        {
            Console.WriteLine("Woosh");
            return true;
        }

        public override bool Honk()
        {
            Console.WriteLine("Beep");
            return true;
        }

        public bool Draft()
        {
            Console.WriteLine("Winning the race");
            return true;
        }
    }
}
