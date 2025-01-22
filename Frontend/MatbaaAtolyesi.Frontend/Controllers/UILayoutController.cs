using Microsoft.AspNetCore.Mvc;

namespace MatbaaAtolyesi.Frontend.Controllers;

public class UILayoutController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}