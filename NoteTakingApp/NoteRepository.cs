using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace NoteTakingApp
{
    public class NoteRepository: INoteRepository
    {
        private const string connStr = "Server=myServer; Database=NoteTakingApp; Integrated Security=True;";

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }

        public void Add(Note note)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var insertQuery = @"INSERT INTO Notes (Title, Content, CreatedAt) 
                                    VALUES (@title, @content, @createdAt); ";
                
                var command  = new SqlCommand(insertQuery, conn);
                command.Parameters.AddWithValue("@title", note.Title);
                command.Parameters.AddWithValue("@content", note.Content);
                command.Parameters.AddWithValue("@createdAt", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }

        public void GetAll()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var getAllNotesQuery = @"SELECT Id, Title, CreatedAt, Content FROM Notes; ";
                var command = new SqlCommand(getAllNotesQuery, conn);
                
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string title = reader.GetString(1);
                        DateTime createdAt = reader.GetDateTime(2);
                        string content = reader.GetString(3);

                        Console.WriteLine($"Id: {id}, Title: {title}, CreatedAt: {createdAt}, Content: {content}");
                    }
                }
            }
        }

        public void Update(int id, Note note)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var updateNoteQuery = @"UPDATE Notes 
                                       SET Title = @title, Content = @content, UpdatedAt = @updatedAt
                                       WHERE Id = @id; ";
                
                var command = new SqlCommand(updateNoteQuery, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@title", note.Title);
                command.Parameters.AddWithValue("@content", note.Content);
                command.Parameters.AddWithValue("@updatedAt", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var deleteNoteQuery = "DELETE FROM Notes WHERE Id = @id; ";
                var command = new SqlCommand(deleteNoteQuery, conn);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }            
        }

        public void Search(string searchTerm)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var searchQuery = @"SELECT Id, Title, CreatedAt, Content
                                FROM Notes WHERE Title LIKE @searchTerm OR Content LIKE @searchTerm; ";

                using (var command = new SqlCommand(searchQuery, conn))
                {
                    command.Parameters.AddWithValue("@searchTerm", searchTerm);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string title = reader.GetString(1);
                            DateTime createdAt = reader.GetDateTime(2);
                            string content = reader.GetString(3);

                            Console.WriteLine($"Id: {id}, Title: {title}, CreatedAt: {createdAt}, Content: {content}");
                        }
                    }
                }
            }
        }
    }
}