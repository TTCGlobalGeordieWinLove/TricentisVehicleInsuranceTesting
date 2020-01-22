using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using FluentAssertions;
using TechTalk.SpecFlow;
using TricentisVehicleInsurance.Configuration;
using TricentisVehicleInsurance.Extensions;
using TricentisVehicleInsurance.Globals;
using TricentisVehicleInsurance.PageObject;

namespace TricentisVehicleInsurance.StepDefinitions
{
    public class Data
    {
        public string Field1 { get; set; }
        public string Field2 { get; set; }
    }
    [Binding]
    public sealed class BasicScenarios
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext scenarioContext;

        public BasicScenarios(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"User opens browser to Insurance Webpage")]
        public void GivenUserOpensBrowserToInsuranceWebpage()
        {
            ObjectRepo.WebDriver.NavigateToUrl(ObjectRepo.ConfigReader.GetUrl());
        }

        [Given(@"User clicks Automobile insurance link")]
        public void WhenUserClicksAutomobileInsuranceLink()
        {
            var page = new BasePage();
            page = page.Automobile.Navigate();
            scenarioContext.SetCurrentPage(page);
        }

        [When(@"User enters Make ""(.*)""")]
        public void WhenUserEntersMake(string make)
        {
            var page = scenarioContext.GetCurrentPage() as AutomobileVehicleData;
            page.Make.SelectByText(make);
            Console.WriteLine($"Make selected: {page.Make.SelectedOption.Text}");
        }

        [When(@"User enters Engine Performance ""(.*)""")]
        public void WhenUserEntersEnginePerformance(string performance)
        {
            var page = scenarioContext.GetCurrentPage() as AutomobileVehicleData;
            page.EnginePerformance.SendKeys(performance);
            Console.WriteLine($"Engine Performance: {page.EnginePerformance.Text}");
        }

        [When(@"User enters Date of Manufacture ""(.*)""")]
        public void WhenUserEntersDateOfManufacture(string date)
        {
            var page = scenarioContext.GetCurrentPage() as AutomobileVehicleData;
            page.DateOfManufacture.SendKeys(date);
            Console.WriteLine($"Date of manufacture: {page.DateOfManufacture.Text}");
        }

        [When(@"User enters Number of Seats ""(.*)""")]
        public void WhenUserEntersNumberOfSeats(string seats)
        {
            var page = scenarioContext.GetCurrentPage() as AutomobileVehicleData;
            page.NumberOfSeats.SelectByText(seats);
            Console.WriteLine($"Number of seats: {page.NumberOfSeats.SelectedOption.Text}");
        }

        [When(@"User enters Fuel Type ""(.*)""")]
        public void WhenUserEntersFuelType(string fuel)
        {
            var page = scenarioContext.GetCurrentPage() as AutomobileVehicleData;
            page.FuelType.SelectByText(fuel);
            Console.WriteLine($"Fuel: {page.FuelType.SelectedOption.Text}");
        }

        [When(@"user enters List Price ""(.*)""")]
        public void WhenUserEntersListPrice(string price)
        {
            var page = scenarioContext.GetCurrentPage() as AutomobileVehicleData;
            page.ListPrice.SendKeys(price);
            Console.WriteLine($"List Price: {page.ListPrice.Text}");
        }

        [When(@"user enters License Plate Number ""(.*)""")]
        public void WhenUserEntersLicensePlateNumber(string licensePlate)
        {
            var page = scenarioContext.GetCurrentPage() as AutomobileVehicleData;
            page.LicensePlateNumber.SendKeys(licensePlate);
            Console.WriteLine($"License Plate: {page.LicensePlateNumber.Text}");
        }

        [When(@"user enters Mileage ""(.*)""")]
        public void WhenUserEntersMileage(string mileage)
        {
            var page = scenarioContext.GetCurrentPage() as AutomobileVehicleData;
            page.AnnualMileage.SendKeys(mileage);
            Console.WriteLine($"Mileage: {page.AnnualMileage.Text}");
        }

        [When(@"user clicks Next")]
        public void WhenUserClicksNext()
        {
            var page = scenarioContext.GetCurrentPage() as AutomobileVehicleData;
            var insurantPage = page.Next();
            scenarioContext.SetCurrentPage(insurantPage);
        }

        [Then(@"No fields are marked as invalid")]
        public void ThenNoFieldsAreMarkedAsInvalid()
        {
            var page = scenarioContext.GetCurrentPage() as AutomobileVehicleData;
            var invalidFieldCount = page.Header.EnterVehicleData.InvalidFieldCount;
            Console.WriteLine($"Invalid: {invalidFieldCount}");
            invalidFieldCount.Should().Be(0);
            //page.Header.EnterVehicleData.InvalidFieldCount.Should().Be(0);
        }


        [Then(@"The first page of the quote form is displayed")]
        public void ThenTheFirstPageOfTheQuoteFormIsDisplayed()
        {
            var page = scenarioContext.GetCurrentPage() as AutomobileVehicleData;
            page.Form.Displayed.Should().BeTrue();
        }

        [Then(@"An error ""(.*)"" be displayed")]
        public void ThenAnErrorBeDisplayed(bool shown)
        {
            var page = scenarioContext.GetCurrentPage() as AutomobileVehicleData;
            page.HasErrors.Should().Be(shown);
        }

    }
}
