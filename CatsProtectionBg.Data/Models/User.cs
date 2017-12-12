namespace CatsProtectionBg.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class User : IdentityUser
    {
        [Required]
        [MinLength(FullNameMinLength)]
        [MaxLength(FullNameMaxLength)]
        public string FullName { get; set; }

        //public bool IsAdmin { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
