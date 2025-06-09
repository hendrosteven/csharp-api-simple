using CleanApi.Application;
using CleanApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CleanApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly BookService _service;

    public BooksController(BookService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var book = _service.GetById(id);
        return book is not null ? Ok(book) : NotFound();
    }

    [HttpPost]
    public IActionResult Create(Book book)
    {
        _service.Add(book);
        return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
    }
}
