using TechTalk.SpecFlow;
using TricentisVehicleInsurance.Configuration;
using TricentisVehicleInsurance.Extensions;
using TricentisVehicleInsurance.Globals;
using TricentisVehicleInsurance.Setup;

namespace TricentisVehicleInsurance.GeneralHooks
{
    [Binding]
    public sealed class GeneralHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ObjectRepo.SetAppConfigReader(new AppConfigReader());
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
        }
        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            ObjectRepo.SetWebDriver(DriverSetup.InitializeWebDriver(ObjectRepo.ConfigReader.GetBrowser()));
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            ObjectRepo.WebDriver?.Close();
            ObjectRepo.WebDriver?.Quit();
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {

        }
    }
}
