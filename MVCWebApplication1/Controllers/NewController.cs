using Microsoft.AspNetCore.Mvc;

namespace MVCWebApplication1.Controllers
{
    [Route("[controller]")]
    public class NewController : Controller
    {
        
    [Route("Welcome")]
    public IActionResult Welcome()
    {
        return View();
    }
}
}
