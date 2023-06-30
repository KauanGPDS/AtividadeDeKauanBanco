using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LHpet3.Models
{
  
        public class Contexto : DbContext
        {
            public Contexto(DbContextOptions<Contexto> options) : base(options)
            {
            }
            public DbSet<Cliente> Cliente { get; set; }
        }
    
}
