using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TWMe.Models
{
    public class Categoria
    {
        public int Id_Categoria { get; set; }
        public int Id_Categoria_Mae { get; set; }
        public string Nome { get; set; }
    }

    public class CategoriaDbContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
    }
}
