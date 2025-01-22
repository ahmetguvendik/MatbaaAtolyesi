using Microsoft.AspNetCore.Mvc;

namespace MatbaaAtolyesi.Frontend.ViewComponents.UILayoutViewComponents;

public class _MenuUILayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
         return View();
    }
}