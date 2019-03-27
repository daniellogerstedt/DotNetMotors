using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public abstract class HeavyFrame : Vehicle
    {
        public abstract bool Haul();

        public abstract bool ChugFuel();
    }
}
