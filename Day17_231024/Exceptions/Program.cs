using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Exceptions
{
    class MyCustomException: Exception
    {
        public string Message { get; set; }

        public MyCustomException(string message)
        {
            Message = message;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     System.Console.WriteLine("Enter the numbers: ");
            //     int i = int.Parse(Console.ReadLine());
            //     int j = int.Parse(Console.ReadLine());

            //     System.Console.WriteLine(i / j);
            // }

            // catch(OverflowException)
            // {
            //     System.Console.WriteLine("Number too large.");
            // }

            // catch(DivideByZeroException)
            // {
            //     System.Console.WriteLine("Cannot divide by 0.");
            // }

            // catch(FormatException)
            // {
            //     System.Console.WriteLine("Please enter a valid number.");
            // }

            // catch(Exception e)
            // {
            //     System.Console.WriteLine(e.Message);
            //     System.Console.WriteLine(e.StackTrace);
            // }

            // finally
            // {
            //     System.Console.WriteLine("Finally");
            // }

            // try{
            //     System.Console.WriteLine("Enter the numbers: ");
            //     int i = int.Parse(Console.ReadLine());
            //     int j = int.Parse(Console.ReadLine());

            //     if(j == 0)
            //     {
            //         throw new DivideByZeroException("Second number should not be zero.");
            //         // throw new MyCustomException("Second umber should not be zero.");
            //     }

            //     System.Console.WriteLine(i + j);
            //     System.Console.WriteLine(i - j);
            //     System.Console.WriteLine(i * j);
            //     System.Console.WriteLine(i / j);
            // }

            // catch(Exception e)
            // {
            //     System.Console.WriteLine(e.Message);
            // }

            try
            {
                var conn = new Sqlconnection("");
                conn.Open();
            }

            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}