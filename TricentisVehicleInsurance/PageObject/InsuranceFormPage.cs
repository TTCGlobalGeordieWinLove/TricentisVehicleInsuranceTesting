using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TricentisVehicleInsurance.ElementObjects;

namespace TricentisVehicleInsurance.PageObject
{
    /// <summary>
    /// Represents a generic insurance form page. Cannot be instantiated on its own.
    /// </summary>
    public abstract class InsuranceFormPage : BasePage
    {
        public InsuranceFormHeader Header { get; }
        public InsuranceFormPage() : base()
        {
            Header = new InsuranceFormHeader();
        }

        public abstract InsuranceFormPage Next();
    }
}
