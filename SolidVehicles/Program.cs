using System;
using System.Linq;
using System.Collections.Generic;

// IVehicle will be all things that ALL vehicles have in common
public interface IVehicle
{   
    int PassengerCapacity { get; set; }
    bool Winged { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    
    void Start();
    void Stop();
}



public interface IJetSki
{
    double MaxWaterSpeed { get; set; }
}

public interface ILand
{
    int Wheels { get; set; }
    int Doors { get; set; }
    double MaxLandSpeed { get; set; }
    double EngineVolume { get; set; }
    void Drive();
}

public interface IFly 
{
    int Wheels { get; set; }
    int Doors { get; set; }
    double MaxAirSpeed { get; set; }

    void Fly();
}





public class Program
{
    public static void Main()
    {

        // Build a collection of all vehicles that fly
        List<IVehicle> FlyVehicles = new List<IVehicle>(){
           new SolidVehicles.Piper(),
           new SolidVehicles.Cessna
           {
               Wheels = 2,
               Doors= 2,
               PassengerCapacity = 88,
               Winged  = true,
               TransmissionType = "None",
               EngineVolume  = 31.1,
               MaxAirSpeed  = 100.0,
           }

        };

        // With a single `foreach`, have each vehicle Fly()
        foreach (var plane in FlyVehicles) {
            Console.WriteLine(plane);
        }

        var newPlane = new SolidVehicles.Cessna();
        Console.WriteLine(newPlane.ToString());
        Console.ReadLine();
        


        


        // Build a collection of all vehicles that operate on roads

        // With a single `foreach`, have each road vehicle Drive()



        // Build a collection of all vehicles that operate on water

        // With a single `foreach`, have each water vehicle Drive()
    }
}