namespace CatsProtectionBg.Web.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Services.Moderator;
    using CatsProtectionBg.Web.Models.Orders;
    using Data.Models;
    using Microsoft.AspNetCore.Mvc;
    using Services.Order;
    using Microsoft.AspNetCore.Authorization;
    using Infrastructure.Extensions;
    using System.Linq;

    public class OrdersController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IModeratorCharityItemService charityItems;
        private readonly IOrderService orders;

        public OrdersController(
           UserManager<User> userManager, 
            IModeratorCharityItemService charityItems,
            IOrderService orders)
        {
            this.userManager = userManager;
            this.charityItems = charityItems;
            this.orders = orders;
        }
    }
}
