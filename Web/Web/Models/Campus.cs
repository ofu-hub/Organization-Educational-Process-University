using Web.Models.Utils;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Campus : Entity
    {
        [Required]
        public string Number { get; set; } = string.Empty;

        /// <summary>
        /// Аудитории в корпусе
        /// </summary>
        public ICollection<Audience> Audiences { get; set; } = new List<Audience>();
        public ICollection<Couple> Couples { get; set; } = new List<Couple>();
    }
}
