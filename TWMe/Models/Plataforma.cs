using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBD.Models
{
    public class Plataforma
    {
        public int Id_Plataforma { get; set; }
        public string Nome { get; set; }
    }

    public class PlataformaDbContext : DbContext
    {
        public DbSet<Plataforma> Plataformas { get; set; }
    }
}
