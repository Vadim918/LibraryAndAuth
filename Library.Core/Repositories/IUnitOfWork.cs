using System;

namespace Library.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository AuthorRepository { get; }
        IBookRepository BookRepository { get; }
        IBookAuthorRepository BookAuthorRepository { get; }
        IPublisherRepository PublisherRepository { get; }
        IUserRepository UserRepository { get; }

        void Commit();
    }
}