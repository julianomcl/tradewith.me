using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TWMe.Models
{
    public class Fabricante
    {
        public int Id_Fabricante { get; set; }
        public int Nome { get; set; }   
    }

    public class FabricanteDbContext : DbContext
    {
        public DbSet<Fabricante> Fabricantes { get; set; }
    }
}
