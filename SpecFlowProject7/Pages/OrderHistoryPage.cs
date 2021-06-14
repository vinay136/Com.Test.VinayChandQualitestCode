using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Com.Test.VinayChandQualitestCode.Pages
{
    class OrderHistoryPage
    {
        public readonly IWebDriver driver;
        private ScenarioContext _scenarioContext;
        public OrderHistoryPage(IWebDriver _driver) => driver = _driver;
        public IWebElement OrderTab => driver.FindElement(By.XPath("//a[contains(@title, 'Orders')]"));
        public IWebElement FirstOrderNumber => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]"));
        public void ClickButton(IWebElement webElement)
        {
            webElement.Click();
        }

        public void ElementDisplayed(IWebElement webElement, string titlestring)
        {
            if (webElement.Displayed == true)
                Console.WriteLine(titlestring + " : Fully Loaded");

            else
                Console.WriteLine(titlestring + " :failed to Load");
        }

        
    }
}
