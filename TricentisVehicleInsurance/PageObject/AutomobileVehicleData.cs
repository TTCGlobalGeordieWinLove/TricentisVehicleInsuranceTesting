using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TricentisVehicleInsurance.ElementObjects;
using TricentisVehicleInsurance.Globals;

namespace TricentisVehicleInsurance.PageObject
{/// <summary>
/// Represents the Vehicle Data page of the Automobile Insurance form
/// </summary>
    public class AutomobileVehicleData : InsuranceFormPage
    {
        public IWebElement Form { get; }
        public SelectElement Make { get; }
        public IWebElement EnginePerformance { get; }
        public IWebElement DateOfManufacture { get; }
        public SelectElement NumberOfSeats { get; }
        public SelectElement FuelType { get; }
        public IWebElement ListPrice { get; }
        public IWebElement LicensePlateNumber { get; }
        public IWebElement AnnualMileage { get; }
        private Link<AutomobileInsurantData> next;

        public override InsuranceFormPage Next()
        {
            next.Click();
            return new AutomobileInsurantData();
        }

        public AutomobileVehicleData() : base()
        {
            Form = ObjectRepo.WebDriver.FindElement(By.Id("idealsteps-nav"));

            var makeSelector = ObjectRepo.WebDriver.FindElement(By.Id("make"));
            Make = new SelectElement(makeSelector);

            EnginePerformance = ObjectRepo.WebDriver.FindElement(By.Id("engineperformance"));
            DateOfManufacture = ObjectRepo.WebDriver.FindElement(By.Id("dateofmanufacture"));

            var _numberOfSeats = ObjectRepo.WebDriver.FindElement(By.Id("numberofseats"));
            NumberOfSeats = new SelectElement(_numberOfSeats);

            var _fuelType = ObjectRepo.WebDriver.FindElement(By.Id("fuel"));
            FuelType = new SelectElement(_fuelType);

            ListPrice = ObjectRepo.WebDriver.FindElement(By.Id("listprice"));
            LicensePlateNumber = ObjectRepo.WebDriver.FindElement(By.Id("licenseplatenumber"));
            AnnualMileage = ObjectRepo.WebDriver.FindElement(By.Id("annualmileage"));
            next = new Link<AutomobileInsurantData>(By.Id("nextenterinsurantdata"));
        }
    }
}