using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TWMe.Models
{
    public class Genero
    {
        public int Id_Genero { get; set; }
        public string Nome { get; set; }
    }

    public class GeneroDbContext : DbContext
    {
        public DbSet<Genero> Generos { get; set; }
    }
}
