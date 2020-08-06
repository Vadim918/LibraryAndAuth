using System;
using Library.Core.Repositories;
using Library.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _uow;

        public UserController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [Route("[controller]/[action]/{id:guid}")]
        public IActionResult EditUser(Guid id)
        {
            var user = _uow.UserRepository.Find(id);
            if (user == null) return NotFound();

            var model = new UserEditModel
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsActive = user.IsActive
            };
            return View(model);
        }

        [HttpPost("[controller]/[action]/{id:guid}")]
        public IActionResult EditUser(UserEditModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = _uow.UserRepository.Find(model.Id);
            if (user == null) return NotFound();
            user.Email = model.Email;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.IsActive = model.IsActive;

            _uow.Commit();

            return RedirectToAction("List", "Book");
        }

        [Route("[controller]/[action]/{id:guid}")]
        public IActionResult ChangePassword(Guid id)
        {
            var user = _uow.UserRepository.Find(id);
            if (user == null) return NotFound();

            var model = new ChangePasswordViewModel {Id = user.Id, Email = user.Email};
            return View(model);
        }

        [HttpPost("[controller]/[action]/{id:guid}")]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var user = _uow.UserRepository.Find(model.Id);
            if (user == null) return NotFound();

            user.PasswordHash = model.NewPassword;

            _uow.Commit();


            return RedirectToAction("EditUser");
        }
    }
}