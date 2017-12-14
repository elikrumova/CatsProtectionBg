namespace CatsProtectionBg.Web.Areas.Moderator.Models.CharityItems
{
    using Common.Mapping;
    using System.Collections.Generic;
    using Services.Moderator.Models;
    using Data.Models;
    using Infrastructure.Mapping;

    public class CharityItemsListingViewModel : IMapFrom<CharityItem>//, IHaveCustomMapping
    {
        public IEnumerable<ModeratorCharityItemListingServiceModel> CharityItems { get; set; }
    }
}
