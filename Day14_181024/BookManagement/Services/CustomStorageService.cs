using System;
using BookManagement.Entities;

namespace BookManagement.Services
{
    internal class CustomStorageService : IStorageService
    {
        public void Delete(string id) => throw new NotImplementedException();
        public Book GetById(string id) => throw new NotImplementedException();
        public void Save(Book book) => throw new NotImplementedException();
        public Book Search(string name) => throw new NotImplementedException();
    }
}
