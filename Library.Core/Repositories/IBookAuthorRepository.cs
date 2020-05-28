using System;
using Library.Core.Entities;

namespace Library.Core.Repositories
{
    public interface IBookAuthorRepository
    {
        BookAuthor Find(Guid bookId, Guid authorId);
        void Add(BookAuthor entity);
        void Remove(BookAuthor entity);
    }
}