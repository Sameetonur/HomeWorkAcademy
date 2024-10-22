using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public ActionResult Index()
        {
            return View();
        }

    }
}
