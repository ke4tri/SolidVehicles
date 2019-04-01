using System;
using System.Collections.Generic;
using System.Text;

namespace SolidVehicles
{
    
        public class Cessna : IVehicle, IFly
        {
        // Below are auto-implemented property because they have values
            public string Name { get; set; } = "Cessna";
            public string Type { get; set; } = "Plane";
            public int Wheels { get; set; } = 3;
            public int Doors { get; set; } = 3;
            public int PassengerCapacity { get; set; } = 113;
            public bool Winged { get; set; } = true;
            public string TransmissionType { get; set; } = "None";
            public double EngineVolume { get; set; } = 31.1;
            public double MaxAirSpeed { get; set; } = 309.0;


        //public Cessna()
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
