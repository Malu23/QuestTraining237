namespace StaticKeyword
{
    // class Employee
    // {
    //     public string Name { get; set; }
    //     public static string CompanyName { get; set; }

    //     override public string ToString() => $"Name: {Name}, Company: {CompanyName}";
    // }

    // internal class Program
    // {
    //     static void Main()
    //     {
    //         Employee.CompanyName = "Old Name";
    //         var e1 = new Employee {Name = "E1" };
    //         var e2 = new Employee {Name = "E2" };

    //         System.Console.WriteLine(e1);
    //         System.Console.WriteLine(e2);

    //         Employee.CompanyName = "Old Name";
    //         System.Console.WriteLine(e1);
    //         System.Console.WriteLine(e2);
    //     }
    // }

    class AppSettings
    {
        // No setter means that value can't be changed.
        public static string Version { get;} = "1.0.0";
        // public static string Version => "1.0.0";  // Shorthand notation for no setter.
        public static string ProjectUrl => "httpsggshjbhudvc";
        public static string DefaultSearchEngine { get; set; } = "Google";
    }

    class AppSettings1
    {
        public const string Version = "1.2.3";
        // public const DateTime StartTime = DateTime.Now; //Error because this is a runtime value
    }

    internal class Program
    {
        static void Main()
        {
            // AppSettings.Version = "2.0.0"; // Error. You cannot change this value
            AppSettings.DefaultSearchEngine = "Bing"; // Chnaging value using class name
            System.Console.WriteLine(AppSettings.DefaultSearchEngine);
        }
    }
}