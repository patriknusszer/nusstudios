using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Nusstudios.Controllers
{
    public class ModsController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            ViewBag.ModsSelected = true;
            ViewBag.BlogSelected = false;
        }

        // GET: /<controller>/
        public IActionResult mod_tfocultimate()
        {
            ViewBag.HasAbout = true;
            ViewBag.HasDownload = true;
            return View();
        }

        public IActionResult mod_tfoccorruptor()
        {
            ViewBag.HasAbout = true;
            ViewBag.HasDownload = true;
            return View();
        }

        public IActionResult mod_tfocdecorruptor()
        {
            ViewBag.HasAbout = true;
            ViewBag.HasDownload = true;
            return View();
        }

        public IActionResult mod_twfcultimate()
        {
            ViewBag.HasAbout = true;
            ViewBag.HasDownload = true;
            return View();
        }

        public IActionResult mod_trotdsdlc()
        {
            ViewBag.HasAbout = true;
            ViewBag.HasDownload = true;
            return View();
        }

		public IActionResult mod_royswap_javafx()
		{
            ViewBag.HasAbout = false;
            ViewBag.HasDownload = true;
            return View();
		}
    }
}
