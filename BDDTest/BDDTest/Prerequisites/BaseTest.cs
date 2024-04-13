using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using BDDTest.Set;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using BDDTest.Pages;

namespace BDDTest.Set
{
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait;

        public string HomePage = "http://172.24.34.117/Account/MainPage";
        public static string BaseUrl = "http://172.24.34.117";
        public LoginPage LoginPageObj { get; set; }

        public BaseTest()
        {
            this.Driver = Driver;
           // Driver = new ChromeDriver(@"C:\\Users\\oostadhaji\\");

           // PageFactory.InitElements(Driver,this);

            Driver = DriverFactory.GetWebDriver();
            //Wait = DriverFactory.GetWait();

            //Driver.Navigate().GoToUrl(BaseUrl);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(7));
            

        }

        public void Signin(String username, String password)
        {

            LoginPageObj = new LoginPage(Driver);
            Thread.Sleep(5000);
            // Driver.Navigate().GoToUrl(BaseUrl);

            // var Account = new LoginPOM();
            //User.UserName.SendKeys(username);
            // WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            Wait.Until(ExpectedConditions.ElementIsVisible(LoginPageObj.UsernameBy));
            //IWebElement username = Driver.FindElement(By.XPath("//main//Section//input[@id='UserName']"));
            LoginPageObj.Username.Click();
            LoginPageObj.Username.SendKeys(username);
            Assert.IsTrue(LoginPageObj.Username.Displayed);
            //var excelObject = new Test_Data();
            //var excel = excelObject.MainTest();
            //UserName.SendKeys(excel[0].UserName);
            LoginPageObj.Password.SendKeys(password);
            // password.SendKeys(excel[0].Password);
            Thread.Sleep(5000);
            LoginPageObj.Submit.Click();
            Thread.Sleep(6000);
        }
        public void TearDown()
        {

            if (Driver != null)
            {
                Driver.Quit();
            }
            else throw new Exception("Error while trying to close the Driver");

        }
    }
}


