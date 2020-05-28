using System;
using Library.Core.Repositories;
using Library.Infrastructure.Repositories;

namespace Library.Infrastructure
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private LibraryContext _context;
        private IAuthorRepository _authorRepository;
        private IBookRepository _bookRepository;
        private IBookAuthorRepository _bookAuthorRepository;
        private IPublisherRepository _publisherRepository;
        private IUserRepository _userRepository;

        private LibraryContext Context => _context ??= new LibraryContext();

        public IAuthorRepository AuthorRepository => _authorRepository ??= new AuthorRepository(Context);
        public IBookRepository BookRepository => _bookRepository ??= new BookRepository(Context);
        public IBookAuthorRepository BookAuthorRepository => _bookAuthorRepository ??= new BookAuthorRepository(Context);
        public IPublisherRepository PublisherRepository => _publisherRepository ??= new PublisherRepository(Context);
        public IUserRepository UserRepository => _userRepository ??= new UserRepository(Context);

        public void Commit()
        {
            if (_isDisposed)
            {
                throw new ObjectDisposedException("UnitOfWork");
            }

            Context.SaveChanges();
        }

        private bool _isDisposed;

        public void Dispose()
        {
            if (_context == null)
            {
                return;
            }

            if (!_isDisposed)
            {
                Context.Dispose();
            }

            _isDisposed = true;
        }
    }
}