using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Library.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Areas.Admin.ViewModels
{
    public class BookEditModel
    {
        public Guid Id { get; set; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "Title is required")]
        [StringLength(1024, ErrorMessage = "Max length is 1024")]
        public string Title { get; set; }

        [DisplayName("Publisher")]
        public Guid? PublisherId { get; set; }

        [DisplayName("Publishing Date")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "01/01/1900", "01/01/2100", ErrorMessage = "Publishing Date is out of range")]
        public DateTime? PublishingDate { get; set; }

        [Range(0.0, 5.0, ErrorMessage = "Rating is out of range")]
        public float? Rating { get; set; }

        [DisplayName("Cover Url")]
        [DataType(DataType.ImageUrl)]
        public string CoverUrl { get; set; }

        public string Description { get; set; }

        public List<Publisher> Publishers { get; set; }
    }
}