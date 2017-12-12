namespace CatsProtectionBg.Web.Areas.Moderator.Models.CharityItems
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using  static Data.DataConstants;

    public class AddCharityItemFormModel
    {
        [Required]
        [MinLength(CharityItemNameMinLength)]
        [MaxLength(CharityItemNameMaxLength)]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [MinLength(CharityItemDescriptionMinLength)]
        [MaxLength(CharityItemDescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [MinLength(11)]   
        public string ImageUrl { get; set; }

        [Required]
        [Range(0, 100)]
        public int? Quantity { get; set; }
       
    }
}

