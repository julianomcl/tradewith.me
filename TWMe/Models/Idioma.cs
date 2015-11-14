using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBD.Models
{
    public class Idioma
    {
        public int Id_Idioma { get; set; }
        public string Nome { get; set; }
    }

    public class IdiomaDbContext : DbContext
    {
        public DbSet<Idioma> Idiomas { get; set; }
    }
}
