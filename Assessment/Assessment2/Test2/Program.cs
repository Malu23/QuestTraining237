using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Repository; 
using Types; 

namespace Test2
{
    internal class Program
    {
        private static void CreateTables()
        {
            var createTableQuery = @"
                CREATE TABLE Patients
                (
                    Id INTEGER PRIMARY KEY IDENTITY,
                    Name VARCHAR(100) NOT NULL,
                    Age INTEGER NOT NULL,
                    Gender VARCHAR(10),
                    MedicalCondition VARCHAR(200)
                );

                CREATE TABLE Doctors
                (
                    Id INTEGER PRIMARY KEY IDENTITY,
                    Name VARCHAR(100) NOT NULL,
                    Specialization VARCHAR(100) NOT NULL,
                    PatientId INTEGER,
                    FOREIGN KEY (PatientId) REFERENCES Patients(Id)
                );";

            using (var conn = new SqlConnection("Server=myServer; Database=myDb; Integrated Security=True;"))
            {
                conn.Open();
                var command = new SqlCommand(createTableQuery, conn);
                command.ExecuteNonQuery();
            }
        }

        private static void Main(string[] args)
        {
            CreateTables();

            var patientRepository = new PatientRepository();
            var doctorRepository = new DoctorRepository();

            patientRepository.Add(new Patient { Name = "John Doe", Age = 22, Gender = Gender.Male, MedicalCondition = "Cold" });
            patientRepository.Add(new Patient { Name = "Jane Doe", Age = 23, Gender = Gender.Female, MedicalCondition = "Fever" });
            doctorRepository.Add(new Doctor { Name = "Dr. Tom", Specialization = "Cardiologist" });
            doctorRepository.Add(new Doctor { Name = "Dr. Jerry", Specialization = "General", PatientId = 2 });

            Console.WriteLine("Patients:");
            patientRepository.GetAll();
            Console.WriteLine("\nDoctors:");
            doctorRepository.GetAll();

            patientRepository.Update(1, new Patient { MedicalCondition = "Stomachache" });
            doctorRepository.Update(1, new Doctor { Specialization = "Gastroenterologist" });

            patientRepository.Delete(1);
            doctorRepository.Delete(1);
        }
    }
}