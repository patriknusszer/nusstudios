using System;
namespace Nusstudios.Models
{
    public class ArticlesViewModel
    {
        public ArticlesViewModel(string baseurl)
        {
            BaseURL = baseurl;
            BlogSelected = false;
            ReferenceSelected = true;
        }

        public ArticlesViewModel(string baseurl, bool hasAbout, bool hasDownload, bool gb)
        {
            BaseURL = baseurl;
            BlogSelected = true;
            ReferenceSelected = false;
            HasAbout = hasAbout;
            HasDownload = hasDownload;
            GB = gb;
        }

        public string BaseURL;
        public bool BlogSelected;
        public bool ReferenceSelected;
        public bool HasAbout;
        public bool HasDownload;
        public bool GB;
    }
}
