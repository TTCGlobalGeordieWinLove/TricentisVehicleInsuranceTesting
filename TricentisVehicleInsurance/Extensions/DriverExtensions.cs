using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TricentisVehicleInsurance.Extensions
{
    public static class DriverExtensions
    {
        /// <summary>
        /// Navigates the <paramref name="driver"/> to the given <paramref name="url"/>
        /// </summary>
        /// <param name="driver">Current web driver.</param>
        /// <param name="url">URL to navigate to.</param>
        public static void NavigateToUrl(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        /// <summary>
        /// Scrolls to the element found with the given locator.
        /// </summary>
        /// <param name="driver">Current IWebDriver.</param>
        /// <param name="locator">The locator for the element.</param>
        public static void ScrollTo(this IWebDriver driver, By locator)
        {
            var element = driver.FindElement(locator);
            driver.ScrollTo(element);
        }
        /// <summary>
        /// Scrolls to the given element.
        /// </summary>
        /// <param name="driver">Current IWebDriver.</param>
        /// <param name="element">Element to scroll to.</param>
        public static void ScrollTo(this IWebDriver driver, IWebElement element)
        {
            var js = $"window.scrollTo(0, {element.Location.Y})";
            var executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript(js);
        }
    }
}
