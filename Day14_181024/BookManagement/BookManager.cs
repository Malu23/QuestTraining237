using System;
using BookManagement.Entities;
using BookManagement.Entities.Types;
using BookManagement.Services;

namespace BookManagement
{
    internal class BookManager
    {
        private readonly IStorageService _storageService;
        public BookManager(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public void Add()
        {
            var book = new Book();
            book.Id = Guid.NewGuid().ToString();

            Console.Write("Book Name: ");
            book.Name = Console.ReadLine();

            Console.Write("Author Name: ");
            book.Author = Console.ReadLine();

            Console.Write("Number of Pages: ");
            book.Pages = int.Parse(Console.ReadLine());

            Console.Write("Genre: 1. Fiction 2. NonFiction 3. Fantasy 4. Mystery 5. SciFi: ");
            var genreType = Console.ReadLine();
            book.Genre = genreType switch
            {
                "1" => GenreType.Fiction,
                "2" => GenreType.NonFiction,
                "3" => GenreType.Fantasy,
                "4" => GenreType.Mystery,
                "5" => GenreType.SciFi,
                _ => GenreType.Fiction
            };

            _storageService.Save(book);
        }

        public void Remove()
        {
            Console.Write("Enter the book id: ");
            var id = Console.ReadLine();
            _storageService.Delete(id);
        }

        public void Search()
        {
            Console.Write("Enter the name of the book: ");
            var name = Console.ReadLine();

            var book = _storageService.Search(name);
            if (book == null)
            {
                Console.WriteLine("Book not found");
                return;
            }

            Console.WriteLine(book);
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Delete Book");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Search();
                        break;
                    case "3":
                        Remove();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
