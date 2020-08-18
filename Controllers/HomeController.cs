using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
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
            return View
                (
                    new ArticlesViewModel
                    (
                        "Blog",
                        "https://nusstudios.com/Home/Blog",
                        false, true, false, false, false, false, false,
                        gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? (bool)(gb = false) : (bool)(gb = bool.Parse(val))),
                        new List<Article>
                        {
                            new Article("knuthmorrisspratt", (bool)gb ? "Knuth-Morris-Pratt algorithm" : "Knuth-Morris-Pratt algoritmus"),
                            new Article("floydstortoiseandhare", (bool)gb ? "Floyd's tortoise and hare" : "Floyd teknős & nyúl algoritmusa"),
                            new Article("mergesort", (bool)gb ? "Mergesort of Neummann János" : "Mergesort"),
                            new Article("heapsort", (bool)gb ? "Heapsort of J.W.J Williams" : "Kupacrendezés"),
                            new Article("dijkstra", (bool)gb ? "Dijkstra's shortest path" : "Dijkstra legrövidebb út kereső")
                        },
                        new List<Article>
                        {
                            new Article("paradigms_brief_history", (bool)gb ? "History of programming paradigms" : "A programozási paradigmák története"),
                            new Article("high_level_languages_behind_the_scenes", (bool)gb ? "High level languages: behind the scenes" : "Magas szintű nyelvek a kulisszák mögött")
                        },
                        new List<Article>
                        {
                            new Article("transformers_game_configurations_low_level", (bool)gb ? "Transformers games INI/INT configurations low level" : "Transformeres játékok konfigurációi alacsony szinten"),
                            new Article("youtube_ciphered_signatures", "Youtube ciphered signatures today"),
                            new Article("graph_api_and_x_instagram_gis", "Graph API and X-Instagram-GIS")
                        }
                    )
            );
        }

        [Route("{controller}/{action}/{gb?}")]
        public IActionResult Projects(bool? gb)
        {
            string val;
            bool isgb = gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val));
            return View(
                new ProjectsViewModel(
                    isgb ? "Projects" : "Projektek",
                    "https://nusstudios.com/Home/Projects",
                    false, false, true, false, false, false, false, isgb,
                    new List<Project> {
                        new Project("nuss", "Nuss Youtube downloader"),
                        new Project("nussdesktop_javafx", "Nuss Youtube downloader JavaFx"),
                        new Project("nusstumblr", "Nusstmblr"),
                        new Project("instarchiver", "Instagram archiver"),
                        new Project("imagetopdfui", "Image to PDF UI"),
                        new Project("gia", "Google Image Archiver")
                    },
                    new List<Project> {
                        new Project("cupmixer", "Cup Mixer")
                    },
                    new List<Project> {
                        new Project("torrentchk", "Torrentchk"),
                        new Project("CPPO", "C++ object library"),
                        new Project("pixie", "Pixie"),
                        new Project("pixie_macos", "Pixie for macOS"),
                        new Project("tfutilpp", "TF_games_Util++"),
                        new Project("imgtopdf", "Image to PDF console"),
                        new Project("stringmath", "StringMath library"),
                        new Project("jcore", "JCore Library"),
                        new Project("nusstudioscorecsharp", "Nusstudios.Core Library C#"),
                        new Project("keylogger", "Key Logger"),
                        new Project("lilcryptoc", "lilcryptoc"),
                        new Project("lilcryptocpp", "lilcryptocpp"),
                        new Project("swifflib", "SwiffLib"),
                        new Project("hashcompare", "hashcompare"),
                        new Project("equslvr", "equslvr")
                    }
                )
            );
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
