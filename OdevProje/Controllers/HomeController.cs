using Microsoft.AspNetCore.Mvc;
using OdevProje.Models;

namespace OdevProje.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Player(int id)
        {

            Users user = new();

            user.UserId = 112211;
            user.FullName = "Mehmet Asker";
            user.Username = "AmazonZoe";
            user.Email = "aksaka7@gmail.com";
            user.City = "Beþ Aslan";

            return View(user);
        }
        
    }
}
