using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options) { }

        public DbSet<MuscleGroup> MuscleGroups => Set<MuscleGroup>();
        public DbSet<Exercise> Exercises => Set<Exercise>();
    }
}
