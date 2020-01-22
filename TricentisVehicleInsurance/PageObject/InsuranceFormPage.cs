using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using TricentisVehicleInsurance.ElementObjects;
using TricentisVehicleInsurance.Globals;

namespace TricentisVehicleInsurance.PageObject
{
    /// <summary>
    /// Represents a generic insurance form page. Cannot be instantiated on its own.
    /// </summary>
    public abstract class InsuranceFormPage : BasePage
    {
        public InsuranceFormHeader Header { get; }
        public bool HasErrors
        {
            get
            {
                var errors = ObjectRepo.WebDriver.FindElements(By.ClassName("error"));
                return errors.Any(e => e.Displayed);
            }
        }
        public InsuranceFormPage() : base()
        {
            Header = new InsuranceFormHeader();
        }

        public abstract InsuranceFormPage Next();
    }
}
