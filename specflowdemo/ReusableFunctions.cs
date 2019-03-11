using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;


namespace specflowdemo
{
    
  public class ReusableFunctions
    {
        public static IWebDriver driver;
        public void homePage()
        {

            driver = new ChromeDriver();
            driver.Url = "http://secure.smartbearsoftware.com/samples/TestComplete11/WebOrders/";
            driver.Manage().Window.Maximize();
        }

        public void Login(String Username, String Password)
        {
            driver.FindElement(By.Id("ctl00_MainContent_username")).SendKeys(Username);
            driver.FindElement(By.Id("ctl00_MainContent_password")).SendKeys(Password);
        }

        public void LoginButton()
        {
            driver.FindElement(By.Id("ctl00_MainContent_login_button")).Click();
        }
    }
}
