using System.ComponentModel.DataAnnotations;

namespace Tadb.WebApi.Models
{
    public class LoginModel
    {
        [Key]
        public int id_role { get; set; }
    }
}