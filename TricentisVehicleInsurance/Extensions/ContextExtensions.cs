using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TricentisVehicleInsurance.Configuration;
using TricentisVehicleInsurance.PageObject;

namespace TricentisVehicleInsurance.Extensions
{
    /// <summary>
    /// A set of extension methods to make accessing aspects of the feature context object easier.
    /// </summary>
    public static class ContextExtensions
    {
        // Key for current page.
        private static readonly string CurrentPage = "__currentPage";
        /// <summary>
        /// Sets the current page in the ScenarioContext.
        /// </summary>
        /// <param name="scenarioContext">The current ScenarioContext.</param>
        /// <param name="page">The current page.</param>
        public static void SetCurrentPage(this ScenarioContext scenarioContext, BasePage page)
        {
            scenarioContext[CurrentPage] = page;
        }
        /// <summary>
        /// Retrieves the current page.
        /// </summary>
        /// <param name="scenarioContext">The current ScenarioContext.</param>
        /// <returns>The object representing the current page.</returns>
        public static BasePage GetCurrentPage(this ScenarioContext scenarioContext)
        {
            return scenarioContext[CurrentPage] as BasePage;
        }
    }
}
