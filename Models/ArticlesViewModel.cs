using System.Collections.Generic;

namespace Nusstudios.Models
{
    public class Article
    {
        public Article(string action, string desc)
        {
            Action = action;
            Description = desc;
        }

        public string Action;
        public string Description;
    }

    public class ArticlesViewModel : HomeViewModel
    {
        public List<Article> Algorithms;
        public List<Article> Abstract;
        public List<Article> Documentation;

        public ArticlesViewModel(
            string title,
            string baseurl,
            bool homeSelected,
            bool blogSelected,
            bool projectsSelected,
            bool referenceSelected,
            bool nussapiSelected,
            bool eduSelected,
            bool contactSelected,
            bool gb,
            List<Article> algorithms,
            List<Article> abs,
            List<Article> documentation
            ) : base(title,
            baseurl,
            homeSelected,
            blogSelected,
            projectsSelected,
            referenceSelected,
            nussapiSelected,
            eduSelected,
            contactSelected,
            gb)
        {
            Algorithms = algorithms;
            Abstract = abs;
            Documentation = documentation;
        }
    }
}
