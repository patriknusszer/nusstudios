using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nusstudios.Controllers
{
    [Route("[controller]")]
    public class PT4ZSBController : Controller
    {
        private IWebHostEnvironment _env;

        public PT4ZSBController(IWebHostEnvironment env)
        {
            _env = env;
        }

        // GET: /<controller>/
        [HttpGet("[action]")]
        public IActionResult plus_zsb()
        {
            string odbpath = Path.Combine(_env.WebRootPath, "auditing", "pt4zsb.odb");
            string content = System.IO.File.ReadAllText(odbpath);
            string[] arr = content.Split(new string[] { "<SEPARATOR>" }, StringSplitOptions.None);
            string final = "";

            if (arr.Length != 2)
            {
                final = "1<SEPARATOR>" + Request.Headers["User-Agent"] + "<SEPCLIENT>";
            }
            else
            {
                arr[0] = (Convert.ToUInt64(arr[0]) + 1).ToString();
                arr[1] += Request.Headers["User-Agent"] + "<SEPCLIENT>";
                final = String.Join("<SEPARATOR>", arr);
            }

            System.IO.File.WriteAllText(odbpath, final);
            Response.Cookies.Append("Voted", "True");
            return RedirectToAction("PT4ZSB", "Home");
        }

        [HttpGet("[action]")]
        public string get_zsb()
        {
            string odbpath = Path.Combine(_env.WebRootPath, "auditing", "pt4zsb.odb");
            string content = System.IO.File.ReadAllText(odbpath);
            return content.Split(new string[] { "<SEPARATOR>" }, StringSplitOptions.None)[0];
        }
    }
}
