using Web.Models.Utils;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class LessonType : Entity
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        public ICollection<Couple> Couples { get; set; } = new List<Couple>();
    }
}
