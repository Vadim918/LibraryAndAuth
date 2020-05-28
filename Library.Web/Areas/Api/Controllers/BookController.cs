using System;
using System.Collections.Generic;
using System.Linq;
using Library.Core.Entities;
using Library.Core.Repositories;
using Library.Web.Areas.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Areas.Api.Controllers
{
    [Area("Api")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public BookController(IUnitOfWork uow) => _uow = uow;

        [HttpGet("api/books")]
        public IEnumerable<BookModel> Get() => _uow.BookRepository.List().Select(Build);

        [HttpGet("api/books/{id:guid}")]
        public ActionResult<BookModel> Get(Guid id)
        {
            var book = _uow.BookRepository.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(Build(book));
        }

        private static BookModel Build(Book book)
        {
            var model = new BookModel
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                PublishingDate = book.PublishingDate,
                Rating = book.Rating,
                CoverUrl = book.CoverUrl,
                Publisher = book.Publisher,
                Authors = book.BookAuthor.Select(x => new AuthorModel {Id = x.Author.Id, Name = x.Author.ToString()})
                    .ToList()
            };

            return model;
        }
    }
}