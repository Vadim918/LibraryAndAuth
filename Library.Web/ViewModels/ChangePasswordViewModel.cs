using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Web.ViewModels
{
    public class ChangePasswordViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Поле {0} должно иметь минимум {2} и максимум {1} символов.",
            MinimumLength = 5)]
        [Display(Name = "Пароль")]
        public string NewPassword { get; set; }
    }
}