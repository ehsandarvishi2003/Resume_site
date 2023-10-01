#region Using
using Microsoft.AspNetCore.Mvc;
#endregion
namespace Resume_site.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
