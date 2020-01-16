using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TricentisVehicleInsurance.Configuration;
using TricentisVehicleInsurance.Exceptions;

namespace TricentisVehicleInsurance.Setup
{
    public static class DriverSetup
    {
        /// <summary>
        /// Initializes the web driver given the <paramref name="browserType"/>.
        /// </summary>
        /// <param name="browserType">The browser defined in the configuration.</param>
        /// <returns>The requested IWebDriver.</returns>
        public static IWebDriver InitializeWebDriver(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return GetChromeDriver();
                default:
                    throw new NoSuitableDriverFoundException($"Browser {browserType} has no valid driver");
            }
        }

        private static IWebDriver GetChromeDriver()
        {
            return new ChromeDriver(GetChromeOptions());
        }
        private static ChromeOptions GetChromeOptions()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximised");
            return options;
        }
    }
}
