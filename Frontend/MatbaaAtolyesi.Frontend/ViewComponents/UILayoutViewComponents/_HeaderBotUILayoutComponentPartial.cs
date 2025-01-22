using Microsoft.AspNetCore.Mvc;

namespace MatbaaAtolyesi.Frontend.ViewComponents.UILayoutViewComponents;

public class _HeaderBotUILayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}