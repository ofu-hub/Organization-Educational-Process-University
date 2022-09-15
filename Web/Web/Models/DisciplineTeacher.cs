using Web.Models.Utils;

namespace Web.Models
{
    public class DisciplineTeacher : Entity
    {
        public Discipline Discipline { get; set; } = new();
        public Teacher Teacher { get; set; } = new();

    }
}
