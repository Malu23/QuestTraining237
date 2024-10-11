using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day9_111024
{
    internal class ProgramDay1
    {
        static List<Dictionary<string, string>> patients = new List<Dictionary<string, string>>();

        static void AddPatient()
        {
            var patient = new Dictionary<string, string>();

            Console.WriteLine("Enter patient name:");
            patient.Add("name", Console.ReadLine());

            Console.WriteLine("Enter the patient age:");
            patient.Add("age", Console.ReadLine());

            Console.WriteLine("Enter the symptoms as comma-separated values:");
            patient.Add("symptoms", Console.ReadLine());

            // Generating unique ID for the patient.
            var id = Guid.NewGuid().ToString();
            patient.Add("id", id);
            patients.Add(patient);

            Console.WriteLine($"Patinet added successfully: {id}");
        }

        static void GetPatientById()
        {
            Console.WriteLine("Enter the patient ID:");
            var id = Console.ReadLine();

            foreach (var patient in patients)
            {
                if (patient["id"] == id) 
                {
                    Console.WriteLine("Name: " + patient["name"]);
                    Console.WriteLine("Age: " + patient["age"]);
                    Console.WriteLine("Symptoms: " + patient["symptoms"]);
                    break;
                }
                else
                {
                    Console.WriteLine("Patient not found.");
                }
            }
        }

        static void GetPatientsBySymptom()
        {
            Console.WriteLine("Enter the symptom to search for:");
            string symptom = Console.ReadLine();
            bool symptomFound = false; 

            foreach (var patient in patients)
            {
                string[] symptomsArray = patient["symptoms"].Split(',');

                foreach (var s in symptomsArray)
                {
                    if (s.Trim().Equals(symptom, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("ID: " + patient["id"]);
                        Console.WriteLine("Name: " + patient["name"]);
                        Console.WriteLine("Age: " + patient["age"]);
                        symptomFound = true; 
                        break; 
                    }
                }
            }

            if (!symptomFound)
            {
                Console.WriteLine("No patients found with that symptom.");
            }
        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Search Patient by ID");
                Console.WriteLine("3. Search Patient by symptoms");
                Console.WriteLine("4. Exit");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        GetPatientById();
                        break;
                    case "3":
                        GetPatientsBySymptom();
                        break;
                    case "4":
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid case");
                        break;
                }

            }

        }

    }
}

