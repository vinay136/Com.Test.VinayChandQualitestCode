using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Test.VinayChandQualitestCode.Drivers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Com.Test.VinayChandQualitestCode.Pages
{
    class HomePagetoCheckout
    {
        public readonly IWebDriver driver;
        private ScenarioContext _scenarioContext;
        public HomePagetoCheckout(IWebDriver _driver) => driver = _driver;


        //Ui Elements
        public IWebElement HomePagetitle => driver.FindElement(By.Id("search_query_top"));
        public IWebElement SignInLink => driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
        public IWebElement PasswordField => driver.FindElement(By.Id("passwd"));
        public IWebElement EmailField => driver.FindElement(By.Id("email"));
        public IWebElement SignInbutton => driver.FindElement(By.Id("SubmitLogin"));
        public IWebElement MyaccountHeader => driver.FindElement(By.XPath("//h1[contains(text(),'My account')]"));
        public IWebElement TshirtTab => driver.FindElement(By.XPath("(//a[contains(@title,'T-shirts')])[2]"));
        public IWebElement TshirtPage => driver.FindElement(By.XPath("//img[contains(@title,'Faded Short Sleeve T-shirts')]"));

        public IWebElement AddtocartIframe => driver.FindElement(By.XPath("//*[contains(@name,'fancybox-frame')]"));
        public IWebElement Proceedtocheckout1 => driver.FindElement(By.XPath("//*[contains(text(),'Proceed to checkout')]"));
        public IWebElement Proceedtocheckout2 => driver.FindElement(By.XPath("(//span[contains(text(),'Proceed to checkout')])[2]"));
        public IWebElement checkbox => driver.FindElement(By.XPath("//input[contains(@id,'cgv')]"));
        public IWebElement PaybyCheck => driver.FindElement(By.XPath("//a[contains(@title,'Pay by check.')]"));
        public IWebElement IconfirMyorder => driver.FindElement(By.XPath("//span[contains(text(),'I confirm my order')]"));
        public IWebElement OrderHEader => driver.FindElement(By.XPath("//p[contains(text(),'Your order on My Store is complete.')]"));
        public IWebElement ViewCustomeraccountTab => driver.FindElement(By.XPath("//*[contains(@title,'View my customer account')]"));

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
