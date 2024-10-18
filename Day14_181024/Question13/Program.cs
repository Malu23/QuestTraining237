using System;

namespace Appliances
{
    public abstract class Appliance
    {
        public abstract void TurnOn();
    }

    public class Fan : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("The fan is now ON.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Appliance myFan = new Fan();

            myFan.TurnOn();  
        }
    }
}