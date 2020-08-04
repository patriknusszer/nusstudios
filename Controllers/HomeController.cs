using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Nusstudios.Models;
using Nusstudios.Common;

namespace Nusstudios.Controllers
{
    public class HomeController : Controller
    {
        [Route("{gb?}")]
        [Route("")]
        public IActionResult Index(bool? gb)
        {
            string val;
            return View(new HomeViewModel("Nusstudios", "https://nusstudios.com", true, false, false, false, false, false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult Blog(bool? gb)
        {
            string val;
            return View(new HomeViewModel("Blog", "https://nusstudios.com/Home/Blog", false, true, false, false, false, false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult Projects(bool? gb)
        {
            string val;
            bool isgb = gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val));
            return View(new HomeViewModel(isgb ? "Projects" : "Projektek", "https://nusstudios.com/Home/Projects", false, false, true, false, false, false, false, isgb));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult Reference(bool? gb)
        {
            string val;
            bool isgb = gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val));
            return View(new HomeViewModel(isgb ? "Reference" : "Referenciáim", "https://nusstudios.com/Home/Reference", false, false, false, true, false, false, false, isgb));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult NussAPI(bool? gb)
        {
            string val;
            return View(new HomeViewModel("NussAPI", "https://nusstudios.com/Home/NussAPI", false, false, false, false, true, false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        /* public IActionResult PT4ZSB()
        {
            // ViewData["Message"] = "All Reference.";
            return View();
        } */

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult Edu(bool? gb)
        {
            string val;
            bool isgb = gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val));
            return View(new HomeViewModel(isgb ? "Private tutoring" : "Magántanítás", "https://nusstudios.com/Home/Edu", false, false, false, false, false, true, false, isgb));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult Contact(bool? gb)
        {
            string val;
            bool isgb = gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val));
            return View(new HomeViewModel(isgb ? "Contact" : "Kapcsolat", "https://nusstudios.com/Home/Contact", false, false, false, false, false, false, true, isgb));
        }
    }
}
