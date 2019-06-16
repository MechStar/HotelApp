using HotelApp.Models;
using System.Web.Mvc;

namespace HotelApp.Controllers
{
    public class HotelController : Controller
    {
        public ActionResult CountLights(Hotel model)
        {
            return View(model);
        }
    }
}
