using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBD.Models
{
    public class Produto
    {
        public int Id_Produto { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Rotulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Inclusao { get; set; }
<<<<<<< HEAD
        public int Situacao { get; set; }
        public DateTime Data_Situacao { get; set; } //PQ ESSA INCONSISTENCIA?
=======
        public string Situacao { get; set; }
        public DateTime Data_Situacao { get; set; }
>>>>>>> origin/master
        public int Fl_Roupa { get; set; }
        public string Imagem { get; set; }
    }

    public class ProdutoDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}
