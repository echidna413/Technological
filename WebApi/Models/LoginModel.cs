using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class LoginModel
    {
        [Key]

        public int id_role { get; set; }
    }
}