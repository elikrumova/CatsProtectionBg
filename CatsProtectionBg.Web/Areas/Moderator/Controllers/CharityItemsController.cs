namespace CatsProtectionBg.Web.Areas.Moderator.Controllers
{
    using Microsoft.CodeAnalysis.CSharp;

    using Models.CharityItems;
    using Services.Moderator;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Infrastructure.Extensions;
    using Web.Controllers;
   
    public class CharityItemsController : BaseModeratorController
    {

        private readonly IModeratorCharityItemService charityItem;

        public CharityItemsController(
           
            IModeratorCharityItemService charityItem)
        {
          
            this.charityItem = charityItem;
        }

        public async Task<IActionResult> All()
        {
            var charityItem = await this.charityItem.AllAsync();
          

            return View(new CharityItemsListingViewModel()
            {
               CharityItems = charityItem
            });
        }

        public async Task<IActionResult> Create()
            => View(new AddCharityItemFormModel
            {
                
            });

        [HttpPost]
        public async Task<IActionResult> Create(AddCharityItemFormModel model)
        {
            if (!ModelState.IsValid)
            {
               return View(model);
            }

            await this.charityItem.CreateAsync(
                model.Name,
                model.Price,
                model.Description,
                model.ImageUrl,      
                model.Quantity);

            TempData.AddSuccessMessage($"Charity Item {model.Name} created successfully!");

            return RedirectToAction(
                nameof(HomeController.Index),
                "Home",
                new { area = string.Empty });
        }
        public async Task<IActionResult> Edit()
            => View(new AddCharityItemFormModel
            {
            });

        [HttpPost]
        public async Task<IActionResult> Edit(AddCharityItemFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.charityItem.EditAsync(
                model.Name,
                model.Price,
                model.Description,
                model.ImageUrl,
                model.Quantity);
               

            return this.View();
        }

    }
}
