using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tadb.ServerStudio.Models.CatalogModels
{
    public class ProcessCatalogModel
    {
        [Display(Name = "Код технологического перехода")]
        public int process_code { get; set; }
        [Display(Name = "Описание")]
        public string description { get; set; } //Описание

    }
}