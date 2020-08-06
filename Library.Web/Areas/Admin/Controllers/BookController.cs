using System;
using System.Linq;
using System.Linq.Expressions;
using Library.Core.Entities;
using Library.Core.Repositories;
using Library.Web.Areas.Admin.ViewModels;
using Library.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BookController : Controller
    {
        private readonly IUnitOfWork _uow;

        public BookController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [Route("[area]/[controller]/[action]")]
        public IActionResult List(BookListViewModel model)
        {
            model.Publishers = _uow.PublisherRepository.List();

            Expression<Func<Book, bool>> filter = null;
            if (Guid.TryParse(model.PublisherId, out var publisherId))
                filter = x => x.PublisherId == publisherId;
            else if (model.PublisherId == "None") filter = x => x.PublisherId == null;

            model.Books = _uow.BookRepository.List(filter);
            return View(model);
        }

        [HttpGet("[area]/[controller]/[action]/{id:guid}")]
        public IActionResult Edit(Guid id)
        {
            var book = _uow.BookRepository.Find(id);
            if (book == null) return NotFound();

            var model = new BookEditModel
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                PublishingDate = book.PublishingDate,
                Rating = book.Rating,
                CoverUrl = book.CoverUrl,
                PublisherId = book.PublisherId,
                Publishers = _uow.PublisherRepository.List().ToList()
            };

            return View(model);
        }

        [HttpPost("[area]/[controller]/[action]/{id:guid}")]
        public IActionResult Edit(BookEditModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Publishers = _uow.PublisherRepository.List().ToList();
                return View(model);
            }

            var book = _uow.BookRepository.Find(model.Id);
            if (book == null) return NotFound();

            book.Title = model.Title;
            book.PublisherId = model.PublisherId;
            book.Description = string.IsNullOrWhiteSpace(model.Description) ? null : model.Description;
            book.PublishingDate = model.PublishingDate;
            book.Rating = model.Rating;
            book.CoverUrl = model.CoverUrl;

            _uow.Commit();
            return RedirectToAction("List");
        }

        [HttpPost("[area]/[controller]/[action]")]
        public IActionResult Delete(Guid id)
        {
            var book = _uow.BookRepository.Find(id);
            if (book == null) return NotFound();

            _uow.BookRepository.Remove(book);
            _uow.Commit();

            return RedirectToAction("List");
        }

        [HttpGet("[area]/[controller]/[action]")]
        public IActionResult Add()
        {
            var model = new BookEditModel
            {
                Publishers = _uow.PublisherRepository.List().ToList()
            };

            return View(model);
        }

        [HttpPost("[area]/[controller]/[action]")]
        public IActionResult Add(BookEditModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Publishers = _uow.PublisherRepository.List().ToList();
                return View(model);
            }

            var book = new Book
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                PublisherId = model.PublisherId,
                Description = string.IsNullOrWhiteSpace(model.Description) ? null : model.Description,
                PublishingDate = model.PublishingDate,
                Rating = model.Rating,
                CoverUrl = model.CoverUrl
            };

            _uow.BookRepository.Add(book);
            _uow.Commit();
            return RedirectToAction("List");
        }

        [HttpGet("[area]/[controller]/[action]/{id:guid}")]
        public IActionResult Authors(Guid id)
        {
            var book = _uow.BookRepository.Find(id);
            if (book == null) return NotFound();

            var authors = _uow.AuthorRepository.List();

            var model = new BookAuthorsModel
                {Id = book.Id, BookTitle = book.Title, Authors = book.BookAuthor.Select(x => x.Author)};
            model.PotentialAuthors = authors.Except(model.Authors);

            return View(model);
        }

        [HttpPost("[area]/[controller]/[action]/{id:guid}")]
        public IActionResult AddAuthor(Guid id, Guid authorId)
        {
            var bookAuthor = _uow.BookAuthorRepository.Find(id, authorId);
            if (bookAuthor != null) return RedirectToAction("Authors", new {id});

            var book = _uow.BookRepository.Find(id);
            if (book == null) return NotFound();

            var author = _uow.AuthorRepository.Find(authorId);
            if (author == null) return NotFound();

            bookAuthor = new BookAuthor {BookId = id, AuthorId = authorId};
            _uow.BookAuthorRepository.Add(bookAuthor);
            _uow.Commit();

            return RedirectToAction("Authors", new {id});
        }

        [HttpPost("[area]/[controller]/[action]/{id:guid}")]
        public IActionResult RemoveAuthor(Guid id, Guid authorId)
        {
            var bookAuthor = _uow.BookAuthorRepository.Find(id, authorId);
            if (bookAuthor != null)
            {
                _uow.BookAuthorRepository.Remove(bookAuthor);
                _uow.Commit();
            }

            return RedirectToAction("Authors", new {id});
        }
    }
}