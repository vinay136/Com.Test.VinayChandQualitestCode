using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace Com.Test.VinayChandQualitestCode.Drivers
{
    class SeleniumDriver
    {
        private IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

        public SeleniumDriver(ScenarioContext scenarioContext)=> _scenarioContext= scenarioContext;
        public IWebDriver Setup()
        {
            driver = new ChromeDriver(@"C:\Users\vchand\Downloads\chromedriver_win32");
           // driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chromeOptions.Capabilities);
            _scenarioContext.Set(driver, "WebDriver");
            driver.Manage().Window.Maximize();
            return driver;


        }
    }
}
