using System;

namespace Shape
{
   public abstract class Shape
    {
        public abstract double Area();
    }

    public class Circle: Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return 3.14 * radius * radius;
        }
    }

    public class Rectangle: Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Shape c = new Circle(5);
            System.Console.WriteLine($"Area of circle: {c.Area()}");

            Shape r = new Rectangle(2,3);
            System.Console.WriteLine($"Area of rectangle: {r.Area()}");
        }
    }
}