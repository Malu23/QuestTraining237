// Every subclass or derived class should be substitutable for their base or parent class.

using System;

interface IFlyable
{
    void Fly();
}

public class Bird
{
    public string Name { get; set; }
}

class Pigeon : Bird, IFlyable
{
    public void Fly() => Console.WriteLine("Pigeon is flying");
}

class Penguin : Bird
{
    
}