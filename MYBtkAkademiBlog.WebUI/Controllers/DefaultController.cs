using Microsoft.AspNetCore.Mvc;

namespace MYBtkAkademiBlog.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
