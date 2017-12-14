using CatsProtectionBg.Data.Models;

namespace CatsProtectionBg.Services.Moderator
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;

    public interface IModeratorCharityItemService
    {
        Task<IEnumerable<ModeratorCharityItemListingServiceModel>> AllAsync(int page = 1);

        Task<int> TotalAsync();

        //Task<> ById(int id);

        Task CreateAsync(
            string name,
            decimal price,
            string description,
            string imageurl,
            int quantity);

        Task EditAsync(
            string name,
            decimal price,
            string description,
            string imageurl,
            int quantity);

        Task DeleteAsync(int id);

        CharityItem GetById(int id);

        bool Exists(int id);

        IEnumerable<TModel> ByIds<TModel>(IEnumerable<int> ids);

        IEnumerable<TModel> All<TModel>(string userId = null);
    }
}
