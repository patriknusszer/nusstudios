using Microsoft.AspNetCore.Mvc;

namespace Nusstudios.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HomeSelected = true;
            ViewBag.BlogSelected = false;
            ViewBag.SoftwaresSelected = false;
            ViewBag.ReferenceSelected = false;
            ViewBag.NussAPISelected = false;
            ViewBag.EduSelected = false;
            ViewBag.ContactSelected = false;
            return View();
        }

        public IActionResult Blog() {
            ViewData["Message"] = "All posts";
            ViewBag.HomeSelected = false;
            ViewBag.BlogSelected = true;
            ViewBag.SoftwaresSelected = false;
            ViewBag.ReferenceSelected = false;
            ViewBag.NussAPISelected = false;
            ViewBag.EduSelected = false;
            ViewBag.ContactSelected = false;
            return View();
        }

        public IActionResult Softwares()
        {
            ViewBag.HomeSelected = false;
            ViewBag.BlogSelected = false;
            ViewBag.SoftwaresSelected = true;
            ViewBag.ReferenceSelected = false;
            ViewBag.NussAPISelected = false;
            ViewBag.EduSelected = false;
            ViewBag.ContactSelected = false;
            ViewBag.Selection = "Softwares";
            ViewData["Message"] = "All projects";
            return View();
        }

        public IActionResult Reference()
        {
            ViewBag.HomeSelected = false;
            ViewBag.BlogSelected = false;
            ViewBag.SoftwaresSelected = false;
            ViewBag.ReferenceSelected = true;
            ViewBag.NussAPISelected = false;
            ViewBag.EduSelected = false;
            ViewBag.ContactSelected = false;
            ViewBag.Selection = "Referenciáim";
            ViewData["Message"] = "Referenciáim";
            return View();
        }

        public IActionResult NussAPI()
        {
            ViewBag.HomeSelected = false;
            ViewBag.BlogSelected = false;
            ViewBag.SoftwaresSelected = false;
            ViewBag.ReferenceSelected = false;
            ViewBag.NussAPISelected = true;
            ViewBag.EduSelected = false;
            ViewBag.ContactSelected = false;
            ViewBag.Selection = "NussAPI";
            // ViewData["Message"] = "All Reference.";
            return View();
        }

        /* public IActionResult PT4ZSB()
        {
            // ViewData["Message"] = "All Reference.";
            return View();
        } */

        /* public IActionResult Log()
        {
            ViewData["Message"] = "Nusstudios website log.";
            return View();
        } */

        public IActionResult Edu()
        {
            ViewBag.HomeSelected = false;
            ViewBag.BlogSelected = false;
            ViewBag.SoftwaresSelected = false;
            ViewBag.ReferenceSelected = false;
            ViewBag.NussAPISelected = false;
            ViewBag.EduSelected = true;
            ViewBag.ContactSelected = false;
            ViewBag.Selection = "Edu";
            ViewData["Message"] = "C#, Java magántanítás";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.HomeSelected = false;
            ViewBag.BlogSelected = false;
            ViewBag.SoftwaresSelected = false;
            ViewBag.ReferenceSelected = false;
            ViewBag.NussAPISelected = false;
            ViewBag.EduSelected = false;
            ViewBag.ContactSelected = true;
            ViewBag.Selection = "Contact";
            ViewData["Message"] = "Contact me.";
            return View();
        }
    }
}
