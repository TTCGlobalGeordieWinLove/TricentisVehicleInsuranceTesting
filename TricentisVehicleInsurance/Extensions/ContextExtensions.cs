using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TricentisVehicleInsurance.Configuration;

namespace TricentisVehicleInsurance.Extensions
{
    /// <summary>
    /// A set of extension methods to make accessing aspects of the feature context object easier.
    /// </summary>
    public static class ContextExtensions
    {
        // The key used to retrieve the WebDriver
        private static string driver = "__webDriver";
        /// <summary>
        /// Adds an IWebDriver to the feature context.
        /// </summary>
        /// <param name="featureContext">The current FeatureContext.</param>
        /// <param name="webDriver"> The webdriver currently in use.</param>
        public static void AddWebDriver(this FeatureContext featureContext, IWebDriver webDriver)
        {
            featureContext[driver] = webDriver;
        }
        /// <summary>
        /// Retrieves the webdriver from the feature context.
        /// </summary>
        /// <param name="featureContext">The current FeatureContext.</param>
        /// <returns>The currently used webdriver.</returns>
        public static IWebDriver GetWebDriver(this FeatureContext featureContext)
        {
            return (IWebDriver)featureContext[driver];
        }
    }
}
