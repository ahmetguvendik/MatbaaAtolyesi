using Microsoft.AspNetCore.Mvc;

namespace MatbaaAtolyesi.Frontend.ViewComponents.UILayoutViewComponents;

public class _ProductUILayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}