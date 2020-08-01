using System;

namespace Nusstudios.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(
            string baseurl,
            bool homeSelected,
            bool blogSelected,
            bool softwaresSelected,
            bool referenceSelected,
            bool nussapiSelected,
            bool eduSelected,
            bool contactSelected,
            bool gb
            )
        {
            BaseURL = baseurl;
            HomeSelected = homeSelected;
            BlogSelected = blogSelected;
            SoftwaresSelected = softwaresSelected;
            ReferenceSelected = referenceSelected;
            NussAPISelected = nussapiSelected;
            EduSelected = eduSelected;
            ContactSelected = contactSelected;
            GB = gb;
        }

        public string BaseURL;
        public bool HomeSelected;
        public bool BlogSelected;
        public bool SoftwaresSelected;
        public bool ReferenceSelected;
        public bool NussAPISelected;
        public bool EduSelected;
        public bool ContactSelected;
        public bool GB;
    }
}
