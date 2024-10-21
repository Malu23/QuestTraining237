using System;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public static class IntegerExtensionMethods
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0; // Returns true if the number is even
        }

        public static bool IsOdd(this int number)
        {
            return number % 2 != 0; // Returns true if the number is odd
        }
    }
}