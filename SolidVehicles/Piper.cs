using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles
{
    public class Piper : IVehicle, IFly
    {
        // Below are auto-implemented property because they have values
        public string Name { get; set; } = "Piper";
        public string Type { get; set; } = "Plane";
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 44;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 35.1;

        public double MaxAirSpeed { get; set; } = 104.0;

        //public Piper()
        //{
        //    Name = Name;
        //    Wheels = Wheels;
        //    Doors = Doors;
        //    PassengerCapacity = PassengerCapacity;
        //    Winged = Winged;
        //    TransmissionType = TransmissionType;
        //    EngineVolume = EngineVolume;
        //    MaxAirSpeed = MaxAirSpeed;
        //}

        public void Fly()
        {
            Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
