using CleanApi.Domain.Entities;

namespace CleanApi.Domain.Interfaces;

public interface IBookRepository
{
    IEnumerable<Book> GetAll();
    Book? GetById(int id);
    void Add(Book book);
}
