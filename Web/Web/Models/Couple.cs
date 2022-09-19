using Web.Models.Utils;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Couple : Entity
    {
        /// <summary>
        /// В какой день это занятие
        /// </summary>
        [Required]
        public WeekDay WeekDay { get; set; } = new();

        /// <summary>
        /// Время занятия
        /// </summary>
        [Required]
        public LectureTime LectureTime { get; set; }

        /// <summary>
        /// Аудитория с корпусом
        /// </summary>
        [Required]
        public Audience Audience { get; set; } = new();

        /// <summary>
        /// Дисциплина
        /// </summary>
        [Required]
        public Discipline Discipline { get; set; } = new();

        /// <summary>
        /// Преподователь
        /// </summary>
        [Required]
        public Teacher Teacher { get; set; } = new();

        /// <summary>
        /// Тип урока
        /// </summary>
        [Required]
        public LessonType LessonType { get; set; } = new();

        /// <summary>
        /// Группы
        /// </summary>
        [Required]
        public ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
