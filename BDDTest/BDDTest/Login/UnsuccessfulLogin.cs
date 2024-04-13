using BDDTest.Pages;
using BDDTest.Set;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDDTest.StepDefinitions
{
    [Binding]
    public class UnsuccessfulLogin : BaseTest
    {
        public IWebElement ErrorMsg => Driver.FindElement(By.XPath("//*[@id='notification']/div/ul/li"));
        public String Expected = "نام کاربري و يا رمز عبور اشتباه مي باشد.";

        public  LoginPage LoginPage { get; set; }
        public UnsuccessfulLogin() : base()
        {
            LoginPage = new LoginPage(Driver);
        }

        [When]
        public void When_The_user_enters_invalid_username_P0_And_password_P1(string p0, string p1, Table table)

        {
            Wait.Until(ExpectedConditions.ElementIsVisible(LoginPage.UsernameBy));

            //IWebElement Password = Driver.FindElement(By.XPath("//section//input[@id='Password']"));

            var credential = table.CreateSet<Credentials>();

            foreach (var tableRow in credential)
            {
                //IWebElement username = Driver.FindElement(By.XPath("//main//Section//input[@id='UserName']"));
                LoginPage.Username.Click();
                LoginPage.Username.SendKeys(tableRow.Username);
                Thread.Sleep(1000);
                //var excelobject = new Test_Data();
                //var excel = excelobject.MainTest();
                //UserName.SendKeys(excel[0].UserName);
                LoginPage.Password.Click();
                // password.SendKeys(excel[0].Password);
                LoginPage.Password.SendKeys(tableRow.Password);

                Thread.Sleep(1000);
                LoginPage.Submit.Click();
                var Actual = ErrorMsg.Text;
                Assert.IsTrue(Actual.Equals(Expected));

                Thread.Sleep(2000);
                //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                LoginPage.Username.Clear();
                LoginPage.Password.Clear();
                //
                //for (int i = 0; i < credential.Count(); i++)
                //{
                //    var tableValue = credential.ElementAt(i);
                //}

            }

        }

        [Then]
        public void Then_The_user_should_not_be_successfully_logged_in()
        {
            Assert.IsFalse(Driver.Url.ToLower().Equals(HomePage));
            Console.WriteLine("نام کاربری و یا رمز عبور اشتباه است");
            Debug.WriteLine("نام کاربری و یا رمز عبور اشتباه است");
            TearDown();
        }

    }
}
