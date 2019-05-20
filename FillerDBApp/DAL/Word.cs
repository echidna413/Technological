using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Word
    {
        [Key]
        public int id { get; set; }
        public double number_word { get; set; }
        public string word { get; set; }
        public double group_operation { get; set; }
        public double operation { get; set; }
    }
}
