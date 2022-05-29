﻿using System.ComponentModel.DataAnnotations;

namespace HotelListingAPI.Models.Hotel
{
    public abstract class HotelBaseDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

        public double? Rating { get; set; }
        public int CountryId { get; set; }
    }
}
