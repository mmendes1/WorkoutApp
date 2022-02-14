using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutAppWeb.Data;
using WorkoutAppWeb.Models;

namespace WorkoutAppWeb.Pages.Workouts
{
    public class CreateModel : PageModel
    {
        private readonly workoutDbContext _db;
        [BindProperty]
        public Workout Workout { get; set; }
        public CreateModel(workoutDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(Workout.name == Workout.repCount.ToString())
            {
                ModelState.AddModelError("Workout.name", "The name field should not be a number.");
            }

            if (ModelState.IsValid)
            {
                await _db.homeWorkoutDB.AddAsync(Workout);
                await _db.SaveChangesAsync();
                TempData["success"] = "Workout created successfully.";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
