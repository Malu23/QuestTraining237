using BookManagement.Entities;

namespace BookManagement.Services
{
    internal interface IStorageService
    {
        void Save(Book book);

        Book GetById(string id);

        void Delete(string id);

        Book Search(string name);
    }
}
