using Web.Models.Utils;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Group : Entity
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        public Couple Couple { get; set; } = new();
    }
}
