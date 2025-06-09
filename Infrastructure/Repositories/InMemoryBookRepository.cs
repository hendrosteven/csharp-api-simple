using CleanApi.Domain.Entities;
using CleanApi.Domain.Interfaces;

namespace CleanApi.Infrastructure.Repositories;

public class InMemoryBookRepository : IBookRepository
{
    private readonly List<Book> _books = new();
    private int _idCounter = 1;

    public IEnumerable<Book> GetAll() => _books;

    public Book? GetById(int id) => _books.FirstOrDefault(b => b.Id == id);

    public void Add(Book book)
    {
        book.Id = _idCounter++;
        _books.Add(book);
    }
}
