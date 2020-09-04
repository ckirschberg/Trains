using System;

namespace Trains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PassengerTrain p1 = new PassengerTrain("Train1", 200);
            FreightTrain p2 = new FreightTrain("Bill the Strong", 10, 6000);
            PassengerTrain p3 = new PassengerTrain("Train2", 200);
            PassengerTrain p4 = new PassengerTrain("Train3", 200);
            PassengerTrain p5 = new PassengerTrain("Train4", 200);
            PassengerTrain p6 = new PassengerTrain("Mighty hauler", 200);
            TrainStation station = new TrainStation("Hellerup");

            Console.WriteLine(station.AddTrain(p1));
            Console.WriteLine(station.AddTrain(p2));
            Console.WriteLine(station.AddTrain(p3));
            Console.WriteLine(station.AddTrain(p4));
            Console.WriteLine(station.AddTrain(p5));
            Console.WriteLine(station.AddTrain(p6));

        }
    }
}
