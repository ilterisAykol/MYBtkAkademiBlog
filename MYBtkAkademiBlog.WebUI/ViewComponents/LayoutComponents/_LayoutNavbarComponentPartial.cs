using Microsoft.AspNetCore.Mvc;

namespace MYBtkAkademiBlog.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
