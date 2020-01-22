using System;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
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
                case BrowserType.Firefox:
                    return GetFirefoxDriver();
                case BrowserType.IExplorer:
                    return GetIExplorerDriver();
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
            options.AddArgument("start-maximized");
            return options;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            return new FirefoxDriver(GetFirefoxOptions());
        }
        private static FirefoxOptions GetFirefoxOptions()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            return new FirefoxOptions() { Profile = new FirefoxProfileManager().GetProfile("test-profile") };
        }

        private static IWebDriver GetIExplorerDriver()
        {
            return new InternetExplorerDriver(GetIEOptions());
        }
        private static InternetExplorerOptions GetIEOptions()
        {
            return new InternetExplorerOptions()
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                EnsureCleanSession = true
            };
        }
    }
}
