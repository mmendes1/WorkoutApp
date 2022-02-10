using Microsoft.EntityFrameworkCore;
using WorkoutAppWeb.Models;

namespace WorkoutAppWeb.Data
{
    public class workoutDbContext : DbContext 
    {
        public workoutDbContext(DbContextOptions<workoutDbContext> options) : base(options)
        {

        }
        public DbSet<Workout> homeWorkoutDB { get; set; }
    }
}
