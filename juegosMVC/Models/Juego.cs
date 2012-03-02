using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace juegosMVC.Models
{
    public class Juego
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El año es obligatorio.")]
        [Range(1900, 2011, ErrorMessage = "Años entre 1900-2011")]
        public string Año { get; set; }

        [Required(ErrorMessage = "El título es Obligatorio.")]
        [MaxLength(50)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La categoria es obligatoria.")]
        public Categoria Categoria { get; set; }
    }
}