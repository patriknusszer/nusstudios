using System;

namespace Nusstudios.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(
            string title,
            string baseurl,
            bool homeSelected,
            bool blogSelected,
            bool projectsSelected,
            bool referenceSelected,
            bool nussapiSelected,
            bool eduSelected,
            bool contactSelected,
            bool gb
            )
        {
            Title = title;
            BaseURL = baseurl;
            HomeSelected = homeSelected;
            BlogSelected = blogSelected;
            ProjectsSelected = projectsSelected;
            ReferenceSelected = referenceSelected;
            NussAPISelected = nussapiSelected;
            EduSelected = eduSelected;
            ContactSelected = contactSelected;
            GB = gb;
        }

        public string Title;
        public string BaseURL;
        public bool HomeSelected;
        public bool BlogSelected;
        public bool ProjectsSelected;
        public bool ReferenceSelected;
        public bool NussAPISelected;
        public bool EduSelected;
        public bool ContactSelected;
        public bool GB;
    }
}
