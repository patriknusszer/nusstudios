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
            return View(new HomeViewModel(true, false, false, false, false, false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult Blog(bool? gb)
        {
            string val;
            return View(new HomeViewModel(false, true, false, false, false, false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult Softwares(bool? gb)
        {
            string val;
            return View(new HomeViewModel(false, false, true, false, false, false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult Reference(bool? gb)
        {
            string val;
            return View(new HomeViewModel(false, false, false, true, false, false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult NussAPI(bool? gb)
        {
            string val;
            return View(new HomeViewModel(false, false, false, false, true, false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
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
            return View(new HomeViewModel(false, false, false, false, false, true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult Contact(bool? gb)
        {
            string val;
            return View(new HomeViewModel(false, false, false, false, false, false, true, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }
    }
}
