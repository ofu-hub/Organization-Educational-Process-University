using System.ComponentModel.DataAnnotations;
using Web.Models.Utils;

namespace Web.Models
{
    public class WeekDay : Entity
    {
        /// <summary>
        /// Название дня недели
        /// </summary>
        [Required]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// В какой недели
        /// </summary>
        public Week Week { get; set; } = new();
        /// <summary>
        /// Коллекция занятий в этот день
        /// </summary>
        public ICollection<Couple> Couples { get; set; } = new List<Couple>();
    }
}
