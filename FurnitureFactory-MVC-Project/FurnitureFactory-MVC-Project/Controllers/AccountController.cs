namespace FurnitureFactory_MVC_Project.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
