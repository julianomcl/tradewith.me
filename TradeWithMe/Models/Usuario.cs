using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; } //como string na base???
        public string Email { get; set; }
        public string Foto { get; set; }
        public string Facebook { get; set; }
    }

    public class UsuarioDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}