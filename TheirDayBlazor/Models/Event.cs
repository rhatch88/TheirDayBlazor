using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheirDayBlazor.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string AgeGroup { get; set; }
        [Column(TypeName = "decimal(10,2)")]    
        public decimal Price { get; set; }
        public string Location { get; set; }
        public bool IsOutdoor { get; set; }    
    }
}
