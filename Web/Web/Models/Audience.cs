using Web.Models.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{
    public class Audience : Entity
    {
        [Required]
        public string Number { get; set; } = string.Empty;

        /// <summary>
        /// В каком корпусе
        /// </summary>
        public Campus Campus { get; set; } = new();

        public ICollection<Couple> Couples { get; set; } = new List<Couple>();
    }
}
