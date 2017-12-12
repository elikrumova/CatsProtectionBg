namespace CatsProtectionBg.Services.Moderator.Models
{
    using Common.Mapping;
    using Data.Models;

    public class ModeratorCharityItemListingServiceModel : IMapFrom<CharityItem>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Price { get; set; }
    }
}
