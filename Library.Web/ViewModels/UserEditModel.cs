using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Web.ViewModels
{
    public class UserEditModel
    {
        public Guid Id { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [StringLength(128, ErrorMessage = "Max length is 128")] //Валидация email
        public string Email { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(128, ErrorMessage = "Max length is 128")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(128, ErrorMessage = "Max length is 128")]
        public string LastName { get; set; }

        public bool IsActive { get; set; }
    }
}