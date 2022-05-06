using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        public static string newFood = "";
        public static List<string> foods = new List<string>();

        public IActionResult Index()
        {
            ViewBag.Foods = foods;
            if(newFood != "")
            {
                ViewBag.Foods.Add(newFood);
            }
            return View();
        }
        [HttpGet]
        public IActionResult FormDisplay()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/FormDisplay")]
        public IActionResult FormPost(string inputName = "Avocado Toast")
        {
            newFood = inputName;
            return Redirect("/Events");
        }
    }
}
