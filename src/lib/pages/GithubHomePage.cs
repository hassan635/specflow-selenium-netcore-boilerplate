using System;
using OpenQA.Selenium;
using specflow_selenium_netcore_boilerplate.src.lib.helpers;

namespace specflow_selenium_netcore_boilerplate.src.lib.pages
{
    public class GithubHomePage : IGithubHomePage
    {
        private IWebDriver _driver = null;

        public GithubHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IGithubHomePage Open()
        {
            _driver.Navigate().GoToUrl(TestSettingsManager.GetSetting("GITHUB_URL"));
            
            //ensure that the page has indeed opened
            if(!_driver.FindElement(By.Name("q"), 5).Displayed) 
            throw new Exception("expected UI element not found");

            return this;
        }

        public IGithubHomePage Search(string query)
        {
            _driver.FindElement(By.Name("q"), 5).SendKeys(query);
            return this;
        }
    }
}
