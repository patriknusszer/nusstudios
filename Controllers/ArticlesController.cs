using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Nusstudios.Common;
using Nusstudios.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nusstudios.Controllers
{
    public class ArticlesController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context) => base.OnActionExecuting(context);

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult dijkstra(bool? gb)
        {
            string val;
            bool isgb = gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val));
            return View(new ArticlesViewModel(isgb ? "Dijkstra's shortest path" : "Dijkstra: legrövidebb útvonal", "https://nusstudios.com/Articles/dijkstra", false, false, isgb));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult heapsort(bool? gb)
        {
            string val;
            bool isgb = gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val));
            return View(new ArticlesViewModel(isgb ? "Heapsort" : "Kupacrendezés", "https://nusstudios.com/Articles/heapsort", false, false, isgb));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult mergesort(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel("Mergesort", "https://nusstudios.com/Articles/mergesort", false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult knuthmorrispratt(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel("Knuth-Morris-Pratt", "https://nusstudios.com/Articles/knuthmorrispratt", false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult floydstortoiseandhare(bool? gb)
        {
            string val;
            bool isgb = gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val));
            return View(new ArticlesViewModel(isgb ? "Floyd's tortoise and hare" : "Floyd: teknős és nyúl", "https://nusstudios.com/Articles/floydstortoiseandhare", false, true, isgb));
        }

        // GET: /<controller>/
        [Route("{controller}/{action}/{gb?}")]
        public IActionResult transformers_game_configurations_low_level(bool? gb)
        {
            string val;
            bool isgb = gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val));
            return View(new ArticlesViewModel(isgb ? "TF configs" : "TF konfigok", "https://nusstudios.com/Articles/transformers_game_configurations_low_level", false, false, isgb));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult youtube_ciphered_signatures(bool? gb)
        {
            string val;
            bool isgb = gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val));
            return View(new ArticlesViewModel(isgb ? "Youtube ciphered signatures" : "Youtube titkosított aláírások", "https://nusstudios.com/Articles/youtube_ciphered_signatures", false, true, isgb));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult graph_api_and_x_instagram_gis(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel("Graph API & X-Instagram-GIS", "https://nusstudios.com/Articles/graph_api_and_x_instagram_gis", false, true, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult paradigms_brief_history(bool? gb)
        {
            string val;
            bool isgb = gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val));
            return View(new ArticlesViewModel(isgb ? "Paradigms' history" : "A paradigmák története", "https://nusstudios.com/Articles/paradigms_brief_history", false, false, isgb));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult high_level_languages_behind_the_scenes(bool? gb)
        {
            string val;
            bool isgb = gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val));
            return View(new ArticlesViewModel(isgb ? "High level languages" : "Magasszintű nyelvek", "https://nusstudios.com/Articles/high_level_languages_behind_the_scenes", false, false, isgb));
        }
    }
}
