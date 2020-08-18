using System;
using System.Collections.Generic;

namespace Nusstudios.Models
{
    public class Project
    {
        public string Action;
        public string Name;

        public Project(string action, string name)
        {
            Action = action;
            Name = name;
        }
    }

    public class ProjectsViewModel : HomeViewModel
    {
        public List<Project> Apps;
        public List<Project> Games;
        public List<Project> Educational;

        public ProjectsViewModel(
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
            List<Project> apps,
            List<Project> games,
            List<Project> educational
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
            Apps = apps;
            Games = games;
            Educational = educational;
        }
    }
}
