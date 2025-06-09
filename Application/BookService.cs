using CleanApi.Domain.Entities;
using CleanApi.Domain.Interfaces;

namespace CleanApi.Application;

public class BookService
{
    private readonly IBookRepository _repo;

    public BookService(IBookRepository repo)
    {
        _repo = repo;
    }

    public IEnumerable<Book> GetAll() => _repo.GetAll();

    public Book? GetById(int id) => _repo.GetById(id);

    public void Add(Book book) => _repo.Add(book);
}
