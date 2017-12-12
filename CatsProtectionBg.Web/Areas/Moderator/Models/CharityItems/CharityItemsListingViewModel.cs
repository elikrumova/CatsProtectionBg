namespace CatsProtectionBg.Web.Areas.Moderator.Models.CharityItems
{
    using System.Collections.Generic;
    using CatsProtectionBg.Services.Moderator.Models;

    public class CharityItemsListingViewModel
    {
        public IEnumerable<ModeratorCharityItemListingServiceModel> CharityItems { get; set; }
    }
}
