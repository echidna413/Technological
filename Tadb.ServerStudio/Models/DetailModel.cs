namespace Tadb.ServerStudio.Models
{
    public class DetailModel
    {
        public int detail_id { get; set; }
        public int id_employee { get; set; }
        public int id_company { get; set; }
        public string code_detail { get; set; }
        public string name_detail { get; set; }
        public string mark_material { get; set; }
        public double size_production { get; set; }
        public double size_transmission { get; set; }
        public double mass_detail { get; set; }
        public bool central_hole { get; set; }
        public string description { get; set; }
    }
}