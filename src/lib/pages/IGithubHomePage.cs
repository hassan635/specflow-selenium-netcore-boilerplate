using System;
namespace specflow_selenium_netcore_boilerplate.src.lib.pages
{
    public interface IGithubHomePage
    {
        IGithubHomePage Open();
        IGithubHomePage Search(string query);
    }
}
