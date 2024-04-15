using System;
class Program
{
    public static void Main(string[] args)
    {
        Transport car = new Car { Speed = 100, LoadCapacity = 500, DistanceRange = 1000 };
        Transport ship = new Ship { Speed = 50, LoadCapacity = 1000, DistanceRange = 2000 };
        Transport aircraft = new Aircraft { Speed = 500, LoadCapacity = 200, DistanceRange = 1500 };

        Console.WriteLine(car.GetDescription());
        Console.WriteLine(ship.GetDescription());
        Console.WriteLine(aircraft.GetDescription());
    }
}