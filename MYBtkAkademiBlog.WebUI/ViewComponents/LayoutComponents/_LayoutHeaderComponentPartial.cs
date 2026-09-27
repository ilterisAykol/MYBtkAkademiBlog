using Microsoft.AspNetCore.Mvc;

namespace MYBtkAkademiBlog.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
