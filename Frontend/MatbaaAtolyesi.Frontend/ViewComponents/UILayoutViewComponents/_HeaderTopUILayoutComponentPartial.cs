using Microsoft.AspNetCore.Mvc;

namespace MatbaaAtolyesi.Frontend.ViewComponents.UILayoutViewComponents;

public class _HeaderTopUILayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}