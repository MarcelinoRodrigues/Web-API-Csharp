using Microsoft.EntityFrameworkCore;
using Myka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myka.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
