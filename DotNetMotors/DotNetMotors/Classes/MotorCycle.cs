using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.Classes
{
    public abstract class MotorCycle : LightFrame
    {
        public abstract bool Wheelie();
        public abstract bool LeanRight();
        public abstract bool LeanLeft();
    }
}
