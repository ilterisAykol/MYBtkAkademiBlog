using Microsoft.AspNetCore.Mvc;

namespace MYBtkAkademiBlog.WebUI.ViewComponents.SecondFeaturePostComponents
{
    public class _SecondFeaturePostComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
