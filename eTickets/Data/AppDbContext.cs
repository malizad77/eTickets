using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Actor_Movie>()
                .HasKey(am => new { am.ActorId, am.MovieId });

            modelBuilder.Entity<Models.Actor_Movie>()
                .HasOne(am => am.Actor)
                .WithMany(a => a.Actors_Movies)
                .HasForeignKey(am => am.ActorId);
            
            modelBuilder.Entity<Models.Actor_Movie>()
                .HasOne(am => am.Movie)
                .WithMany(m => m.Actors_Movies)
                .HasForeignKey(am => am.MovieId);
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Models.Actor> Actors { get; set; }
        public DbSet<Models.Cinema> Cinemas { get; set; }
        public DbSet<Models.Movie> Movies { get; set; }
        public DbSet<Models.Producer> Producers { get; set; }
        public DbSet<Models.Actor_Movie> Actors_Movies { get; set; }


    }
}
