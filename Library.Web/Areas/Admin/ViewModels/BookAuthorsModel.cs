using System;
using System.Collections.Generic;
using Library.Core.Entities;

namespace Library.Web.Areas.Admin.ViewModels
{
    public class BookAuthorsModel
    {
        public Guid Id { get; set; }
        public string BookTitle { get; set; }
        public Guid AuthorId { get; set; }
        public IEnumerable<Author> Authors { get; set; }
        public IEnumerable<Author> PotentialAuthors { get; set; }
    }
}