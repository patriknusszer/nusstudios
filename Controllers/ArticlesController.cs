﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Nusstudios.Common;
using Nusstudios.Models;

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

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult dijkstra(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel(false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult heapsort(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel(false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult mergesort(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel(false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult knuthmorrispratt(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel(false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult floydstortoiseandhare(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel(false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        // GET: /<controller>/
        [Route("{controller}/{action}/{gb?}")]
        public IActionResult transformers_game_configurations_low_level(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel(false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult youtube_ciphered_signatures(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel(false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult graph_api_and_x_instagram_gis(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel(false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult paradigms_brief_history(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel(false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult high_level_languages_behind_the_scenes(bool? gb)
        {
            string val;
            return View(new ArticlesViewModel(false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }
    }
}
