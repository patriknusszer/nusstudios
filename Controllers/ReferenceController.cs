using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;

// Additional namespaces
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Nusstudios.Controllers
{
    [Route("[controller]")]
    public class ReferenceController : Controller
    {
        private IWebHostEnvironment _env;

        public ReferenceController(IWebHostEnvironment env) => _env = env;

        [EnableCors("AnyOrigin")]
        [HttpGet("[action]")]
        public string getreferences(int id)
        {
            string refpath = System.IO.Path.Combine(_env.WebRootPath, "auditing", "references.json");
            return System.IO.File.ReadAllText(refpath);
        }
    }
}
