using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBD.Models
{
    public class Roupa
    {
        public int Id_Produto { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public string Tecido { get; set; }
        public int Id_Fabricante { get; set; }
        public int Id_Categoria { get; set; }
    }

    public class RoupaDbContext : DbContext
    {
        public DbSet<Roupa> Roupas { get; set; }
    }
}
