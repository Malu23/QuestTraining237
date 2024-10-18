using System;

namespace AnimalSound
{
    public class Animal
    {
            public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound.");
        }
    }    

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            
            myDog.MakeSound();  
        }
    }
}