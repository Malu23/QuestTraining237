using System;
using BookManagement.Entities.Types;

namespace BookManagement.Entities
{
    internal class Book
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public GenreType Genre { get; set; }

        public override string ToString()
        {
            return $"{Name} by {Author}, {Pages} pages, Genre: {Genre}";
        }
    }
}
