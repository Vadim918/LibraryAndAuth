using System;
using Library.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IUnitOfWork _uow;

        public AuthorController(IUnitOfWork uow) => _uow = uow;

        [Route("[controller]/[action]")]
        public IActionResult List() => View(_uow.AuthorRepository.List());

        [Route("[controller]/[action]/{id:guid}")]
        public IActionResult Details(Guid id)
        {
            var author = _uow.AuthorRepository.Find(id);
            return author == null ? (IActionResult) NotFound() : View(author);
        }
    }
}