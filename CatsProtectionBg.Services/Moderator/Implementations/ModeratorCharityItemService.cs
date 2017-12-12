namespace CatsProtectionBg.Services.Moderator.Implementations
{
    using Data;
    using Data.Models;
    using System.Threading.Tasks;

    public class ModeratorCharityItemService : IModeratorCharityItemService
    {
        private readonly CatsProtectionBgDbContext db;

        public ModeratorCharityItemService(CatsProtectionBgDbContext db)
        {
            this.db = db;
        }

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
    }
}
