namespace EnumType
{
    // enum Days
    // {
    //     Monday,
    //     Tuesday
    // }
    internal class Program
    {
        public enum ConvertTo
            {
                UpperCase,
                LowerCase,
                Swapcase
            }

        public static void ConvertCasing(string input, ConvertTo targetType)
        {
            switch(targetType)
            {
                case ConvertTo.UpperCase:
                    Console.WriteLine(input.ToUpper());
                    break;
                case ConvertTo.LowerCase:
                    Console.WriteLine(input.ToLower());
                    break;
                case ConvertTo.Swapcase:
                    char[] swapped = new char[input.Length];
                    for (int i = 0; i < input.Length; i++)
                    {
                        char c = input[i];
                        if (char.IsUpper(c))
                            swapped[i] = char.ToLower(c);
                        else if (char.IsLower(c))
                            swapped[i] = char.ToUpper(c);
                        else
                            swapped[i] = c; // Non-alphabetic characters remain the same
                    }
                    Console.WriteLine(new string(swapped));
                    break;
            }
        }
        static void Main()
        {
            ConvertCasing("Hello", ConvertTo.LowerCase); // hello
            ConvertCasing("Hello", ConvertTo.UpperCase); // HELLO
            ConvertCasing("Hello", ConvertTo.Swapcase); // hELLO
        }
    }
}