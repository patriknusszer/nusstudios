using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Nusstudios.Controllers
{
    public class SoftwaresController : Controller
    {
        // GET: /<controller>/
        public IActionResult product_CPPO()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_nuss()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_nussdesktop()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

		public IActionResult product_nussdesktop_javafx()
		{
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
		}

		public IActionResult product_swifflib()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = true;
            return View();
        }

        public IActionResult product_equslvr()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_cupmixer()
        {
            ViewBag.HasRelease = false;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_gia()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_nussattribute()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_stringmath()
		{
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

		public IActionResult product_stringmath_python()
		{
            ViewBag.HasRelease = false;
            ViewBag.HasExtraInfo = false;
            return View();
        }

		public IActionResult product_jcore()
		{
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
		}

        public IActionResult product_nusstudioscorecsharp()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_imgtopdfui()
		{
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
		}

		public IActionResult product_imgtopdf()
		{
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
		}

		public IActionResult product_spltoemf()
		{
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
		}

        public IActionResult product_nusstumblr()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

		public IActionResult product_instarchiver()
		{
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
		}

        public IActionResult product_pixie()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_pixie_macos()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_tfutilpp()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_keylogger()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_xorcrypt()
        {
            ViewBag.HasRelease = false;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_lilcrypto()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_lilcryptoc()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_lilcryptocpp()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }

        public IActionResult product_torrentchk()
        {
            ViewBag.HasRelease = true;
            ViewBag.HasExtraInfo = false;
            return View();
        }
    }
}
