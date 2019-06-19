using HotelApp.Models;
using System.Configuration;
using System.Web.Mvc;

namespace HotelApp.Controllers
{
    public class HotelController : Controller
    {
        [HttpGet]
        public ActionResult CountLights()
        {
            var defaultGuests = long.Parse(ConfigurationManager.AppSettings["DefaultGuests"] ?? "0");
            var defaultRooms = long.Parse(ConfigurationManager.AppSettings["DefaultRooms"] ?? "0");

            return View(new Hotel() { Guests = defaultGuests, Rooms = defaultRooms });
        }

        [HttpPost]
        public ActionResult CountLights(Hotel model)
        {
            return View(model);
        }
    }
}
