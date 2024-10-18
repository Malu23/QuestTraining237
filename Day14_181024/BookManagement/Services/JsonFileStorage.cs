using System;
using System.IO;
using BookManagement.Entities;
using Newtonsoft.Json;

namespace BookManagement.Services
{
    class JsonFileStorage : IStorageService
    {
        private readonly string _storageDirectory;
        public JsonFileStorage()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _storageDirectory = Path.Combine(documentsPath, "BookManagement", "JsonData");
            Directory.CreateDirectory(_storageDirectory);
        }

        public void Delete(string id)
        {
            var filePath = Path.Combine(_storageDirectory, $"{id}.json");
            File.Delete(filePath);
        }

        public Book GetById(string id)
        {
            return default;
        }

        public void Save(Book book)
        {
            var jsonText = JsonConvert.SerializeObject(book);
            var filePath = Path.Combine(_storageDirectory, $"{book.Id}.json");
            File.WriteAllText(filePath, jsonText);
        }

        public Book Search(string name)
        {
            var files = Directory.GetFiles(_storageDirectory);
            foreach (var file in files)
            {
                var fileContentJson = File.ReadAllText(file);
                Book book = JsonConvert.DeserializeObject<Book>(fileContentJson);

                var bookName = book.Name.ToLowerInvariant();
                var nameToSearch = name.ToLowerInvariant();

                if (bookName.Contains(nameToSearch))
                {
                    return book;
                }
            }
            return null;
        }
    }
}
