using System.ComponentModel.DataAnnotations;
using Web.Models.Utils;

namespace Web.Models
{
    public class Week : Entity
    {
        /// <summary>
        /// Название недели
        /// </summary>
        [Required]
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Коллекция дней в этой недели
        /// </summary>
        /// 
        public ICollection<Couple> Couples { get; set; } = new List<Couple>();
        public ICollection<WeekDay> WeekDays { get; set; } = new List<WeekDay>();
    }
}
