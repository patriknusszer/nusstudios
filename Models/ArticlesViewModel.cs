using System;
namespace Nusstudios.Models
{
    public class ArticlesViewModel
    {
        public ArticlesViewModel()
        {
            BlogSelected = false;
            ReferenceSelected = true;
        }

        public ArticlesViewModel(bool hasAbout, bool hasDownload, bool gb)
        {
            BlogSelected = true;
            ReferenceSelected = false;
            HasAbout = hasAbout;
            HasDownload = hasDownload;
            GB = gb;
        }

        public bool BlogSelected;
        public bool ReferenceSelected;
        public bool HasAbout;
        public bool HasDownload;
        public bool GB;
    }
}
