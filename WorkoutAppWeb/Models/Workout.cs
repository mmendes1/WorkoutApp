using System.ComponentModel.DataAnnotations;

namespace WorkoutAppWeb.Models
{
    public class Workout
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "Workout Name")]
        public string name { get; set; }
        [Display(Name ="Rep Count")]
        [Range(1, 200, ErrorMessage ="If you are doing over 200 reps, or less than 1, something is wrong.")]
        public int repCount { get; set; }
    }
}
