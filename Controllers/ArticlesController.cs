using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nusstudios.Controllers
{
    public class ArticlesController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            ViewBag.ReferenceSelected = false;
            ViewBag.BlogSelected = true;
        }

        public IActionResult dijkstra()
        {
            ViewBag.HasAbout = false;
            ViewBag.HasDownload = false;
            return View();
        }

        public IActionResult heapsort()
        {
            ViewBag.HasAbout = false;
            ViewBag.HasDownload = false;
            return View();
        }

        public IActionResult mergesort()
        {
            ViewBag.HasAbout = false;
            ViewBag.HasDownload = false;
            return View();
        }

        public IActionResult knuthmorrispratt()
        {
            ViewBag.HasAbout = false;
            ViewBag.HasDownload = false;
            return View();
        }

        public IActionResult floydstortoiseandhare()
        {
            ViewBag.HasAbout = false;
            ViewBag.HasDownload = false;
            return View();
        }

        // GET: /<controller>/
        public IActionResult transformers_game_configurations_low_level()
        {
            ViewBag.HasAbout = false;
            ViewBag.HasDownload = false;
            return View();
        }

        public IActionResult youtube_ciphered_signatures()
        {
            ViewBag.HasAbout = false;
            ViewBag.HasDownload = true;
            return View();
        }

        public IActionResult graph_api_and_x_instagram_gis()
        {
            ViewBag.HasAbout = false;
            ViewBag.HasDownload = true;
            return View();
        }

        public IActionResult paradigms_brief_history()
        {
            ViewBag.HasAbout = false;
            ViewBag.HasDownload = false;
            return View();
        }

        public IActionResult high_level_languages_behind_the_scenes()
        {
            ViewBag.HasAbout = false;
            ViewBag.HasDownload = false;
            return View();
        }
    }
}
