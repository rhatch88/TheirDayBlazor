using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheirDayBlazor.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]

        public string AgeGroup { get; set; } = string.Empty;
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; } = 0.0m;
        [Required]
        public string Location { get; set; } = string.Empty;
        public bool IsOutdoor { get; set; } = false;
    }
}
