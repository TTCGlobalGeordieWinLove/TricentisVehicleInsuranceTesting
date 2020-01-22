using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TricentisVehicleInsurance.ElementObjects;
using TricentisVehicleInsurance.Globals;

namespace TricentisVehicleInsurance.PageObject
{
    /// <summary>
    /// Models a tab of the insurance form.
    /// </summary>
    /// <typeparam name="TabType">The class of the returned page.</typeparam>
    public class InsuranceFormTab<TabType> : Link<TabType> where TabType : new()
    {
        public int InvalidFieldCount
        {
            get
            {
                var countElement = element.FindElement(By.ClassName("counter"));
                return int.Parse(countElement.Text);
            }
        }

        public InsuranceFormTab(By locator) : base(locator)
        {
            element = ObjectRepo.WebDriver.FindElement(locator);
        }
        public InsuranceFormTab(IWebElement element) : base(element)
        {
            this.element = element;
        }
    }
}
