using System;
namespace Works
{
    public abstract class Person
    {
        public abstract void Work();
    }

    public class Doctor : Person
    {
        public override void Work()
        {
            Console.WriteLine("The doctor treats patients.");
        }
    }

    public class Engineer : Person
    {
        public override void Work()
        {
            Console.WriteLine("The engineer builds structures or systems.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myDoctor = new Doctor();
            myDoctor.Work();  

            Person myEngineer = new Engineer();
            myEngineer.Work();  
        }
    }

}
    