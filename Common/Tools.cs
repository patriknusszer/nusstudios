using System.IO;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace Nusstudios.Common
{
    public class Tools
    {
        public static IWebHostEnvironment Environment;

        public static string QueryProcessed(string publication) {
            string odbpath = Path.Combine(Environment.WebRootPath, "publications", publication + ".txt");
            string content = File.ReadAllText(odbpath).Replace("<", "&lt;").Replace(">", "&gt;").Replace("\n", "<br>\n");
            return content;
        }

        public static string GetCookieValue(HttpRequest request, string cookieName)
        {
            foreach (var headers in request.Headers.Values)
                foreach (var header in headers)
                    if (header.StartsWith($"{cookieName}="))
                    {
                        var p1 = header.IndexOf('=');
                        var p2 = header.IndexOf(';');
                        return header.Substring(p1 + 1, p2 - p1 - 1);
                    }
            return null;
        }
    }
}
