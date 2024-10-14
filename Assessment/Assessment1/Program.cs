using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    class Program
    {
        // This is a dictionary of lists, to store departments and it's list of doctors.
        static Dictionary<string, List<string>> departments = new Dictionary<string, List<string>>();

        // This is a dictionary of lists, to store doctors and their list of patients with admitted status.
        static Dictionary<string, Dictionary<string, bool>> doctors = new Dictionary<string, Dictionary<string, bool>>();

        static void AddDepartment()
        {
            Console.WriteLine("Enter the department name: ");
            var dept_name = Console.ReadLine();

            if (!departments.ContainsKey(dept_name))
            {
                departments[dept_name] = new List<string>();
                Console.WriteLine($"The department {dept_name} is added successfully.");
            }
            else
            {
                Console.WriteLine("This department already exists.");
            }
        }

        static void AddDoctor()
        {
            Console.WriteLine("Enter department name: ");
            var dept_name = Console.ReadLine();

            if (departments.ContainsKey(dept_name))
            {
                Console.WriteLine("Enter doctor name: ");
                var doc_name = Console.ReadLine();

                if (!doctors.ContainsKey(doc_name))
                {
                    departments[dept_name].Add(doc_name);
                    doctors[doc_name] = new Dictionary<string, bool>(); 
                    Console.WriteLine($"Dr.{doc_name} is added to the department {dept_name}.");
                }
                else
                {
                    Console.WriteLine("This doctor already exists.");
                }
            }
            else
            {
                Console.WriteLine("This department was not found.");
            }
        }

        static void AdmitPatient()
        {
            Console.WriteLine("Enter doctor name:");
            var doc_name = Console.ReadLine();

            if (doctors.ContainsKey(doc_name))
            {
                Console.WriteLine("Enter patient name:");
                var patient_name = Console.ReadLine();

                if (!doctors[doc_name].ContainsKey(patient_name))
                {
                    doctors[doc_name][patient_name] = true; 
                    Console.WriteLine($"The patient {patient_name} has been admitted to Dr.{doc_name}.");
                }
                else
                {
                    Console.WriteLine("This patient is already admitted to the doctor.");
                }
            }
            else
            {
                Console.WriteLine("This doctor was not found.");
            }
        }

        static void GetDoctorsByDepartment()
        {
            Console.WriteLine("Enter department name: ");
            var dept_name = Console.ReadLine();

            if (departments.ContainsKey(dept_name))
            {
                Console.WriteLine($"The doctors in {dept_name} are: ");
                foreach (var doctor in departments[dept_name])
                {
                    Console.WriteLine(doctor);
                }
            }
            else
            {
                Console.WriteLine("This department was not found.");
            }
        }

        static void GetPatientsByDoctor()
        {
            Console.WriteLine("Enter doctor name: ");
            var doc_name = Console.ReadLine();

            if (doctors.ContainsKey(doc_name))
            {
                Console.WriteLine($"The patients of Dr.{doc_name} are: ");
                foreach (var patient in doctors[doc_name])
                {
                    Console.WriteLine($"{patient.Key} ,Admitted: {patient.Value}");
                }
            }
            else
            {
                Console.WriteLine("This doctor was not found.");
            }
        }

        static void DischargePatient()
        {
            Console.WriteLine("Enter doctor name:");
            var doc_name = Console.ReadLine();

            if (doctors.ContainsKey(doc_name))
            {
                Console.WriteLine("Enter patient name: ");
                var patient_name = Console.ReadLine();

                if (doctors[doc_name].ContainsKey(patient_name))
                {
                    doctors[doc_name].Remove(patient_name); 
                    Console.WriteLine($"The patient {patient_name} has been discharged from Dr.{doc_name}.");
                }
                else
                {
                    Console.WriteLine($"This patient is not a patient of Dr.{doc_name}.");
                }
            }
            else
            {
                Console.WriteLine("This doctor was not found.");
            }
        }
          
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add a Department");
                Console.WriteLine("2. Add a Doctor");
                Console.WriteLine("3. Admit a Patient");
                Console.WriteLine("4. Get Doctors with Department");
                Console.WriteLine("5. Get Patients with Doctor");
                Console.WriteLine("6. Discharge a Patient");
                Console.WriteLine("7. Exit");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddDepartment();
                        break;
                    case "2":
                        AddDoctor();
                        break;
                    case "3":
                        AdmitPatient();
                        break;
                    case "4":
                        GetDoctorsByDepartment();
                        break;
                    case "5":
                        GetPatientsByDoctor();
                        break;
                    case "6":
                        DischargePatient();
                        break;
                    case "7":
                        Console.WriteLine("Exiting the program!!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }

}

