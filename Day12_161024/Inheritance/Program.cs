namespace Program
{
    // class A
    // {
    //     public string DataA { get; set; }
    //     public void MethodA() => System.Console.WriteLine("Method of A");
    // }
    // class B : A
    // {
    //     public string DataB { get; set; }
    //     public void MethodA()
    //     {
    //         base.MethodA(); //in Java it's super.MethodA();
    //         System.Console.WriteLine("This is also method A");
    //     }
    //     public void MethodB() => System.Console.WriteLine("Method of B");
    // }


    // internal class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         A a = new A();
    //         a.MethodA();

    //         B b = new B();
    //         b.MethodB();
    //         b.MethodA();
    //     }
    
    // }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void GetName()
        {
            System.Console.WriteLine("Enter Student Name : ");
            Name = Console.ReadLine(); 
        }

        public void GetEmail()
        {
            System.Console.WriteLine("Enter Student Email : ");
            Email = Console.ReadLine(); 
        }

        public void PrintDetails()
        {
            System.Console.WriteLine($"Name : {Name}");
            System.Console.WriteLine($"Email : {Email}");
        }
    }

    class CollegeStudent : Student
    {
        public string CollegeName { get; set; }

        public void College()
        {
            GetName(); 
            GetEmail();

            System.Console.WriteLine("Enter College Name : ");
            CollegeName = Console.ReadLine(); 

            PrintDetails(); 
            System.Console.WriteLine($"College Name : {CollegeName}");
        }
    }

    class SchoolStudent : Student
    {
        public string SchoolName { get; set; }

        public void School()
        {
            GetName(); 
            GetEmail();

            System.Console.WriteLine("Enter School Name : ");
            SchoolName = Console.ReadLine(); 

            PrintDetails();
            System.Console.WriteLine($"School Name : {SchoolName}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CollegeStudent a = new CollegeStudent();
            a.College();

            SchoolStudent b = new SchoolStudent();
            b.School();
        }
    }

}