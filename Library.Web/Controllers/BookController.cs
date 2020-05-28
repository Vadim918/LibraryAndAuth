using System;
using System.Linq.Expressions;
using Library.Core.Entities;
using Library.Core.Repositories;
using Library.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IUnitOfWork _uow;

        public BookController(IUnitOfWork uow) => _uow = uow;

        [Route("[controller]/[action]")]
        public IActionResult List(BookListViewModel model)
        {
            model.Publishers = _uow.PublisherRepository.List();

            Expression<Func<Book, bool>> filter = null;
            if (Guid.TryParse(model.PublisherId, out var publisherId))
            {
                filter = x => x.PublisherId == publisherId;
            }
            else if (model.PublisherId == "None")
            {
                filter = x => x.PublisherId == null;
            }

            model.Books = _uow.BookRepository.List(filter);
            return View(model);
        }

        [Route("[controller]/[action]/{id:guid}")]
        public IActionResult Details(Guid id)
        {
            var book = _uow.BookRepository.Find(id);
            return book == null ? (IActionResult) NotFound() : View(book);
        }
    }
}