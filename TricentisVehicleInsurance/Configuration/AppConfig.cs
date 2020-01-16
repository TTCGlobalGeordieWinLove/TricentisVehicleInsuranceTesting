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
    public static class AppConfig
    {
        private const string browser = "Browser";
        public const string Website = "Website";
        public static BrowserType Browser => (BrowserType)Enum.Parse(typeof(BrowserType), browser);
    }
}
