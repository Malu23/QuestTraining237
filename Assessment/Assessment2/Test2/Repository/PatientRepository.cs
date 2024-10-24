using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Types; 

namespace Test2
{
    public class PatientRepository : RepositoryBase
    {

        public override void Add(object obj)
        {
            var patient = (Patient)obj;
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var insertPatient =
                @"
                    INSERT INTO Patients (Name, Age, Gender, MedicalCondition) 
                    VALUES (@name, @age, @gender, @medicalCondition);
                ";

                var command = new SqlCommand(insertPatient, conn);

                command.Parameters.AddWithValue("@name", patient.Name);
                command.Parameters.AddWithValue("@age", patient.Age);
                command.Parameters.AddWithValue("@gender", patient.Gender.ToString());
                command.Parameters.AddWithValue("@medicalCondition", patient.MedicalCondition);
                command.ExecuteNonQuery();
            }
        }

        public override void GetAll()
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var readPatient = "SELECT id, name, age, gender, medicalCondition FROM Patients";
                var command = new SqlCommand(readPatient, conn);
                var reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1); 
                    int age = reader.GetInt32(2); 
                    string gender = reader.GetString(3); 
                    string medicalCondition = reader.GetString(4); 

                    Console.WriteLine($"Id: {id}, Name: {name}, Age: {age}, Gender: {gender}, Medical Condition: {medicalCondition}");
                }
                
            }
        }

         public override void Update(int id, object obj)
        {
            var patient = (Patient)obj;
            using(var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var updatePatient = @"
                    UPDATE Patients
                    SET MedicalCondition = @medicalCondition
                    WHERE Id = @id; ";

                var command = new SqlCommand(updatePatient, conn);
                command.Parameters.AddWithValue("@medicalCondition", patient.MedicalCondition);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

            }
        }

        public override void Delete(int id)
        {
            using(var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var deletePatient = @"
                DELETE Patients WHERE Id = @id; ";

                var command = new SqlCommand(deletePatient, conn);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

    }
}