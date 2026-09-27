using Microsoft.AspNetCore.Mvc;

namespace MYBtkAkademiBlog.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult ArticleDetail()
        {
            return View();
        }
        public IActionResult ArticleList()
        {
            return View();
        }
        public IActionResult ArticleListByCategory()
        {
            return View();
        }
    }
}
