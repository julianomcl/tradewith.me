﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TWMe.Models
{
    public class Troca
    {
        public int Id_Troca { get; set; }
        public int Id_Usuario_Solicitante { get; set; }
        public int Id_Usuario_Detentor { get; set; }
        public DateTime Data_Situacao { get; set; }
        public DateTime Data_Inclusao { get; set; } 
        public int Situacao { get; set; }
        public int Posicao_Solicitante { get; set; }
        public int Posicao_Detentor { get; set; }
    }

    public class TrocaDbContext : DbContext
    {
        public DbSet<Troca> Trocas { get; set; }
    }
}
