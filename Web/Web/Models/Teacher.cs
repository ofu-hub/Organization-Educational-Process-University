using Web.Models.Utils;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Teacher : Entity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Surname { get; set; } = string.Empty;
        public string? Patronymic { get; set; } = null;

        public ICollection<DisciplineTeacher> DisciplineTeachers { get; set; } = new List<DisciplineTeacher>();
        public ICollection<Couple> Couples { get; set; } = new List<Couple>();
    }
}
