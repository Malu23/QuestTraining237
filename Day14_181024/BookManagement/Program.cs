using System;
using BookManagement.Services;

namespace BookManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storageService = new JsonFileStorage();
            var bookManager = new BookManager(storageService);
            bookManager.Run();
        }
    }
}
