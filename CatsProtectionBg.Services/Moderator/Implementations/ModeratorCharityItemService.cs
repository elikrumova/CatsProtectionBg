namespace CatsProtectionBg.Services.Moderator.Implementations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using Data;
    using Data.Models;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using AutoMapper.QueryableExtensions;


    public class ModeratorCharityItemService : IModeratorCharityItemService
    {
        private readonly CatsProtectionBgDbContext db;

        public ModeratorCharityItemService(CatsProtectionBgDbContext db)
        {
            this.db = db;
        }
        //public async Task<IEnumerable<ModeratorCharityItemService> ByIds<TModel>(IEnumerable<int> ids)
          //  => await this.db
            //    .CharityItems
            //    .Where(chi => chi.Contains(CharityItem.Id))
              //  .ProjectTo<ModeratorCharityItemService>()
             //   .ToList();

        public async Task<IEnumerable<ModeratorCharityItemListingServiceModel>> AllAsync(int page = 1)
            => await this.db
                .CharityItems
                .OrderByDescending(chi => chi.Name)
                .ProjectTo<ModeratorCharityItemListingServiceModel>()
                .ToListAsync();

        public async Task<int> TotalAsync()
            => await this.db.CharityItems.CountAsync();

        public async Task CreateAsync(
            string name,
            decimal price,
            string description,
            string imageurl,
            int quantity

           )      
        {
            var charityItem = new CharityItem
            {
                Name = name,
                Price = price,
                Description = description,
                ImageUrl = imageurl,
                Quantity = quantity
            };

            this.db.Add(charityItem);

            await this.db.SaveChangesAsync();
        }
        public async Task EditAsync(
            string name,
            decimal price,
            string description,
            string imageurl,
            int quantity

           )
        {
            var charityItem = this.db.CharityItems.Find();

            charityItem.Name = name;
            charityItem.Price = price;
            charityItem.Description = description;
            charityItem.ImageUrl = imageurl;
            charityItem.Quantity = quantity;

            this.db.Add(charityItem);

            await this.db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var charityItem = this.db.CharityItems.Find(id);
            this.db.CharityItems.Remove(charityItem);

           await this.db.SaveChangesAsync();
        }

        public CharityItem GetById(int id)
            => this.db.CharityItems.Find(id);

        public bool Exists(int id)
            => this.db.CharityItems.Any(chi => chi.Id == id);

        public IEnumerable<TModel> ByIds<TModel>(IEnumerable<int> ids)
            => this.db
                .CharityItems
                .Where(g => ids.Contains(g.Id))
                .ProjectTo<TModel>()
                .ToList();

        public IEnumerable<TModel> All<TModel>(string userId = null)
        {
            var query = this.db.CharityItems.AsQueryable();

            if (userId != null)
            {
                query = query.Where(chi => chi.Orders.Any(o => o.UserId == userId));
            }

            return query
                .ProjectTo<TModel>()
                .ToList();
        }
    }
}
