namespace CatsProtectionBg.Services.Moderator
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;

    public interface IModeratorCharityItemService
    {
        Task CreateAsync(
            string name,
            decimal price,
            string description,
            string imageurl,
            int quantity);
    }
}
