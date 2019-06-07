using System.ComponentModel.DataAnnotations;

namespace Tadb.ServerStudio.Models
{
    public class LoginModel
    {
        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Логин не может быть пустым полем", AllowEmptyStrings = false)]
        public string Username { get; set; }

        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [MinLength(1, ErrorMessage = "Пароль не может быть пустым")]
        public string Password { get; set; }
    }
}