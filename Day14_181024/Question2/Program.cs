using System;

namespace Vehicle
{
    public abstract class Vehicle
    {
        public double speed { get; set; }
        public abstract void Drive();
     
    }

    public class Car: Vehicle
    {
        public Car(double speed)
        {
            this.speed = speed;
        }

        public override void Drive()
        {
            Console.WriteLine($"The speed of the car is {speed} km/h.");
        }
    }

    public class Bicycle : Vehicle
    {
        public Bicycle(int speed)
        {
            this.speed = speed;
        }
        public override void Drive()
        {
            Console.WriteLine($"The speed of the bicycle is {speed} km/h.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(80);
            car.Drive();

            Vehicle bicycle = new Bicycle(20);
            bicycle.Drive();
        }
    }
}