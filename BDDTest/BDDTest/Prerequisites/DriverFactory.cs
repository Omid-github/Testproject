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
    public static class DriverFactory
    {
        private static IWebDriver Driver { get; set; }
        //private static WebDriverWait Wait;

        public static IWebDriver GetWebDriver()
        {
            if (Driver != null) return Driver;
            Driver = new ChromeDriver(@"C:\\Users\\oostadhaji\\");
            return Driver;
        }
    }
}

