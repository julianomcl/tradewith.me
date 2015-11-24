using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TWMe.Models
{
    public class Jogo
    {
        public int Id_Rotulo { get; set; }
        public string Marca { get; set; }
        public string Recursos { get; set; }
        public string Faixa_Etaria { get; set; }
        public int Id_Plataforma { get; set; }
        public int Id_Genero { get; set; }
    }

    public class JogoDbContext : DbContext
    {
        public DbSet<Jogo> Jogos { get; set; }
    }
}
