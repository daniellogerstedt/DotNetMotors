using System;
using Xunit;
using DotNetMotors.Classes;

namespace TestDotNetMotors
{
    public class UnitTest1
    {
        [Fact]
        public void DriveStreetBike()
        {
            StreetBike streetBike = new StreetBike();

            Assert.True(streetBike.Drive());
        }

        [Fact]
        public void GoFastStreetBike()
        {
            StreetBike streetBike = new StreetBike();

            Assert.True(streetBike.GoFast());
        }

        [Fact]
        public void HonkStreetBike()
        {
            StreetBike streetBike = new StreetBike();

            Assert.True(streetBike.Honk());
        }

        [Fact]
        public void LeanLeftStreetBike()
        {
            StreetBike streetBike = new StreetBike();

            Assert.True(streetBike.LeanLeft());
        }

        [Fact]
        public void LeanRightStreetBike()
        {
            StreetBike streetBike = new StreetBike();

            Assert.True(streetBike.LeanRight());
        }

        [Fact]
        public void WheelieStreetBike()
        {
            StreetBike streetBike = new StreetBike();

            Assert.True(streetBike.Wheelie());
        }

        [Fact]
        public void SharpCornerStreetBike()
        {
            StreetBike streetBike = new StreetBike();

            Assert.True(streetBike.SharpCorner());
        }
    }
}
