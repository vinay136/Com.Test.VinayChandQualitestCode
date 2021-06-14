using System;
using System.Linq;
using System.Threading;
using Com.Test.VinayChandQualitestCode.Drivers;
using Com.Test.VinayChandQualitestCode.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject7.Steps
{
    [Binding]
    public sealed class LoginPagePortalSteps
    {
        IWebDriver driver;
        HomePagetoCheckout homePagetoCheckout;
        OrderHistoryPage orderHistoryPage;
        MyPersonalInformationPage myPersonalInformationPage;



        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        
        public LoginPagePortalSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            

        }

        [Given(@"I have navigate to AutomationPractice Page")]
        public void GivenIHaveNavigateToAutomationPracticePage(Table table)
        {
            //For Local setup to invoke chrome driver 
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            dynamic data = table.CreateDynamicInstance();
            driver.Url = data.URL;
            homePagetoCheckout = new HomePagetoCheckout(driver);
            orderHistoryPage = new OrderHistoryPage(driver);
            myPersonalInformationPage = new MyPersonalInformationPage(driver);

        }

        [Given(@"I see the Home Page of Portal Page fully loaded")]
        public void GivenISeeTheHomePageOfPortalPageFullyLoaded()
        {
            //Verifying Home Page title
            homePagetoCheckout.ElementDisplayed(homePagetoCheckout.HomePagetitle, "homePage");
        }

        [When(@"I tap Sign In CTA as")]
        public void WhenITapSignInCTAAs()
        {
            //Clicking Sign In button
            homePagetoCheckout.ClickButton(homePagetoCheckout.SignInLink);
        }

        [Then(@"I reach Sign In Page of Authentication Portal")]
        public void ThenIReachSignInPageOfAuthenticationPortal()
        {
            //Verifying User reacjed to Login Page
            homePagetoCheckout.ElementDisplayed(homePagetoCheckout.PasswordField, "Login Page");
        }

        [Then(@"I give username and passowrd in Sign Page")]
        public void ThenIGiveUsernameAndPassowrdInSignPage(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            //Passing value to Email and password field from table feature
            homePagetoCheckout.EmailField.SendKeys(data.username);
            homePagetoCheckout.PasswordField.SendKeys(data.passowrd);
        }

        [Then(@"I tap SignIn CTA")]
        public void ThenITapSignInCTA()
        {
            //Tap Sign In Button to Login
            homePagetoCheckout.ClickButton(homePagetoCheckout.SignInbutton);
        }

        [Then(@"I reached to MyAccount Page")]
        public void ThenIReachedToMyAccountPage()
        {
            //Verify user reached to Myaccount Page
            homePagetoCheckout.ElementDisplayed(homePagetoCheckout.MyaccountHeader, "My Account Page ");
        }

        [Then(@"I tap on Tshirt section")]
        public void ThenITapOnTshirtSection()
        {
            //Tap to Tshirt Tab
            homePagetoCheckout.ClickButton(homePagetoCheckout.TshirtTab);
        }

        [Then(@"reached to Tshirt Page")]
        public void ThenReachedToTshirtPage()
        {
            //Vrify user reached to Tshirt Page
            homePagetoCheckout.ElementDisplayed(homePagetoCheckout.TshirtPage, "Tshirt Page");
        }

        [When(@"I tap first Tshirt and Add the Add to Cart")]
        public void WhenITapFirstTshirtAndAddTheAddToCart()
        {
            //Add to cart
            homePagetoCheckout.TshirtPage.Click();
            Thread.Sleep(10000);
            // driver.FindElement(By.XPath("//*[contains(text(),'Add to cart')]")).Click();
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[contains(@name,'fancybox-frame')]")));
            driver.SwitchTo().ActiveElement().FindElement(By.XPath("//*[contains(@name,'Submit')]")).Click();
            Thread.Sleep(10000);
        }

        [When(@"I tap to Proceed to Checkout")]
        public void WhenITapToProceedToCheckout()
        {
           //tap to proceed
            homePagetoCheckout.ClickButton(homePagetoCheckout.Proceedtocheckout1);
            Thread.Sleep(10000);
        }

        [When(@"I confirm the Proceed Checkout in payment page")]
        public void WhenIConfirmTheProceedCheckoutInPaymentPage()
        {
            //Proceed to Payment Page
            homePagetoCheckout.ClickButton(homePagetoCheckout.Proceedtocheckout2);
            
        }

        [When(@"I confirm the Proceed Checkout in address page")]
        public void WhenIConfirmTheProceedCheckoutInAddressPage()
        {
            // Proceed to Address Page
            homePagetoCheckout.ClickButton(homePagetoCheckout.Proceedtocheckout2);
            
        }

        [When(@"I check the terms and condition")]
        public void WhenICheckTheTermsAndCondition()
        {
            //Check terms and condition
            homePagetoCheckout.ClickButton(homePagetoCheckout.checkbox);

        }

        [When(@"I confirm the Proceed Checkout in shipping page")]
        public void WhenIConfirmTheProceedCheckoutInShippingPage()
        {
            //proceed to shipping
            homePagetoCheckout.ClickButton(homePagetoCheckout.Proceedtocheckout2);
        }

        [When(@"I select Pay by check")]
        public void WhenISelectPayByCheck()
        {
            //Pay by check to Payment
            homePagetoCheckout.ClickButton(homePagetoCheckout.PaybyCheck);
        }

        [When(@"I confirm my order by tapping Confirm CTA")]
        public void WhenIConfirmMyOrderByTappingConfirmCTA()
        {
            //Confirm the order
            homePagetoCheckout.ClickButton(homePagetoCheckout.IconfirMyorder);
            Thread.Sleep(1000);
        }

        [When(@"verify Order is placed and copy Order refrence")]
        public void WhenVerifyOrderIsPlacedAndCopyOrderRefrence()
        {
            // Go to Order page
            homePagetoCheckout.ElementDisplayed(homePagetoCheckout.OrderHEader, "Order Page");
        }

        [When(@"I view my Customer account")]
        public void WhenIViewMyCustomerAccount()
        {
           //View Customer account Page
            homePagetoCheckout.ClickButton(homePagetoCheckout.ViewCustomeraccountTab);
        }

        [Then(@"I tap on Order History Details")]
        public void ThenITapOnOrderHistoryDetails()
        {
            //Tap on Order history tap
            orderHistoryPage.ClickButton(orderHistoryPage.OrderTab);
            Thread.Sleep(1000);
        }

        [Then(@"I verify my order refrence in order history")]
        public void ThenIVerifyMyOrderRefrenceInOrderHistory()
        {
            //VErify Order is playced and print the order number in console
            if(orderHistoryPage.FirstOrderNumber.Displayed==true)
                Console.WriteLine("Your Order number is : " + orderHistoryPage.FirstOrderNumber.Text);
            else
                Console.WriteLine("No order found");
        }

        [Then(@"I tap on My personal information")]
        public void ThenITapOnMyPersonalInformation()
        {
         //Go to Personal infp page
            myPersonalInformationPage.ClickButton(myPersonalInformationPage.myPersonalInfo);
        }
        [Then(@"I edit my Firstname in  personal information")]
        public void ThenIEditMyFirstnameInPersonalInformation(Table table)
        {

            myPersonalInformationPage.firstnameField.Clear();

            //Generating random string in firsrtname field
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijkl";
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, 5)
                                                    .Select(s => s[random.Next(s.Length)]).ToArray());
            
            myPersonalInformationPage.firstnameField.SendKeys(randomString);
            dynamic data = table.CreateDynamicInstance();
            myPersonalInformationPage.OldpasswordField.SendKeys(data.passowrd);
            myPersonalInformationPage.NewPasswordPage.SendKeys(data.passowrd);
            myPersonalInformationPage.ConfirmPassowrd.SendKeys(data.passowrd);
           // Submit new first name details
            myPersonalInformationPage.ClickButton(myPersonalInformationPage.SubmitField);
        }

        [Then(@"I see Personal information updated Successfully and I can see new Firstname")]
        public void ThenISeePersonalInformationUpdatedSuccessfullyAndICanSeeNewFirstname()
        {
            //verify new First Name
            if(myPersonalInformationPage.SuccesspersonalInfoTitle.Displayed==true)   
            Console.WriteLine("Your personal information has been successfully updated");
            else
                Console.WriteLine("Your personal information failed to update");

            string Username = driver.FindElement(By.XPath("//*[contains(@title,'View my customer account')]")).Text.Trim();
            string[] words = Username.Split(' ');
            Console.WriteLine("Your New username is :  " + words[0]);
        }


    }
}
