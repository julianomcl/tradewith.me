using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBD.Models
{
    public class Assunto
    {
        public int Id_Assunto { get; set; }
        public string Nome { get; set; }
    }

    public class AssuntoDbContext : DbContext
    {
        public DbSet<Assunto> Assuntos { get; set; }
    }
}
