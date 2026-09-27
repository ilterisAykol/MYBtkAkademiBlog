using Microsoft.AspNetCore.Mvc;

namespace MYBtkAkademiBlog.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultTrendingStoriesArticlesComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
