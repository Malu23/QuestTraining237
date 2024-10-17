using System;
using System.Collections.Generic;
using System.IO;

namespace FileHandling
{
    internal class Program
    {
        static void Main()
        {
            var path1 = @"/Users/malu/Documents/presentation1 final.pdf";
            
            // if(Directory.Exists(path))
            // {
            //     System.Console.WriteLine("Directory exists");
            // }
            // else
            // {
            //     System.Console.WriteLine("DoesNotExist");
            // }

            // var path2 = @"/Users/malu/Documents/TestDirectory";
            // Directory.CreateDirectory(path);
            // Directory.Delete(path);
            // Directory.Delete(path, true);

            var fileName = "data.txt";
            var filePath = Path.Combine(path2, fileName);
            Directory.CreateDirectory(path2);
            File.Create(filePath);
            File.Delete(filePath);
            File.WriteAllText(filePath, "Old text from code");
            File.WriteAllText(filePath, "Old text from code"); // Overwrites in file
            File.AppendAllText(filePath, "Add text from code"); //Adds to existing content

            var content = File.ReadAllText(filePath);
            System.Console.WriteLine(content);

            string[] contentLines = File.ReadAllLines(filePath);

        }
    }
}