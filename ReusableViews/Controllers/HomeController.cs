using System.Web.Mvc;

namespace ReusableViews.Controllers
{
    public class HomeController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
    }
}