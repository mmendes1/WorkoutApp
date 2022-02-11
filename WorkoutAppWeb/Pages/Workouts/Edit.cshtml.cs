using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutAppWeb.Data;
using WorkoutAppWeb.Models;

namespace WorkoutAppWeb.Pages.Workouts
{
    public class EditModel : PageModel
    {
        private readonly workoutDbContext _db;
        [BindProperty]
        public Workout Workout { get; set; }
        public EditModel(workoutDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Workout = _db.homeWorkoutDB.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if(Workout.name == Workout.repCount.ToString())
            {
                ModelState.AddModelError("Workout.name", "The name field should not be a number.");
            }

            if (ModelState.IsValid)
            {
                _db.homeWorkoutDB.Update(Workout);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
