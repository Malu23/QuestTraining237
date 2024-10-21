using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnLinq
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // // 1. Given a list of integers, return all the even numbers.
            // var data1 = new List<int> {1, 2, 45, 6, 79, 83};
            // var res1 = data1.Where(i => i % 2 == 0);
            // Console.WriteLine(string.Join(", ", res1));

            // // 2. From a list of strings, return those that start with the letter 'A'.
            // var data2 = new List<string> {"apple", "box", "America", "tulip"};
            // var res2 = data2.Where(i => i.StartsWith("A", StringComparison.OrdinalIgnoreCase) );
            // Console.WriteLine(string.Join(", ", res2));

            // // 3. Sort a list of integers in descending order.
            // var data3 = new List<int> {1, 2, 45, 6, 79, 83, 0};
            // var res3 = data3.OrderByDescending(x => x);
            // Console.WriteLine(string.Join(", ", res3));

            // // 4. From a list of integers, return the square of each integer.
            // var data4 = new List<int> {1, 2, 5, 6, 7, 8};
            // var res4 = data4.Select(i => i * i);
            // Console.WriteLine(string.Join(", ", res4));

            // // 5. From a list of integers, return the squares of only the even numbers.
            // var data5 = new List<int> {1, 2, 5, 6, 7, 8};
            // var res5 = data5.Where(x => x % 2 == 0).Select(i => i * i);
            // Console.WriteLine(string.Join(", ", res5));

            // // 6. From a list of strings, return the first string that starts with the letter 'B'. If none exists, return null.
            // var data6 = new List<string> {"apple", "box", "America", "tulip", "Ball"};
            // var res6 = data6.FirstOrDefault(s => s.StartsWith("B"));
            // Console.WriteLine(res6 ?? "null");

            // // 7. Given two lists, one containing students' names and the other their grades, return the names of students who scored more than 80.
            // var names = new List<string> {"John", "Jane", "Tom", "Jerry", "Emma"};
            // var grades = new List<int> {100, 92, 75, 60, 87};
            // var res7 = names.Zip(grades, (name, grade) => new { Name = name, Grade = grade })
            //                 .Where(x => x.Grade > 80)
            //                 .Select(x => x.Name);
            // Console.WriteLine(string.Join(", ", res7));

            // // 8. Group a list of words by their length.
            // var data8 = new List<string> {"apple", "box", "aim", "tulip", "ball"};
            // var groupByLength = data8.GroupBy(word => word.Length);
            // foreach (var group in groupByLength)
            // {
            //     Console.WriteLine($"Words with length {group.Key}: {string.Join(", ", group)}");
            // }

            // // 9. From a list of integers, return the maximum value.
            // var data9 = new List<int> {1, 2, 10, 6, 7, 8};
            // var max = data9.Max();
            // Console.WriteLine($"The maximum is: {max}");

            // // 10. From a list of integers, return the minimum value.
            // var data10 = new List<int> {1, 2, 10, 6, 7, 8};
            // var min = data10.Min();
            // Console.WriteLine($"The minimum is: {min}");

            // // 11. From a list of integers, check if any number is greater than 50.
            // var data11 = new List<int> {1, 23, 50, 61, 7, 98};
            // bool anyGreaterThanFifty = data11.Any(n => n > 50);

            // if (anyGreaterThanFifty)
            // {
            //     Console.WriteLine("There is at least one number greater than 50.");
            // }
            // else
            // {
            //     Console.WriteLine("No numbers are greater than 50.");
            // }

            // // 12. From a list of integers, check if all numbers are positive.
            // var data12 = new List<int> {1, -23, 50, 61, -7, 98};
            // bool allPositive = data12.All(n => n > 0);

            // if (allPositive)
            // {
            //     Console.WriteLine("All numbers are positive.");
            // }
            // else
            // {
            //     Console.WriteLine("Not all numbers are positive.");
            // }

            // // 13. Return the sum of all elements in a list of integers.
            // var data13 = new List<int> {1, 2, 5, 6, 7, 9};
            // var sum = data13.Sum();
            // Console.WriteLine($"The sum is: {sum}");

            // // 14. Return the average of a list of floating-point numbers.
            // var data14 = new List<double> {1.5, 2.3, 5.0, 6.1, 3.7, 9.8};
            // var average = data14.Average();
            // Console.WriteLine($"The average is: {average}");

            // // 15. From a list of integers with duplicates, return only the distinct numbers. 
            // var data15 = new List<int> {1, 23, 6, 23, 57, 6};
            // var res15 = data15.Distinct();
            // Console.WriteLine(string.Join(", ", res15));

            // // 16. From a list of integers, count how many elements are greater than 10.
            // var data16 = new List<int> {1, 23, 5, 61, 7, 9};
            // var countGreaterThanTen = data16.Count(x => x > 10);
            // Console.WriteLine($"The number of elements greater than 10 is: {countGreaterThanTen}");

            // 17. Given two lists, one of employees and one of departments, return a list of employees with their corresponding department names based on department IDs.
            // var employees = new List<Employee>()
            // {
            //     new Employee {Name = "Alice", DepartmentId = 1},
            //     new Employee {Name = "Bob", DepartmentId = 2},
            //     new Employee {Name = "Charlie", DepartmentId = 1},
            //     new Employee {Name = "David", DepartmentId = 3}
            // };

            // var departments = new List<Department>()
            // {
            //     new Department {Id = 1, Name = "HR"},
            //     new Department {Id = 2, Name = "Finance"},
            //     new Department {Id = 3, Name = "IT"}
            // };

            // var empWithDept = employees
            //         .Join(
            //             departments, 
            //             e => e.DepartmentId,
            //             d => d.Id,
            //             (e, d) => new
            //             {
            //                 EmployeeName = e.Name,
            //                 DepartmentName = d.Name
            //             }
            //         );

            // foreach(var item in empWithDept)
            // {
            //     Console.WriteLine(item.EmployeeName + " - " + item.DepartmentName);
            // }

            // // 18. From a list of products, return those with prices greater than $100, sorted in ascending order.
            // var products = new List<Product>
            // {
            //     new Product { Name = "Laptop", Price = 999.99 },
            //     new Product { Name = "Smartphone", Price = 79.99 },
            //     new Product { Name = "Charger", Price = 19.99 },
            //     new Product { Name = "Monitor", Price = 150.00 }
            // };

            // var res18 = products.Where(p => p.Price > 100).OrderBy(p => p.Price);

            // foreach (var product in res18)
            // {
            //     Console.WriteLine($"Product: {product.Name}, Price: {product.Price:C}");
            // }

            // // 19. From a list of integers, skip the first 5 elements and return the next 3 elements.
            // var data19 = new List<int> {1, 2, 5, 6, 7, 9, 4, 3, 10};
            // var res19 = data19.Skip(5).Take(3);
            // Console.WriteLine(string.Join(", ", res19));

            // // 20. Given two lists of the same length, combine corresponding elements into pairs.
            // var names = new List<string> {"Alice", "Bob", "Charlie"};
            // var age = new List<int> {8, 2, 7};

            // var pairs = names.Zip(age, (names, age) => new { Name = names, Age = age});

            // foreach (var pair in pairs)
            // {
            //     Console.WriteLine($"Name: {pair.Name}, Age: {pair.Age}");
            // }

        }
    }
}