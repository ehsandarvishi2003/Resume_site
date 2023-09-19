#region Using
using Microsoft.AspNetCore.Mvc;
#endregion
namespace Resume_site.Controllers
{
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
