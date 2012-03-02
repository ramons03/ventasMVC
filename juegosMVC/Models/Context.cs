using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace juegosMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Juego> Juegos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}