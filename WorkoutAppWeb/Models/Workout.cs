using System.ComponentModel.DataAnnotations;

namespace WorkoutAppWeb.Models
{
    public class Workout
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public int repCount { get; set; }
    }
}
