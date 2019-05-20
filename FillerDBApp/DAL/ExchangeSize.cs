using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class ExchangeSize
    {
        [Key]
        public int record_id { get; set; }

        public string code_surface_input { get; set; }

        public string code_surface_output { get; set; }

        public double size_1 { get; set; }

        public double size_2 { get; set; }

        public double size_3 { get; set; }

        public double size_4 { get; set; }

        public double size_5 { get; set; }

        public double size_6 { get; set; }

        public double size_7 { get; set; }

        public double size_8 { get; set; }

        public double size_9 { get; set; }

        public double size_10 { get; set; }

        public double size_11 { get; set; }

        public double size_12 { get; set; }
    }
}