using BDDTest.Set;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using BDDTest.Pages;



namespace BDDTest.Features
{
    [Binding]
    public class EmptyCredentials : BaseTest
    {
        public  LoginPage LoginPage { get; set; }
        public EmptyCredentials() : base()
        {
            LoginPage = new LoginPage(Driver);
        }
        [Given(@"A user enters no credentials")]
        public void GivenAUserEntersNoCredentials()
        {
            //Do nothing 

        }

        [When(@"A user clicks on Enter")]
        public void WhenAUserClicksOnEnter()
        {
            // WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            LoginPage.Submit.Click();
            Thread.Sleep(4000);
        }

        [Then(@"A User should not be successfully logged in")]
        public void ThenAUserShouldNotBeSuccessfullyLoggedIn()
        {
            Assert.IsFalse(Driver.Url.Equals(HomePage));

        }

        [Then(@"A User should see an error")]
        public void ThenAUserShouldSeeAnError()
        {
            Console.WriteLine("نام کاریری و رمز عبور را وارد نمایید");
        }
    }
}