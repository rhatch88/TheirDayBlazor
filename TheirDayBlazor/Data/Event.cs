﻿using System.ComponentModel.DataAnnotations;    

namespace TheirDayBlazor.Data
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Age Group { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string IsOutdoor { get; set; }    
    }
}
