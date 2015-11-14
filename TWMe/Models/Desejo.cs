using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBD.Models
{
    public class Desejo
    {
        public int Id_Usuario { get; set; }
        public int Id_Rotulo { get; set; }
        public int Id_Fabricante { get; set; }
    }

    public class DesejoDbContext : DbContext
    {
        public DbSet<Desejo> Desejos { get; set; }
    }
}
