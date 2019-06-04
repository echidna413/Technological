namespace Tadb.ServerStudio.Models
{
    public class RecordModel
    {
        public int id_record { get; set; }
        public int id_company { get; set; }
        public int id_employee { get; set; }
        public int id_status { get; set; }
        public int equipment_code { get; set; }
        public int fixture_code { get; set; }
        public int process_code { get; set; }
        public int surface_code { get; set; }
    }
}