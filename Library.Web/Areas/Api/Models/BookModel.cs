using System;
using System.Collections.Generic;
using Library.Core.Entities;

namespace Library.Web.Areas.Api.Models
{
    public class BookModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? PublishingDate { get; set; }
        public float? Rating { get; set; }
        public string CoverUrl { get; set; }
        public Publisher Publisher { get; set; }
        public List<AuthorModel> Authors { get; set; }
    }
}