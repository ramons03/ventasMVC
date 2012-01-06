using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ventaMVC.Models
{
    public class Producto
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MaxLength(100)]
        public String nombre { get; set; }

        [Required(ErrorMessage = "El stock es obligatorio.")]
        [Range(0, 1000, ErrorMessage = "Stock entre 0-1000")]
        public int stock { get; set; }

        public Proveedor proveedor { get; set; }

    }
}