namespace CatsProtectionBg.Data.Models
{
    using System.Collections.Generic;

    public class Order
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public int CharityItemId { get; set; }

        public CharityItem CharityItem { get; set; }

        //public List<CharityItem> CharityItems { get; set; } = new List<CharityItem>();
    }
}
