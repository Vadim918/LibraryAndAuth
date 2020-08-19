using System;
using Library.Core.Entities;
using Library.Web.Areas.Admin.ViewModels;

namespace Library.Web.Areas.Admin.Extensions
{
    public static class DomainExtension
    {
        public static BookAuthorsModel AuthorAddToDomain(this Book book)
        {
            return new BookAuthorsModel();
        }

        public static Book BookToDomain(this BookEditModel model)
        {
            return new Book
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                PublisherId = model.PublisherId,
                Description = string.IsNullOrWhiteSpace(model.Description) ? null : model.Description,
                PublishingDate = model.PublishingDate,
                Rating = model.Rating,
                CoverUrl = model.CoverUrl
            };
        }

        public static BookEditModel EditBookToView(this Book book)
        {
            return new BookEditModel
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                PublishingDate = book.PublishingDate,
                Rating = book.Rating,
                CoverUrl = book.CoverUrl,
                PublisherId = book.PublisherId
            };
        }
    }
}