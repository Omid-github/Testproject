//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support;
//using System.Threading;
//using System.Collections;
//using OpenQA.Selenium.Support.UI;
//using NUnit.Framework;
////using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
//using System.IO;
////using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium.Interactions;

//namespace Selenium
//{
//    public class QueryServiceProviderService
//    {
//        //public IWebDriver driver;
        
//        [Test , Order(1)]
//        public void QueryServiceProvider_Service()
//        {

//            //ورود به صفحه مدیریت پذیرندگان -صفحه اصلی 
//            var login = new Login_portal();
//            var driver = login.StartBrowser();

//            //ورود به فرم تراکنش با تعرفه 
            
//            driver.Url = "http://172.24.34.40/SubOperation/ServiceProviderService";
//            Thread.Sleep(3000);

//            //کد سرویس 
//            IWebElement ServiceCode = driver.FindElement(By.Id(("ServiceProviderServiceCode")));
//            ServiceCode.Click();
//            ServiceCode.SendKeys("1515");

//            //نام سرویس 
//            IWebElement ServiceName = driver.FindElement(By.Id("ServiceName"));
//            ServiceName.Click();
//            ServiceName.SendKeys("تست");

//            //نام سازمان 
//            IWebElement OrgName = driver.FindElement(By.Id("txtServiceProviderId"));
//            OrgName.Click();
//            OrgName.SendKeys("راهگشا");
//            Thread.Sleep(2000);
//            OrgName.SendKeys(Keys.Down);
//            OrgName.SendKeys(Keys.Enter);

//            //جستجو
//            IWebElement search = driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
//            search.Click();
//            Thread.Sleep(2000);


            


//        }

//    }
//}
