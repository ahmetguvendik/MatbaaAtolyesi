using Microsoft.AspNetCore.Mvc;

namespace MatbaaAtolyesi.Frontend.ViewComponents.UILayoutViewComponents;

public class _FooterUILayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}