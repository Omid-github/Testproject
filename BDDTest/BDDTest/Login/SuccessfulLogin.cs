using BDDTest.Set;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Diagnostics;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Linq;
using BDDTest.Pages;

namespace BDDTest.StepDefinitions
{
    [Binding]
    public class SuccessfulLogin : BaseTest
    {

        public LoginPage LoginPage { get; set; }
        public SuccessfulLogin() : base()
        {
           LoginPage = new LoginPage(Driver);
        }

       // public IWebDriver Driver;
        [Given(@"The user enters valid credentials as following:")]
        public void GivenTheUserEntersValidCredentialsAsFollowing(Table table)
        {

           
            Wait.Until(ExpectedConditions.ElementIsVisible(LoginPage.UsernameBy));
            //IWebElement Password = Driver.FindElement(By.XPath("//section//input[@id='Password']"));
            var credential = table.CreateSet<Credentials>();

            //IWebElement username = Driver.FindElement(By.XPath("//main//Section//input[@id='UserName']"));
            LoginPage.Username.Click();
            LoginPage.Username.SendKeys(credential.First().Username);
            Thread.Sleep(1000);
            LoginPage.Password.Click();
            LoginPage.Password.SendKeys(credential.First().Password);
            //var excelobject = new Test_Data();
            //var excel = excelobject.MainTest();
            //UserName.SendKeys(excel[0].UserName);
            // password.SendKeys(excel[0].Password);
            Thread.Sleep(1000);
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //var excelobject = new Test_Data();
            //var excel = excelobject.MainTest();
            //UserName.SendKeys(excel[0].UserName);
            // password.SendKeys(excel[0].Password);
        }
       

        [When(@"The user clicks on Enter")]
        public void WhenTheUserClicksOnEnter()
        {
            // WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            LoginPage.Submit.Click();
            Thread.Sleep(4000);
        }
        
        [Then(@"The user should be Navigated to the homepage")]
        public void ThenTheUserShouldBeNavigatedToTheHomepage()
        {
            Assert.IsTrue(Driver.Url.Equals(HomePage));
            TearDown();
        }
    }
}
