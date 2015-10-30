using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBD.Models
{
    public class Rotulo
    {
        public int Id_Rotulo { get; set; }
        public int Id_Fabricante { get; set; }
        public int Id_Categoria { get; set; }
        public string Nome { get; set; }
        public int Fl_Tipo_Rotulo { get; set; }
    }

    public class RotuloDbContext : DbContext
    {
        public DbSet<Rotulo> Rotulos { get; set; }
    }
}
