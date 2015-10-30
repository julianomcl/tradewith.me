using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBD.Models
{
    public class Editora
    {
        public int Id_Editora { get; set; }
        public string Nome { get; set; }
    }

    public class EditoraDbContext : DbContext
    {
        public DbSet<Editora> Editoras { get; set; }
    }
}
