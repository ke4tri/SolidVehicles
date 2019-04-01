using System;
using System.Linq;
using System.Collections.Generic;
using SolidVehicles;

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
        var newPlane = new Piper { };
        var newerPlane = new Cessna { };
        //var FlyVehiclesDictionary = new Dictionary<string, List<string>> { };
        //FlyVehiclesDictionary.Add("Piper", newPlane);

        // Build a collection of all vehicles that fly
        List<string> FlyVehicles = new List<string>() {};

        FlyVehicles.Add(newPlane.ToString());
        FlyVehicles.Add(newerPlane.ToString());
        // With a single `foreach`, have each vehicle Fly()
        foreach (var plane in FlyVehicles)
        {
            Console.WriteLine(plane);
            Console.ReadLine();
        }

        Console.ReadLine();
        
        // Build a collection of all vehicles that operate on roads

        // With a single `foreach`, have each road vehicle Drive()



        // Build a collection of all vehicles that operate on water

        // With a single `foreach`, have each water vehicle Drive()
    }
}