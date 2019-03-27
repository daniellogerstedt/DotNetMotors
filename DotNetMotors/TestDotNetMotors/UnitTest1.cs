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

        [Fact]
        public void DriveCommuter()
        {
            Commuter commuter = new Commuter();

            Assert.True(commuter.Drive());
        }

        [Fact]
        public void GoFastCommuter()
        {
            Commuter commuter = new Commuter();

            Assert.True(commuter.GoFast());
        }

        [Fact]
        public void HonkCommuter()
        {
            Commuter commuter = new Commuter();

            Assert.True(commuter.Honk());
        }

        [Fact]
        public void CauseTrafficCommuter()
        {
            Commuter commuter = new Commuter();

            Assert.True(commuter.CauseTraffic());
        }

        [Fact]
        public void DriveRacecar()
        {
            Racecar raceCar = new Racecar();

            Assert.True(raceCar.Drive());
        }

        [Fact]
        public void GoFastRacecar()
        {
            Racecar raceCar = new Racecar();

            Assert.True(raceCar.GoFast());
        }

        [Fact]
        public void HonkRacecar()
        {
            Racecar raceCar = new Racecar();

            Assert.True(raceCar.Honk());
        }

        [Fact]
        public void DraftRacecar()
        {
            Racecar raceCar = new Racecar();

            Assert.True(raceCar.Draft());
        }

        [Fact]
        public void ChugFuelPickup()
        {
            Pickup pickup = new Pickup();

            Assert.True(pickup.ChugFuel());
        }

        [Fact]
        public void DrivePickup()
        {
            Pickup pickup = new Pickup();

            Assert.True(pickup.Drive());
        }

        [Fact]
        public void HaulPickup()
        {
            Pickup pickup = new Pickup();

            Assert.True(pickup.Haul());
        }

        [Fact]
        public void HonkPickup()
        {
            Pickup pickup = new Pickup();

            Assert.True(pickup.Honk());
        }

        [Fact]
        public void InstallCanopyPickup()
        {
            Pickup pickup = new Pickup();

            Assert.True(pickup.InstallCanopy());
        }

        [Fact]
        public void RemoveCanopyPickup()
        {
            Pickup pickup = new Pickup();

            Assert.True(pickup.RemoveCanopy());
        }

        [Fact]
        public void ChugFuelCargoVan()
        {
            CargoVan cargoVan = new CargoVan();

            Assert.True(cargoVan.ChugFuel());
        }

        [Fact]
        public void DriveCargoVan()
        {
            CargoVan cargoVan = new CargoVan();

            Assert.True(cargoVan.Drive());
        }

        [Fact]
        public void HaulCargoVan()
        {
            CargoVan cargoVan = new CargoVan();

            Assert.True(cargoVan.Haul());
        }

        [Fact]
        public void HonkCargoVan()
        {
            CargoVan cargoVan = new CargoVan();

            Assert.True(cargoVan.Honk());
        }

        [Fact]
        public void LowerLaddersCargoVan()
        {
            CargoVan cargoVan = new CargoVan();

            Assert.True(cargoVan.LowerLadders());
        }

        [Fact]
        public void RaiseLaddersCargoVan()
        {
            CargoVan cargoVan = new CargoVan();

            Assert.True(cargoVan.RaiseLadders());
        }
    }
}
