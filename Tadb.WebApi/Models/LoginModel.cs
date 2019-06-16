using System.ComponentModel.DataAnnotations;

namespace Tadb.WebApi.Models
{
    public class LoginModel
    {
        [Key]
        public int id_employee { get; set; }
        public int id_role { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
    }
}