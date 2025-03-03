using System.ComponentModel.DataAnnotations;

namespace TheirDayBlazor.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string AgeGroup { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string IsOutdoor { get; set; }    
    }
}
