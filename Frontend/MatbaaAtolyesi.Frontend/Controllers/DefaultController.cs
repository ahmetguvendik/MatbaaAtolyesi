using Microsoft.AspNetCore.Mvc;

namespace MatbaaAtolyesi.Frontend.Controllers;

public class DefaultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}