using Web.Models.Utils;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Discipline : Entity
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        public ICollection<DisciplineTeacher> DisciplineTeachers { get; set; } = new List<DisciplineTeacher>();
        public ICollection<Couple> Couples { get; set; } = new List<Couple>();
    }
}
