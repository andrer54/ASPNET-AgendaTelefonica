using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AgendaTelefonica.Models
{
    public class contexto: DbContext
    {
        public contexto() : base("name=principal")
        {
        }
        public DbSet<pessoa> Pessoas { get; set; }
    }
}