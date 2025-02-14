using Microsoft.EntityFrameworkCore;

namespace Mission06_Metler.Models
{
    public class NewMovieContext : DbContext
    {
        public NewMovieContext(DbContextOptions<NewMovieContext> options) : base(options) 
        { 
        }

        public DbSet<NewMovie> Movies { get; set; }
    }   
}
