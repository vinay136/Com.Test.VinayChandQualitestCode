using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Com.Test.VinayChandQualitestCode.Pages
{
    class MyPersonalInformationPage
    {
        public readonly IWebDriver driver;
        private ScenarioContext _scenarioContext;
        public MyPersonalInformationPage(IWebDriver _driver) => driver = _driver;
        public IWebElement myPersonalInfo => driver.FindElement(By.XPath("//a[contains(@title, 'Information')]"));
        public IWebElement FirstOrderNumber => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]"));
        public IWebElement firstnameField => driver.FindElement(By.Id("firstname"));
        public IWebElement OldpasswordField=>driver.FindElement(By.Id("old_passwd"));
        public IWebElement NewPasswordPage=>driver.FindElement(By.Id("passwd"));
        public IWebElement ConfirmPassowrd=> driver.FindElement(By.Id("confirmation"));
        public IWebElement SubmitField=> driver.FindElement(By.Name("submitIdentity"));
        public IWebElement SuccesspersonalInfoTitle => driver.FindElement(By.XPath("//p[contains(text(),'Your personal information has been successfully updated.')]"));

        public void ClickButton(IWebElement webElement)
        {
            webElement.Click();
        }

        public void ElementDisplayed(IWebElement webElement, string titlname)
        {
            if (webElement.Displayed == true)
                Console.WriteLine(titlname + " : Fully Loaded");

            else
                Console.WriteLine(titlname + " :failed to Load");
        }
    }
}
