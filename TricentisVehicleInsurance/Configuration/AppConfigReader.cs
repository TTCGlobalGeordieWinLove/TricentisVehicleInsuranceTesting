using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using OpenQA.Selenium;

namespace TricentisVehicleInsurance.Configuration
{
    /// <summary>
    /// Returns configuration keys and browser type enum
    /// </summary>
    public class AppConfigReader
    {
        public AppConfigReader()
        {
        }

        public BrowserType GetBrowser()
        {
            string browser = AppConfig.Browser;
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public string GetUrl()
        {
            return AppConfig.Website;
        }
    }
}
