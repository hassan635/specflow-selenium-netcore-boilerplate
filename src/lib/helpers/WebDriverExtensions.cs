using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace specflow_selenium_netcore_boilerplate.src.lib.helpers
{
    public static class WebDriverExtensions
    {
        private static WebDriverWait wait;

        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

            Func<IWebDriver, IWebElement> waitForElement = (IWebDriver Web) =>
            {
                IWebElement element = Web.FindElement(by);
                if (element.Displayed)
                {
                    return element;
                }
                return null;
            };

            return wait.Until(waitForElement);
            throw new WebDriverTimeoutException("Element not visible in the expected time.");
        }

        public static IReadOnlyCollection<IWebElement> FindElements(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

            Func<IWebDriver, IReadOnlyCollection<IWebElement>> waitForElement = (IWebDriver Web) =>
            {
                IReadOnlyCollection<IWebElement> element = Web.FindElements(by);
                if (element.Count > 0)
                {
                    return element;
                }
                return null;
            };

            return wait.Until(waitForElement);
            throw new WebDriverTimeoutException("Elements not visible in the expected time.");
        }
    }
}
