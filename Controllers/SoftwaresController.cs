using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nusstudios.Models;
using Nusstudios.Common;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Nusstudios.Controllers
{
    public class SoftwaresController : Controller
    {
        [Route("{gb?}")]
        public IActionResult CPPO(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/CPPO", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult nuss(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/nuss", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult nussdesktop(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/nussdesktop", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

		public IActionResult nussdesktop_javafx(bool? gb)
		{
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/nussdesktop_javafx", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

		public IActionResult swifflib(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/swifflib", true, true, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult equslvr(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/equslvr", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult cupmixer(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/cupmixer", false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult gia(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/gia", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult nussattribute(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/nussattribute", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult stringmath(bool? gb)
		{
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/stringmath", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

		public IActionResult stringmath_python(bool? gb)
		{
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/stringmath_python", false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

		public IActionResult jcore(bool? gb)
		{
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/jcore", false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult nusstudioscorecsharp(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/nusstudioscorecsharp", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult imgtopdfui(bool? gb)
		{
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/imgtopdfui", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

		public IActionResult imgtopdf(bool? gb)
		{
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/imgtopdf", false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

		public IActionResult spltoemf(bool? gb)
		{
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/spltoemf", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult nusstumblr(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/nusstumblr", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

		public IActionResult instarchiver(bool? gb)
		{
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/instarchiver", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult pixie(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/pixie", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult pixie_macos(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/pixie_macos", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult tfutilpp(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/tfutilpp", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult keylogger(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/keylogger", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult xorcrypt(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/xorcrypt", false, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult lilcryptoc(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/lilcryptoc", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult lilcryptocpp(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/lilcryptocpp", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }

        public IActionResult torrentchk(bool? gb)
        {
            string val;
            return View(new SoftwaresViewModel("https://nusstudios.com/Softwares/torrentchk", true, false, gb != null ? (bool)gb : ((val = Tools.GetCookieValue(Request, "gb")) == null ? false : bool.Parse(val))));
        }
    }
}
