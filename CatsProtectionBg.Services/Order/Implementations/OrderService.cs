namespace CatsProtectionBg.Services.Order.Implementations
{
    using Implementations;
    using Data;
    using Data.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderService : IOrderService
    {
        private readonly CatsProtectionBgDbContext db;

        public OrderService(CatsProtectionBgDbContext db)
        {
            this.db = db;
        }

        public void Purchase(string userId, IEnumerable<int> charityItemIds)
        {
            var alreadyOwnedIds = this.db
                .Orders
                .Where(o => o.UserId == userId
                            && charityItemIds.Contains(o.CharityItemId))
                .Select(o => o.CharityItemId)
                .ToList();

            var newCharityItemsIds = new List<int>(charityItemIds);

            foreach (var charityItemId in alreadyOwnedIds)
            {
                newCharityItemsIds.Remove(charityItemId);
            }

            foreach (var newCharityItemId in newCharityItemsIds)
            {
                var order = new Order
                {
                    CharityItemId = newCharityItemId,
                    UserId = userId
                };

                db.Orders.Add(order);
            }

            db.SaveChanges();
        }
    }
}
