using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace juegosMVC.Models
{
    public class Categoria
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        public string Nombre { get; set; }
    }
}