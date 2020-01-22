using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TricentisVehicleInsurance.ElementObjects;

namespace TricentisVehicleInsurance.PageObject
{
    /// <summary>
    /// Models the base page with the link to the automobile insurance application form.
    /// </summary>
    public class BasePage
    {
        public Link<AutomobileVehicleData> Automobile { get; }


        /// <summary>
        /// Initializes the page object.
        /// </summary>
        public BasePage()
        {
            Automobile = new Link<AutomobileVehicleData>(By.Id("nav_automobile"));
        }
    }
}
