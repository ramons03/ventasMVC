using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ventaMVC.Models
{
    public class Proveedor
    {
        [ScaffoldColumn(false)]
        public int id { get; set; }

        public String nombre { get; set; }

        public String telefono { get; set; }

    }
}