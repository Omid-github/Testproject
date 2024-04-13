using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Selenium
{
    public class MyConstructorTest
    {

        public IWebDriver driver { get; set; }
        public WebDriverWait wait;


        //[FindsBy(How = How.XPath, Using = "//main//Section//input[@id='UserName']")]
        public IWebElement Username => driver.FindElement(UsernameBy);
        public By UsernameBy => By.XPath("//main//Section//input[@id='UserName']");

    
        //[FindsBy(How = How.XPath, Using = "//section//input[@id='Password']")]
        public IWebElement Password => driver.FindElement(PasswordBy);
        public By PasswordBy => By.XPath("//section//input[@id='Password']");

        //[FindsBy(How = How.XPath, Using = "//input[@class='btn bg-green pull-left']")]
        public IWebElement Submit => driver.FindElement(SubmitBy);
        public By SubmitBy => By.XPath("//input[@class='btn bg-green pull-left']");


       // public MyConstructorTest(IWebDriver driver)
       
         public MyConstructorTest()
        {
            //ChromeOptions options = new ChromeOptions
            //{
            //    BinaryLocation = @"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe",
            //    PageLoadStrategy = PageLoadStrategy.Normal
            //};
            //var cDriver = new ChromeDriver("", options, TimeSpan.FromHours(1));            
            //driver = new ChromeDriver(@"C:\\Users\\oostadhaji\\", options);
            IWebDriver driver = new ChromeDriver(@"C:\\Users\\oostadhaji\\");
            this.driver = driver;
            driver.Url = "http://172.24.34.40";
            //driver.Navigate().GoToUrl("http://172.24.34.40");
            // PageFactory.InitElements(driver, this);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        //for test only
        public void Signin(LoginDTO dto)
        {

            Username.Click();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement ElmUsername = wait.Until(ExpectedConditions.ElementIsVisible(UsernameBy));
            //IWebElement username = driver.FindElement(By.XPath("//main//Section//input[@id='UserName']"));
            ElmUsername.Click();
            ElmUsername.SendKeys(dto.UserName);
            Assert.IsTrue(ElmUsername.Displayed);
            //var excelObject = new Test_Data();
            //var excel = excelObject.MainTest();
            //UserName.SendKeys(excel[0].UserName);
            Password.Click();
            // password.SendKeys(excel[0].Password);
            Password.SendKeys(dto.Password);
            Thread.Sleep(5000);
            Submit.Click();
            Thread.Sleep(3000);

        }



        public void Navigation()
        {
            driver.Navigate().GoToUrl("http://172.24.34.40");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void Signin(String username, String password)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement ElmUsername = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//main//Section//input[@id='UserName']")));
            //IWebElement username = driver.FindElement(By.XPath("//main//Section//input[@id='UserName']"));
            ElmUsername.Click();
            ElmUsername.SendKeys(username);
            Assert.IsTrue(ElmUsername.Displayed);
            //var excelObject = new Test_Data();
            //var excel = excelObject.MainTest();
            //UserName.SendKeys(excel[0].UserName);
            IWebElement ElmPassword = driver.FindElement(By.XPath("//section//input[@id='Password']"));
            ElmPassword.Click();
            // password.SendKeys(excel[0].Password);
            ElmPassword.SendKeys(password);
            Thread.Sleep(5000);
            IWebElement Enter = driver.FindElement(By.XPath("//input[@class='btn bg-green pull-left']"));
            Enter.Click();
            Thread.Sleep(3000);

        }

        public void TearDown()
        {

            driver.Close();
            driver.Quit();
        }
        //second constructor for clean code----------
        //----------------------------------------------
        //public myconstructor(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        //public MyConstructorTest(IWebDriver driver)
        //{
        //    this.driver=driver;
        //}
    }

    public class LoginDTO {
        public LoginDTO(string username, string password)
        {
            UserName = username;
            Password = password;
            
        }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}