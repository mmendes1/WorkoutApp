using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutAppWeb.Data;
using WorkoutAppWeb.Models;

namespace WorkoutAppWeb.Pages.Workouts
{
    public class IndexModel : PageModel
    {
        private readonly workoutDbContext _db;
        public IEnumerable<Workout> Workouts { get; set; }

        public IndexModel(workoutDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Workouts = _db.homeWorkoutDB;
        }
    }
}
