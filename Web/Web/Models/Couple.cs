using Web.Models.Utils;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Couple : Entity
    {
        [Required]
        public WeekType WeekType { get; set; }

        [Required]
        public WeekDay WeekDay { get; set; }

        [Required]
        public LectureTime LectureTime { get; set; }

        [Required]
        public Audience Audience { get; set; } = new();

        [Required]
        public Discipline Discipline { get; set; } = new();

        [Required]
        public Teacher Teacher { get; set; } = new();

        [Required]
        public LessonType LessonType { get; set; } = new();

        [Required]
        public Group Group { get; set; } = new();
    }
}
