using Microsoft.AspNetCore.Mvc;

namespace MatbaaAtolyesi.Frontend.ViewComponents.UILayoutViewComponents;

public class _BlogUILayoutComponentPartial : ViewComponent
{
     public IViewComponentResult Invoke()
     {
          return View();
     }
}