using Microsoft.AspNetCore.Mvc;

namespace MYBtkAkademiBlog.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultGetCategoriesWithLastArticleComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
