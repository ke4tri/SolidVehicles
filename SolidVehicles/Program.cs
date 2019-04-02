using System;
using System.Linq;
using System.Collections.Generic;
using SolidVehicles;

// IVehicle will be all things that ALL vehicles have in common
public interface IVehicle
{
    string Name { get; set; }
    string Type { get; set; }
    int PassengerCapacity { get; set; }
    bool Winged { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    
    void Start();
    void Stop();
}


public interface IWaterVehicle : IVehicle
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

        //Collection of all vehicles
        List<IVehicle> Vehicles = new List<IVehicle>() ;
        Vehicles.Add(new Piper());
        Vehicles.Add(new Cessna());
        Vehicles.Add(new Boat());
        Vehicles.Add(new JetSki());
        Vehicles.Add(new Motorcycle());
        Vehicles.Add(new Car());

        Console.WriteLine("These are the all vehicles: ");
        Console.WriteLine("-------------------------------------- ");

        foreach (IVehicle vehicle in Vehicles)
        {
            Console.WriteLine($"Name of vehicle : {vehicle.Name}");
            Console.WriteLine($"Name of vehicle : {vehicle.Type}");
            Console.WriteLine($"Passenger Capacity : {vehicle.PassengerCapacity}");
            Console.WriteLine($"Engine Volume : {vehicle.EngineVolume}");
            Console.WriteLine(" ");
        }

        // Build a collection of all vehicles that fly
        List<IFly> FlyVehicles = new List<IFly>();
        FlyVehicles.Add(new Piper());
        FlyVehicles.Add(new Cessna());

        Console.WriteLine("-------------------------------------- ");
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
        List<ILand> RoadVehicles = new List<ILand>();
        RoadVehicles.Add(new Car());
        RoadVehicles.Add(new Motorcycle());
        // With a single `foreach`, have each road vehicle Drive()
        Console.WriteLine("-------------------------------------- ");

        Console.WriteLine("These are the vehicles that are for land: ");
        foreach (IVehicle road in RoadVehicles)
        {
            Console.WriteLine($"Name of Aircraft : {road.Name}");
            Console.WriteLine($"Passenger Capacity : {road.PassengerCapacity}");
            Console.WriteLine($"Engine Volume : {road.EngineVolume}");
            Console.WriteLine(" ");
        }


        // Build a collection of all vehicles that operate on water
        List<IWaterVehicle> WaterVehicles = new List<IWaterVehicle>() { };
        //IEnumerable<JetSki> jetSkin = new IEnumerable<JetSki>();
        WaterVehicles.Add(new JetSki()
        { /* 
            You could leave all the values blank in JetSki and then
            place their values here like
            Name = "Good",
            Type = "Plane"
      */});

        WaterVehicles.Add(new Boat());
        // With a single `foreach`, have each water vehicle Drive()
        Console.WriteLine("-------------------------------------- ");

        Console.WriteLine("These are the vehicles that are for Water: ");
        foreach (var waterVehicle in WaterVehicles)
        {
            Console.WriteLine($"Name of Aircraft : {waterVehicle.Name}");
            Console.WriteLine($"Passenger Capacity : {waterVehicle.PassengerCapacity}");
            Console.WriteLine($"Engine Volume : {waterVehicle.EngineVolume}");
            Console.WriteLine($" ");
        }

        Console.ReadLine();

    }
}