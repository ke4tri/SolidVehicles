using System;
using System.Linq;
using System.Collections.Generic;
using SolidVehicles;

// IVehicle will be all things that ALL vehicles have in common
public interface IVehicle
{
    string Name { get; set; }
    int PassengerCapacity { get; set; }
    bool Winged { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    
    void Start();
    void Stop();
}



public interface IJetSki
{
    string Name { get; set; }
    double MaxWaterSpeed { get; set; }
}

public interface ILand
{
    string Name { get; set; }
    int Wheels { get; set; }
    int Doors { get; set; }
    double MaxLandSpeed { get; set; }
    double EngineVolume { get; set; }
    void Drive();
}

public interface IFly 
{
    string Name { get; set; }
    int Wheels { get; set; }
    int Doors { get; set; }
    double MaxAirSpeed { get; set; }

    void Fly();
}



public class Program
{
    public static void Main()
    {
        //var newPlane = new Piper();
        //var newerPlane = new Cessna();
        //var FlyVehiclesDictionary = new Dictionary<string, List<string>> { };
        //FlyVehiclesDictionary.Add("Piper", newPlane);

        // Build a collection of all vehicles that fly
        List<IFly> FlyVehicles = new List<IFly>() {};
        FlyVehicles.Add(new Piper());
        FlyVehicles.Add(new Cessna());

        Console.WriteLine("These are the vehicles that fly: ");
        // With a single `foreach`, have each vehicle Fly()
        foreach (IVehicle plane in FlyVehicles)
        {
            Console.WriteLine($"Name of Aircraft : {plane.Name}");
            Console.WriteLine($"Passenger Capacity : {plane.PassengerCapacity}");
            Console.WriteLine($"Engine Volume : {plane.EngineVolume}");
            Console.WriteLine(" ");
        }



        // Build a collection of all vehicles that operate on roads
        List<ILand> RoadVehicles = new List<ILand>() { };
        RoadVehicles.Add(new Car());
        RoadVehicles.Add(new Motorcycle());
        // With a single `foreach`, have each road vehicle Drive()
        Console.WriteLine("These are the vehicles that are for land: ");
        foreach (IVehicle road in RoadVehicles)
        {
            Console.WriteLine($"Name of Aircraft : {road.Name}");
            Console.WriteLine($"Passenger Capacity : {road.PassengerCapacity}");
            Console.WriteLine($"Engine Volume : {road.EngineVolume}");
            Console.WriteLine(" ");
        }


        // Build a collection of all vehicles that operate on water

        // With a single `foreach`, have each water vehicle Drive()
        Console.ReadLine();

    }
}