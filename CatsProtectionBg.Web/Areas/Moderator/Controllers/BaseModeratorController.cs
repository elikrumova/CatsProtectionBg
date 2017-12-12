using Microsoft.AspNetCore.Authorization;

namespace CatsProtectionBg.Web.Areas.Moderator.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Area("Moderator")]
    [Authorize(Roles = WebConstants.ModeratorRole)]
    public class BaseModeratorController : Controller
    {

    }
}
