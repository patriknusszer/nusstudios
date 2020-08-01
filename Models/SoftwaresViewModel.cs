using System;
namespace Nusstudios.Models
{
    public class SoftwaresViewModel
    {
        public SoftwaresViewModel(
            string baseurl,
            bool hasRelease,
            bool hasExtraInfo,
            bool gb
            )
        {
            BaseURL = baseurl;
            HasRelease = hasRelease;
            hasExtraInfo = HasExtraInfo;
            GB = gb;
        }

        public string BaseURL;
        public bool HasRelease;
        public bool HasExtraInfo;
        public bool GB;
    }
}
