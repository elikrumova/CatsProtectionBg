namespace CatsProtectionBg.Services.Order
{
    using System.Collections.Generic;

    public interface IOrderService
    {
        void Purchase(string userId, IEnumerable<int> charityItemIds);
    }
}
