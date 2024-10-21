using System;
using System.Text;
using System.Linq;
using ExtensionMethods;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main()
        {
            string sentence = "hello world! welcome to extension methods.";
            string titleCase = sentence.TitleCase(); 

            Console.WriteLine("Original Sentence: " + sentence);
            Console.WriteLine("Title Case Sentence: " + titleCase);

            int num = 4;

            Console.WriteLine($"{num} is even: {num.IsEven()}"); 
            Console.WriteLine($"{num} is odd: {num.IsOdd()}");  

            
        }
    }
}
