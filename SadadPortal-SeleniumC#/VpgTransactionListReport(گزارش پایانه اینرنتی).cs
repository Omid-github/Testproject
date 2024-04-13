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
//    public class CreateMobileOperatorService
//    {
//        //public IWebDriver driver;
        

//[Test , Order(1)]
//        public void Create_MobileOperatorService()
//        {
            
//            var login = new Login_portal();
//            var driver = login.StartBrowser();
//            //ورود به فرم گزارشات پایانه های اینترنتی   

//            driver.Url = "http://172.24.34.40/Vpg/Report/VpgTransactionListReport";
//            Thread.Sleep(3000);

//            //تاریخ تراکنش از 
//            IWebElement FromDate = driver.FindElement(By.Id("FromTransactionInsertDate_dateTime"));
//            FromDate.Click();
//            FromDate.Clear();
//            Thread.Sleep(1000);
//            FromDate.SendKeys("1399/06/21");
//            Thread.Sleep(1000);
//            //تاریخ تراکنش تا 
//            IWebElement ToDate = driver.FindElement(By.Id("ToTransactionInsertDate_dateTime"));
//            ToDate.Click();
//            ToDate.Clear();
//            ToDate.SendKeys("1401/06/28");

//            //CardAcqIDs  
//            IWebElement CardAcqIDs = driver.FindElement(By.Id("txtCardAcqIDs"));
//            CardAcqIDs.Click();
//            CardAcqIDs.SendKeys("000000000000051");
//            Thread.Sleep(2000);
//            CardAcqIDs.SendKeys(Keys.Down);
//            CardAcqIDs.SendKeys(Keys.Enter);

//            //جستجو
//            IWebElement Search = driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
//            Search.Click();
//            Thread.Sleep(20000);
//            driver.Close();
//            driver.Quit();



//        }

//    }
//}
