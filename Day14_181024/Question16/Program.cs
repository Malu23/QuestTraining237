using System;

namespace Employee
{
    public class Employee
    {
        public virtual double CalculateBonus(double salary)
        {
            return salary * 0.05;
        }
    }

    public class Manager : Employee
    {
        public override double CalculateBonus(double salary)
        {
            return salary * 0.20;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            double employeeSalary = 50000;
            Console.WriteLine($"Employee Bonus: {employee.CalculateBonus(employeeSalary)}");  

            Employee manager = new Manager();
            double managerSalary = 70000;
            Console.WriteLine($"Manager Bonus: {manager.CalculateBonus(managerSalary)}");  
        }
    }    
}