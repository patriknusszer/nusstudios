using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

// Addiitonal namespaces
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Nusstudios.Controllers
{
    [Route("[controller]")]
    public class NussAPIController : Controller
    {
        private static JArray getalgo()
        {
            JArray actionList = new JArray();
            actionList.Add(17772);
            JObject action = new JObject();
            action["parameter"] = 1;
            action["action"] = "splice";
            actionList.Add(action);
            action = new JObject();
            action["parameter"] = 33;
            action["action"] = "swap";
            actionList.Add(action);
            action = new JObject();
            action["parameter"] = 2;
            action["action"] = "splice";
            actionList.Add(action);
            action = new JObject();
            action["parameter"] = null;
            action["action"] = "reverse";
            actionList.Add(action);
            action = new JObject();
            action["parameter"] = 2;
            action["action"] = "splice";
            actionList.Add(action);
            action = new JObject();
            action["parameter"] = 23;
            action["action"] = "swap";
            actionList.Add(action);
            action = new JObject();
            action["parameter"] = null;
            action["action"] = "reverse";
            actionList.Add(action);
            action["parameter"] = 43;
            action["action"] = "swap";
            actionList.Add(action);
            action = new JObject();
            action["parameter"] = null;
            action["action"] = "reverse";
            actionList.Add(action);
            return actionList;
        }

        private static JObject GetVimeoVideoInfo(int id)
        {
            HttpClient hc = new HttpClient();
            string html = hc.GetStringAsync("https://vimeo.com/" + id).Result;
            List<string> VimeoVideoPageStreamConfigRegexes = new List<string>();
            VimeoVideoPageStreamConfigRegexes.Add("\"\\s*?config_url\\s*?\"\\s*?:\\s*?\"\\s*?(.*?)\\s*?\"");
            VimeoVideoPageStreamConfigRegexes.Add("data-config-url\\s*?=\\s*?\"\\s*?(.*?)\"");

            foreach (string regstr in VimeoVideoPageStreamConfigRegexes)
            {
                Regex rgx = new Regex(regstr);
                Match mtch = rgx.Match(html);

                if (mtch.Success)
                {
                    string originalConfigURL = Regex.Unescape(mtch.Groups[1].Value);
                    return JObject.Parse(hc.GetStringAsync(originalConfigURL).Result);
                }
            }

            return JObject.Parse(hc.GetStringAsync("https://player.vimeo.com/video/" + id + "/config").Result);
        }

        private static JObject ReloadVimeoVideoInfo(JObject config)
        {
            var vimeoVideoInfo = new JObject();
            // Adding vimeo video id and video count
            vimeoVideoInfo["id"] = config["video"]["id"];
            vimeoVideoInfo["title"] = config["video"]["title"];
            JArray fullStreamMap = (JArray)config["request"]["files"]["progressive"];
            var streamArray = new JArray();

            for (var i = 0; i < fullStreamMap.Count; i++)
            {
                var streamData = new JObject();
                streamData["fps"] = fullStreamMap[i]["fps"];
                streamData["height"] = fullStreamMap[i]["geight"];
                streamData["mime"] = fullStreamMap[i]["mime"];
                streamData["quality"] = fullStreamMap[i]["quality"];
                streamData["url"] = fullStreamMap[i]["url"];
                streamArray.Add(streamData);
            }

            vimeoVideoInfo["streams"] = streamArray;
            return vimeoVideoInfo;
        }

        [EnableCors("AnyOrigin")]
        [HttpGet("[action]/{id:int}")]
        public string vimeoquery(int id)
        {
            return ReloadVimeoVideoInfo(GetVimeoVideoInfo(id)).ToString();
        }

        [EnableCors("AnyOrigin")]
        [HttpGet("[action]")]
        public JArray queryalgo() {
            return getalgo();
        }
    }
}
