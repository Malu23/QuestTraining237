using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;

namespace NoteTakingApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            CreateTable();
            INoteRepository noteRepository = new NoteRepository();
            
            while (true)
            {
                Console.WriteLine("Note-Taking Application");
                Console.WriteLine("1. Create a new note");
                Console.WriteLine("2. View all notes");
                Console.WriteLine("3. Update a note");
                Console.WriteLine("4. Delete a note");
                Console.WriteLine("5. Search notes");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                
                switch (Console.ReadLine())
                {
                    case "1":
                        CreateNote(noteRepository);
                        break;
                    case "2":
                        noteRepository.GetAll();
                        break;
                    case "3":
                        UpdateNote(noteRepository);
                        break;
                    case "4":
                        DeleteNote(noteRepository);
                        break;
                    case "5":
                        SearchNotes(noteRepository);
                        break;
                    case "6":
                        Console.WriteLine("Exiting..");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        private static void CreateNote(INoteRepository noteRepository)
        {
            Console.WriteLine("Enter note title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter note content: ");
            string content = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
            {
                Console.WriteLine("Title and content cannot be empty.");
                return;
            }

            var note = new Note
            {
                Title = title,
                Content = content,
                CreatedAt = DateTime.Now
            };

            noteRepository.Add(note);
            Console.WriteLine("Note created successfully.");
        }

        private static void DeleteNote(INoteRepository noteRepository)
        {
            Console.WriteLine("Enter note Id to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                noteRepository.Delete(id);
                Console.WriteLine("Note deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid id. Try again.");
            }
        }

        private static void UpdateNote(INoteRepository noteRepository)
        {
            Console.WriteLine("Enter note Id to update: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Enter new title: ");
                string title = Console.ReadLine();
                Console.WriteLine("Enter new content: ");
                string content = Console.ReadLine();

                var updatedNoted = new Note
                {
                    Title = title,
                    Content = content,
                };
                
                noteRepository.Update(id, updatedNoted);
                Console.WriteLine("Note updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid id. Try again.");
            }
        }
        
        private static void CreateTable()
        {
            var createTableQuery = @" CREATE TABLE Notes(
                                        Id INT PRIMARY KEY IDENTITY,
                                        Title VARCHAR(100) NOT NULL,
                                        Content VARCHAR(MAX) NOT NULL,
                                        CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
                                        UpdatedAt DATETIME
                                    ); ";

            using (var conn = new SqlConnection("Server=myServer; Database=NoteTakingApp; Integrated Security=True;"))
            {
                conn.Open();
                var command = new SqlCommand(createTableQuery, conn);
                command.ExecuteNonQuery();
            }
        }

        private static void SearchNotes(INoteRepository noteRepository)
        {
            Console.WriteLine("Enter title or content to search: ");
            string searchTerm = Console.ReadLine();
            noteRepository.Search(searchTerm);
        }
    }
}