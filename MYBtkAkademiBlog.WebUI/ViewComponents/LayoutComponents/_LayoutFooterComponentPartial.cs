using Microsoft.AspNetCore.Mvc;

namespace MYBtkAkademiBlog.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
