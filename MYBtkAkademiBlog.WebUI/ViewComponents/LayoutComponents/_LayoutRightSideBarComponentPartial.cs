using Microsoft.AspNetCore.Mvc;

namespace MYBtkAkademiBlog.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutRightSideBarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
