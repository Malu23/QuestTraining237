using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Types; 

namespace Test2
{
    public class DoctorRepository : RepositoryBase
    {
        public override void Add(object obj)
        {
            var doctor = (Doctor)obj;
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var insertDoctor = @"
                    INSERT INTO Doctors (Name, Specialization, PatientId) 
                    VALUES (@name, @specialization, @patientId);
                ";

                var command = new SqlCommand(insertDoctor, conn);
                command.Parameters.AddWithValue("@name", doctor.Name);
                command.Parameters.AddWithValue("@specialization", doctor.Specialization);
                command.Parameters.AddWithValue("@patientId", doctor.PatientId);
                command.ExecuteNonQuery();
            }
        }

        public override void GetAll()
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var readDoctor = "SELECT Id, Name, Specialization, PatientId FROM Doctors";
                var command = new SqlCommand(readDoctor, conn);
                var reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    int id = reader.GetInt32(0); 
                    string name = reader.GetString(1); 
                    string specialization = reader.GetString(2); 
                    int? patientId = reader.GetInt32(3); // If null??
                    Console.WriteLine($"Id: {id}, Name: {name}, Specialization: {specialization}, PatientId: {patientId}");
                }
            }
        }

        public override void Update(int id, object obj)
        {
            var doctor = (Doctor)obj;
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var updateDoctor = @"
                    UPDATE Doctors
                    SET Specialization = @specialization
                    WHERE Id = @id; ";

                var command = new SqlCommand(updateDoctor, conn);
                command.Parameters.AddWithValue("@specialization", doctor.Specialization);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public override void Delete(int id)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var deleteDoctor = @"
                DELETE FROM Doctors WHERE Id = @id; ";

                var command = new SqlCommand(deleteDoctor, conn);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}