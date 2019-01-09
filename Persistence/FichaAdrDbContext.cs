using fichaAdr.Models;
using Microsoft.EntityFrameworkCore;

namespace fichaAdr.Persistence
{
    public class FichaAdrDbContext : DbContext
    {
                public FichaAdrDbContext(DbContextOptions<FichaAdrDbContext> options)
        : base(options)
        {  
        }
        public DbSet<Ficha> Fichas {get; set;}
          
    }
}