using Microsoft.AspNetCore.Mvc;

namespace Triangular.Web.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View("/Pages/Index.cshtml");
        }
    }
}