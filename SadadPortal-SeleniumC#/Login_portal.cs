using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Threading;
using System.Collections;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;
//using OpenQA.Selenium.Support.UI;

//using NPOI.HSSF.UserModel;
//using NPOI.SS.UserModel;
//using NPOI.XSSF.UserModel;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Selenium
{
    public class Login_portal : MyConstructorTest
    {
        //public IWebDriver driver;
        static void Main()
        {

        }

        [Test]
        public void Test()

        {

            // IWebDriver driver = new ChromeDriver(@"C:\\Users\\oostadhaji\\");
            // var login = new MyConstructorTest(driver);

            //  var login = new MyConstructorTest();
            Signin(new LoginDTO("Controlpanel", "portal@1234"));

        }
        //public IWebDriver StartBrowser()
        //{
        //    ////Initialize
        //    ChromeOptions options = new ChromeOptions();
        //    options.BinaryLocation = @"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
        //    //options.PageLoadStrategy = PageLoadStrategy.Normal;
        //    //var cDriver = new ChromeDriver("", options, TimeSpan.FromHours(1));
        //    IWebDriver driver = new ChromeDriver(@"C:\\Users\\oostadhaji\\", options);
        //    Thread.Sleep(5000);
        //    driver.Navigate().GoToUrl("http://172.24.34.40");
        //    //driver.Url = "http://172.24.32.210:8088/";
        //    Thread.Sleep(5000);
        //    driver.Manage().Window.Maximize();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //    Thread.Sleep(5000);
             
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //   IWebElement UserName = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//main//Section//input[@id='UserName']")));
        //    //IWebElement username = driver.FindElement(By.XPath("//main//Section//input[@id='UserName']"));
        //    UserName.Click();
        //    UserName.SendKeys("controlpanel");

        //    //var excelobject = new Test_Data();
        //    //var excel = excelobject.MainTest();
        //    //UserName.SendKeys(excel[0].UserName);

        //    IWebElement password = driver.FindElement(By.XPath("//section//input[@id='Password']"));
        //    password.Click();
        //   // password.SendKeys(excel[0].Password);
        //    password.SendKeys("portal@1234");

        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

        //    IWebElement Enter = driver.FindElement(By.XPath("//input[@class='btn bg-green pull-left']"));
        //    //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
        //    //IWebElement Enter = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[value=ورود].btn.bg-green")));
        //    Enter.Click();
        //    Thread.Sleep(5000);
        //    ////ورود
        //    return driver ;

            //var submit = driver.FindElement(By.CssSelector("input[value=ورود].btn.bg-green"));
            //wait.Until(ExpectedConditions.ElementExists(By.CssSelector("input[value=ورود].btn.bg-green")));
            //Assert.IsTrue(btnbutton.Displayed);
            //wait.Until(ExpectedConditions.UrlContains("MainPage"));


            //Assertion
            // string mytitle = driver.Title;
            //  System.Diagnostics.Debug.WriteLine(mytitle);
            // System.Diagnostics.Debug.WriteLine("Login Successfully");

            // Console.WriteLine(mytitle);


            //بسته شدن کروم


            //driver.Manage().Window.FullScreen();



            //System.Threading.Thread.Sleep(5000);

        }

        //  public void ExecuteTest()
        //{

        //IWebElement usr = driver.FindElement(By.Name("UserName"));
        // usr.SendKeys("controlpanel");
        // System.Threading.Thread.Sleep(3000);
        // IWebElement pass = driver.FindElement(By.Name("Password"));
        // pass.SendKeys("portal@1234");
        //System.Threading.Thread.Sleep(3000);

        //[TearDown]

    }


//SeleniumSetMethods.Click(driver, "UserName", "name");
// System.Threading.Thread.Sleep(2000);
//SeleniumSetMethods.EnterText(driver,"UserName", "controlpanel", "name");
// System.Threading.Thread.Sleep(2000);

//SeleniumSetMethods.Click(driver, "Password", "name");
// System.Threading.Thread.Sleep(2000);
//SeleniumSetMethods.EnterText(driver,"Password", "Portal@1234", "name");
// System.Threading.Thread.Sleep(2000);
//SeleniumSetMethods.Click(driver, "btn bg-green pull-left", "class");
// SeleniumSetMethods.Click(driver, "UserName", "name");
// SeleniumSetMethods.Click(driver,"Save","name");
// SeleniumSetMethods.Click(driver, "Save", "LastName");
//SeleniumSetMethods.DropDown(driver, "TitleId", "Mr.", "id");

//SeleniumSetMethods.Equals("", "");
// }




