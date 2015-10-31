using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBD.Models
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
<<<<<<< HEAD
        public DateTime DataNascimento { get; set; } //como string na base???
=======
        public DateTime DataNascimento { get; set; } 
>>>>>>> origin/master
        public string Email { get; set; }
        public string Foto { get; set; }
        public string Facebook { get; set; }
    }

    public class UsuarioDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
