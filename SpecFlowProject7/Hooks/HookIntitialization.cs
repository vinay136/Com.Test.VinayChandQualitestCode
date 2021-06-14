using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Test.VinayChandQualitestCode.Drivers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Com.Test.VinayChandQualitestCode.Hooks
{
    [Binding]
    public sealed class HookIntitialization
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly ScenarioContext _scenarioContext;
        public HookIntitialization(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            SeleniumDriver seleniumDriver = new SeleniumDriver(_scenarioContext);
            _scenarioContext.Set(seleniumDriver, "SeleniumDriver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            Console.WriteLine("Selenium Webdriver Quit");
            _scenarioContext.Get<IWebDriver>("WebDriver").Quit();
        }
    }
}
