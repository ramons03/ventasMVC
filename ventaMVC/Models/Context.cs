using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ventaMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

        public DbSet<Proveedor> Proveedor { get; set; }
    }
}