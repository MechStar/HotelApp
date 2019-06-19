using System.Web.Mvc;

namespace HotelApp.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult NotFound()
        {
            return View();
        }
    }
}
