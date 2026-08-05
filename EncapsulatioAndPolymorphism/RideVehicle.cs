using System;
namespace EncapsulatioAndPolymorphism
{
        public interface IRideGPS
        {
            void GetCurrentLocation();
            void UpdateLocation(string location);
        }

        public abstract class RideVehicle
        {
            private int vehicleId;
            private string driverName;
            private double ratePerKm;

            public int VehicleId
            {
                get { return vehicleId; }
                set { vehicleId = value; }
            }

            public string DriverName
            {
                get { return driverName; }
                set { driverName = value; }
            }

            public double RatePerKm
            {
                get { return ratePerKm; }
                set
                {
                    if (value >= 0)
                        ratePerKm = value;
                }
            }

            public RideVehicle(int vehicleId, string driverName, double ratePerKm)
            {
                this.vehicleId = vehicleId;
                this.driverName = driverName;
                this.ratePerKm = ratePerKm;
            }

            public abstract double CalculateFare(double distance);

            public void GetVehicleDetails()
            {
                Console.WriteLine($"Vehicle ID: {vehicleId}");
                Console.WriteLine($"Driver Name: {driverName}");
                Console.WriteLine($"Rate Per Km: {ratePerKm}");
            }
        }

        public class RideCar : RideVehicle, IRideGPS
        {
            private string currentLocation;

            public RideCar(int vehicleId, string driverName, double ratePerKm, string currentLocation) : base(vehicleId, driverName, ratePerKm)
            {
                this.currentLocation = currentLocation;
            }

            public override double CalculateFare(double distance)
            {
                return (RatePerKm * distance) + 50;
            }

            public void GetCurrentLocation()
            {
                Console.WriteLine($"Current Location: {currentLocation}");
            }

            public void UpdateLocation(string location)
            {
                currentLocation = location;
            }
        }

        public class RideBike : RideVehicle, IRideGPS
        {
            private string currentLocation;

            public RideBike(int vehicleId, string driverName, double ratePerKm, string currentLocation) : base(vehicleId, driverName, ratePerKm)
            {
                this.currentLocation = currentLocation;
            }

            public override double CalculateFare(double distance)
            {
                return (RatePerKm * distance) + 20;
            }

            public void GetCurrentLocation()
            {
                Console.WriteLine($"Current Location: {currentLocation}");
            }

            public void UpdateLocation(string location)
            {
                currentLocation = location;
            }
        }

        public class RideAuto : RideVehicle, IRideGPS
        {
            private string currentLocation;

            public RideAuto(int vehicleId, string driverName, double ratePerKm, string currentLocation) : base(vehicleId, driverName, ratePerKm)
            {
                this.currentLocation = currentLocation;
            }

            public override double CalculateFare(double distance)
            {
                return (RatePerKm * distance) + 30;
            }

            public void GetCurrentLocation()
            {
                Console.WriteLine($"Current Location: {currentLocation}");
            }

            public void UpdateLocation(string location)
            {
                currentLocation = location;
            }
        }

}

