using Cinema.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<FilmeModel> Filmes { get; set; } 
    }
}
