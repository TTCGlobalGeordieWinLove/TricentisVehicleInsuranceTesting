using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TricentisVehicleInsurance.Configuration;

namespace TricentisVehicleInsurance.Globals
{
    public static class ObjectRepo
    {
        public static IWebDriver WebDriver { get; private set; }
        public static void SetWebDriver(IWebDriver driver) => WebDriver = driver;
        public static AppConfigReader ConfigReader { get; private set; }
        public static void SetAppConfigReader(AppConfigReader reader) => ConfigReader = reader;
    }
}
