using System;
using System.Collections.Generic;
using specflow_selenium_netcore_boilerplate.src.lib.pages;

namespace specflow_selenium_netcore_boilerplate.src.lib.api
{
    public class GetUserRepositories
    {
        private IGithubHomePage _githubHomePage = null;
        private IRepositoryPage _repositoryPage = null;

        public GetUserRepositories(IGithubHomePage githubHomePage, IRepositoryPage repositoryPage)
        {
            _githubHomePage = githubHomePage;
            _repositoryPage = repositoryPage;
        }

        public List<string> GetRepositoriesByUsername(string username)
        {
            _githubHomePage.Open().Search(username);
            //TODO: get list of repo name here
            return null;
        }
    }
}
