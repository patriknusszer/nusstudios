using System;
namespace Nusstudios.Models
{
    public class ArticleViewModel
    {
        public ArticleViewModel(string baseurl)
        {
            BaseURL = baseurl;
            BlogSelected = false;
            ReferenceSelected = true;
        }

        public ArticleViewModel(string title, string baseurl, bool hasAbout, bool hasDownload, bool gb)
        {
            Title = title;
            BaseURL = baseurl;
            BlogSelected = true;
            ReferenceSelected = false;
            HasAbout = hasAbout;
            HasDownload = hasDownload;
            GB = gb;
        }

        public string Title;
        public string BaseURL;
        public bool BlogSelected;
        public bool ReferenceSelected;
        public bool HasAbout;
        public bool HasDownload;
        public bool GB;
    }
}
