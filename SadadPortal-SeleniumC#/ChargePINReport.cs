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
//    public class VpgTransactionListReport
//    {
//        //public IWebDriver driver;
        
//        [Test , Order(1)]
//        public void VpgTransaction_ListReport()
//        {
            
//            var login = new Login_portal();
//            var driver = login.StartBrowser();
//            //ورود به فرم گزارشات پین شارژ  

//            driver.Url = "http://172.24.34.40/Reports/AcqAgencyReports/DecryptedChargePINReport";
//            Thread.Sleep(3000);

//            //پایان راهنما
//            IWebElement GuideEnd = driver.FindElement(By.XPath("//*[text() = 'پایان راهنما']"));
//            GuideEnd.Click();
//            Thread.Sleep(2000);

//            //تاریخ فروش شارژ
//            IWebElement ChargeSaleDate = driver.FindElement(By.Id("ChargeSaleDate_dateTime"));
//            ChargeSaleDate.Click();
//            ChargeSaleDate.SendKeys("1399/04/16");
//            //شماره کارت 
//            IWebElement PrimaryAccNoEnc = driver.FindElement(By.Id("PrimaryAccNoEnc"));
//            PrimaryAccNoEnc.Click();
//            PrimaryAccNoEnc.SendKeys("6277601833738451");
//            //شماره مرجع
//            IWebElement RetrivalRefNo = driver.FindElement(By.Id("RetrivalRefNo"));             
//            RetrivalRefNo.Click();
//            RetrivalRefNo.SendKeys("320086202095");

//            //سریال شارژ
//            IWebElement ChargeSerial = driver.FindElement(By.Id("ChargeSerial"));
//            ChargeSerial.Click();
//            ChargeSerial.SendKeys("998827599807");


//            //تامین کننده شارژ
//            IWebElement ChargeProvider = driver.FindElement(By.Id("txtChargeProviderPK"));
//            ChargeProvider.Click();
//            ChargeProvider.SendKeys("ایرانسل");
//            Thread.Sleep(2000);
//            ChargeProvider.SendKeys(Keys.Down);
//            ChargeProvider.SendKeys(Keys.Enter);

//            //مبلغ شارژ
//            IWebElement ChargeAmount = driver.FindElement(By.Id("ChargeAmount"));
//            ChargeAmount.Click();
//            ChargeAmount.SendKeys("50000");

//            Thread.Sleep(3000);

//            //جستجو
//            IWebElement Search = driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
//            Search.Click();

             
//            //driver.Close();
//            //driver.Quit();

//        }

//    }
//}
