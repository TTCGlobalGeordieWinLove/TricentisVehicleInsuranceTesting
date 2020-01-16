using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TricentisVehicleInsurance.Configuration;
using TricentisVehicleInsurance.Extensions;
using TricentisVehicleInsurance.Setup;

namespace TricentisVehicleInsurance.GeneralHooks
{
    [Binding]
    public sealed class GeneralHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeFeature]
        public void BeforeFeature(FeatureContext featureContext)
        {
            var webDriver = DriverSetup.InitializeWebDriver(AppConfig.Browser);
            featureContext.AddWebDriver(webDriver);
        }
        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
