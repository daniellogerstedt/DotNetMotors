using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public abstract class Vehicle
    {
        int Wheels;
        string Engine;
        string FuelType;

        public abstract bool Drive();

        public abstract bool Honk();

    }
}
