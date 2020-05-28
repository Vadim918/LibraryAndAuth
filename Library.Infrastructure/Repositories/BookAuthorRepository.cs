using System;
using Library.Core.Entities;
using Library.Core.Repositories;

namespace Library.Infrastructure.Repositories
{
    internal sealed class BookAuthorRepository : Repository<BookAuthor>, IBookAuthorRepository
    {
        public BookAuthorRepository(LibraryContext context) : base(context)
        {
        }

        public BookAuthor Find(Guid bookId, Guid authorId)
        {
            return DbSet.Find(bookId, authorId);
        }
    }
}