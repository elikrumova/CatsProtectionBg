namespace CatsProtectionBg.Data.Models
{
    //using CatsProtectionBg.Common;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class CharityItem
    {
        public int Id { get; set; }

        [Required]
        [MinLength(CharityItemNameMinLength)]
        [MaxLength(CharityItemNameMaxLength)]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        //[Price(ErrorMessage = "Price is required and must be a positive number.")]
        public decimal Price { get; set; }

        [Required]
        [MinLength(CharityItemDescriptionMinLength)]
        [MaxLength(CharityItemDescriptionMaxLength)]
        //[Description(ErrorMessage = "The description must be no more than 2000 symbols")]
        public string Description { get; set; }

        [Required]
        [MinLength(11)]
        //[Image(ErrorMessage = "A valid image url must start with http:// or https://")]
        public string ImageUrl { get; set; }

        [Required]
        [Range(0, 100)]
        //[Range(0, 100, ErrorMessage = "Quantity must be in range 0 - 100.")]
        public int? Quantity { get; set; }

        //public DateTime? OrderDate { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();

        //public ICollection<CategoryCharityItem> Categories { get; set; } = new List<CategoryCharityItem>();
    }
}
