using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace specflowdemo
{
    [Binding]
    public class SpecFlowFeature1Steps : ReusableFunctions
    {
     //   public IWebDriver driver;
        ReusableFunctions reusableFunctions = new ReusableFunctions();
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            reusableFunctions.homePage();

        }
        [Given(@"I have entered (.*) and (.*)")]
        public void GivenIHaveEnteredAnd(String Username, String Password)
        {
            reusableFunctions.Login(Username, Password);
        }

        [When(@"I click on the Login button")]
        public void WhenIClickOnTheLoginButton()
        {
            reusableFunctions.LoginButton();
        }

        [Then(@"it should open the page")]
        public void ThenItShouldOpenThePage()
        {

            Console.WriteLine(driver.Title.ToString());
           
        }



        [Given(@"I login")]
        public void GivenILogin()
        {
            Console.WriteLine("Login");
        }

        [When(@"I am on the website")]
        public void WhenIAmOnTheWebsite()
        {
            Console.WriteLine("On the Website");
        }

        [Then(@"i can view orders")]
        public void ThenICanViewOrders()
        {
            Console.WriteLine("Viewing Orders");
        }

    }

}
