using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBD.Models
{
    public class Livro
    {
        public int Id_Rotulo { get; set; }
        public string ISBN { get; set; }
        public int Paginas { get; set; }
        public string Edicao { get; set; }
        public int Ano { get; set; }
        public string Codigo_barras { get; set; }
        public int Id_Editora { get; set; }
        public int Id_Assunto { get; set; }
        public int Id_Idioma { get; set; }
    }

    public class LivroDbContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }
    }
}
