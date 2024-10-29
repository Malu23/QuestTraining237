// A client should never be forced to implement an interface that it doesn’t use, or clients shouldn’t be forced to depend on methods they do not use.

using System;

public Interface IPrinter
{
    void Print();
}

public Interface IScanner
{
    void Scan();
}

public Interface IFax
{
    void Fax();
}

public class Printer : IPrinter, IScanner
{
    public void Print()
    {
        System.Console.WriteLine("Printing...");
    }
    
    public void Scan()
    {
        System.Console.WriteLine("Scanning...");
    }
}

