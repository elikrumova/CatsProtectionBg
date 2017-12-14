namespace CatsProtectionBg.Web.Models.Orders
{
    using System.Collections.Generic;

    public class ShoppingCart
    {
        private readonly ICollection<int> charityItemIds;

        public ShoppingCart()
        {
            this.charityItemIds = new List<int>();
        }

        public void AddCharityItem(int charityItemId)
        {
            if (!this.charityItemIds.Contains(charityItemId))
            {
                this.charityItemIds.Add(charityItemId);
            }
        }

        public void RemoveGame(int charityItemId) => this.charityItemIds.Remove(charityItemId);

        public IEnumerable<int> AllCharityItems() => new List<int>(this.charityItemIds);

        public void Clear() => this.charityItemIds.Clear();
    }
}
