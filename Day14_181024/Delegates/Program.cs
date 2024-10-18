using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        // delegate void MathDelegate(int a, int b);
        // delegate int MathDelegate2(int a, int b);

        // static void Add(int a, int b)
        // {
        //     System.Console.WriteLine(a + b);
        // }

        // static void Sub(int a, int b)
        // {
        //     System.Console.WriteLine(a - b);
        // }

        // static int Multiply(int a, int b)
        // {
        //     return (a * b);
        // }

        // static void Main(string[] args)
        // {
        //     MathDelegate del = Add;
        //     del += Sub;

        //     del(1, 2);

        //     del -= Sub;
        //     del(1, 2);

        //     MathDelegate2 del2 = Multiply;
        //     var res = del2(1, 2);
        //     System.Console.WriteLine(res);
        // }



        // delegate void TaskDelegate();

        // static void StartTimer(int seconds, TaskDelegate task)
        // {
        //     System.Console.WriteLine("Timer started");
        //     Thread.Sleep(seconds + 1000);
        //     task();
        // }

        // static void Greet() => System.Console.WriteLine("Hello");
        // static void GreetWithMessage(string message) => System.Console.WriteLine(message);

        // static void Add(int a, int b) => System.Console.WriteLine(a + b);
        // static void Main()
        // {
        //     Action g = Greet;
        //     Action<string> gm = GreetWithMessage;

        //     Action<int, int> a = Add;

        //     g();
        //     gm("Hey");
        //     a(1, 2);
        // }

        // static int GetNumber() => 10;
        // static string Add(int a, int b) => (a + b).ToString();

        // static void Main()
        // {
        //     // no parameters return type just given
        //     Func<int> gn = GetNumber;
        //     // else return type at the end
        //     Func<int, int, string> a = Add;

        //     var res = gn();
        //     var res2 = a(1, 3);
        //     System.Console.WriteLine(res);
        //     System.Console.WriteLine(res2);
        // }

        // static bool IsEven(int n) => n % 2 == 0;

        // static void Main(string[] args)
        // {
        //     Func<int, bool> a = IsEven;
        //     Predicate<int> b =IsEven;

        //     var res = a(1);
        //     var res2 = b(2);
        //     System.Console.WriteLine(res);
        //     System.Console.WriteLine(res2);
        // }

        // static bool IsEven(int value) => value % 2 == 0;
        // static bool IsNegative(int value) => value < 0;

        // static void CheckData(int data, Predicate<int> predicate)
        // {
        //     if(predicate(data))
        //     {
        //         System.Console.WriteLine("Check passed");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Check failed");
        //     }
        // }

        // static void Main()
        // {
        //     Predicate<int> e = IsEven;
        //     Predicate<int> n = IsNegative;

        //     CheckData(5, e); 
        //     CheckData(-5, n); 
        // }
        static void GetDatabasedOnTheCondition(int[] data, Predicate<int> predicate)
        {
            var result = new List<int>();

            foreach(var item in data)
            {
                if(predicate(item))
                {
                    result.Add(item);
                }
            }
            System.Console.WriteLine(string.Join(", ", result));
        }


        static void Main()
        {
            var data = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, -3, -5};
            GetDatabasedOnTheCondition(data, i => i % 2 == 0);
            GetDatabasedOnTheCondition(data, x => x < 0);
        }
    }
}
