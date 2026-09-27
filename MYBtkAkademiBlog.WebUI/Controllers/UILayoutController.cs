using Microsoft.AspNetCore.Mvc;

namespace MYBtkAkademiBlog.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
