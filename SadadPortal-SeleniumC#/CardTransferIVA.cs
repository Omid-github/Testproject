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
//    public class CardTransferIVA
//    {
//        //public IWebDriver driver;
        
//        [Test , Order(1)]
//        public void CardTransfer_IVA()
//        {
            
//            var login = new Login_portal();
//            var driver = login.StartBrowser();
//            //ورود به فرم گزارشات تراکنش کارت به کارت ایوا    

//            driver.Url = "http://172.24.34.40/SubOperation/CardTransfer/Index";
//            Thread.Sleep(3000);

//            //شماره کارت مبدا 
//            IWebElement Source = driver.FindElement(By.Id("SourcePan"));
//            Source.Click();
//            Source.Clear();
//            Thread.Sleep(1000);
//            Source.SendKeys("");
//            Thread.Sleep(1000);
//            //شماره کارت مقصد 
//            IWebElement Dest = driver.FindElement(By.Id("DestinationPan"));
//            Dest.Click();
//            Dest.Clear();
//            Dest.SendKeys("");

//            //تاریخ ثبت از  
//            IWebElement InsertDateFrom = driver.FindElement(By.Id("InsertTime_dateTime"));
//            InsertDateFrom.Click();
//            InsertDateFrom.SendKeys("1399/01/01");
//            Thread.Sleep(2000);
//            InsertDateFrom.SendKeys(Keys.Enter);
//            //تاریخ ثبت تا  
//            IWebElement InsertDateTO = driver.FindElement(By.Id("InsertToTime_dateTime"));
//            InsertDateTO.Click();
//            InsertDateTO.SendKeys("1401/08/30");
//            Thread.Sleep(2000);
//            //شماره موبایل 
//            IWebElement MobileNo = driver.FindElement(By.Id("MobileNo"));
//            MobileNo.Click();
//            MobileNo.SendKeys("");
//            Thread.Sleep(2000);

//            //جستجو
//            IWebElement Search = driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
//            Search.Click();
//            Thread.Sleep(10000);

//            //خروج
//            driver.Close();
//            driver.Quit();



//        }

//    }
//}
