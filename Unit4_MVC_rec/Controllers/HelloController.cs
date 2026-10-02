using Microsoft.AspNetCore.Mvc;

namespace Unit4_MVC_rec.Controllers
{
    public class HelloController : Controller
    {
        // GET: HelloController
        public ActionResult Index()
        {
            return View();
        }

    }
}
