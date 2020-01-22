using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TricentisVehicleInsurance.Globals;

namespace TricentisVehicleInsurance.PageObject
{
    /// <summary>
    /// Represents the tabs for accessing each page of the automobile insurance application form.
    /// </summary>
    public class InsuranceFormHeader
    {
        public InsuranceFormTab<AutomobileVehicleData> EnterVehicleData;
        public InsuranceFormTab<AutomobileInsurantData> EnterInsurantData;
        //public InsuranceFormTab EnterProductData;
        //public InsuranceFormTab EnterPriceOption;
        //public InsuranceFormTab SendQuote;

        public InsuranceFormHeader()
        {
            var basePath = "//nav[@id='idealsteps-nav']//li";
            var children = ObjectRepo.WebDriver.FindElements(By.XPath(basePath));

            EnterVehicleData =  new InsuranceFormTab<AutomobileVehicleData>(children[0]);
            EnterInsurantData = new InsuranceFormTab<AutomobileInsurantData>(children[1]);
            //EnterProductData =  new InsuranceFormTab(children[2]);
            //EnterPriceOption =  new InsuranceFormTab(children[3]);
            //EnterPriceOption =  new InsuranceFormTab(children[4]);
        }
    }
}
