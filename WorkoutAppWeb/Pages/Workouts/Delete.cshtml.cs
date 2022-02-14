using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutAppWeb.Data;
using WorkoutAppWeb.Models;

namespace WorkoutAppWeb.Pages.Workouts
{
    public class DeleteModel : PageModel
    {
        private readonly workoutDbContext _db;
        [BindProperty]
        public Workout Workout { get; set; }
        public DeleteModel(workoutDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Workout = _db.homeWorkoutDB.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            var workoutFromDb = _db.homeWorkoutDB.Find(Workout.id);
            if (workoutFromDb != null)
            {
                _db.homeWorkoutDB.Remove(workoutFromDb);
                await _db.SaveChangesAsync();
                TempData["success"] = "Workout deleted successfully.";
                    return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
