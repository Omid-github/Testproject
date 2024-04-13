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
//    public class TakhsisPOS: Login_portal
//    {
//        //public IWebDriver driver;
        
//        [Test]
//        public void Takhsis_POS()
//        {
//            var login = new Login_portal();
//            var driver = login.StartBrowser();
            
//            //ورود به فرم ویرایش  پذیرنده 
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//            Thread.Sleep(5000);
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
//            IWebElement amaliat = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='el_5']/a/span")));
//            //IWebElement amaliat = driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
//            amaliat.Click();
//            IWebElement Takhsis = driver.FindElement(By.XPath("//*[@href='/Merchants/MerchantTerminal/Index']"));
//            Takhsis.Click();
//            System.Threading.Thread.Sleep(3000);
//            IWebElement cardacqid = driver.FindElement(By.Id("txtMerchantPK"));
//            cardacqid.Click();
//            cardacqid.SendKeys("000000130880893");
//            Thread.Sleep(2000);
//            cardacqid.SendKeys(Keys.Down);
//            cardacqid.SendKeys(Keys.Enter);
//            Thread.Sleep(3000);
//            IWebElement search = driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
//            search.Click();
//            Thread.Sleep(4000);
//            var GridAmaliat = driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
//            //button#id//button.class//button[class='']//button.class[attribute='']
//            GridAmaliat[0].Click();

//            //تخصیص به پذیرنده در گرید عملیات 
//            IWebElement Edit  = driver.FindElement(By.LinkText("تخصیص به پذیرنده"));
//            Edit.Click();

//            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
//            // Edit.Click();
//            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
//            Thread.Sleep(5000);

//            //فرم تخصیص پایانه فروشگاهی--POS 
//            //نوع پایانه 

//            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
//            IWebElement TermType = wait2.Until(ExpectedConditions.ElementToBeClickable(By.Id("txtTerminalModel_TermTypeCode")));
//            TermType.Click();
//            TermType.Clear();
//            Thread.Sleep(1000);
//            TermType.SendKeys("پایانه فروشگاهی");
//            Thread.Sleep(1000);
//            TermType.SendKeys(Keys.Down);
//            TermType.SendKeys(Keys.Enter);

//            //مدل پایانه 
//            IWebElement TermModel = driver.FindElement(By.Id("txtTerminalModel_TermModelCode"));
//            TermModel.Click();
//            TermModel.Clear();
//            Thread.Sleep(2000);
//            TermModel.SendKeys("BlueBird_CT360");
//            Thread.Sleep(2000);
//            TermModel.SendKeys(Keys.Down);
//            TermModel.SendKeys(Keys.Enter);

//            //آخرین وضعیت موجود 
//            IWebElement ExistanceStatusCode = driver.FindElement(By.Id("txtExistanceStatusCode"));
//            ExistanceStatusCode.Click();
//            ExistanceStatusCode.Clear();
//            Thread.Sleep(2000);
//            ExistanceStatusCode.SendKeys("عادي 111");
//            Thread.Sleep(2000);
//            ExistanceStatusCode.SendKeys(Keys.Down);
//            ExistanceStatusCode.SendKeys(Keys.Enter);


//            //کد پستی
//            IWebElement postalCode = driver.FindElement(By.Id("InstallLoc_PostalCode"));
//            postalCode.Click();
//            postalCode.Clear();
//            postalCode.SendKeys("1541625321");
//            //Thread.Sleep(1000);

//            //شماره موبایل 
//            IWebElement MobileNo = driver.FindElement(By.Id("InstallLoc_MobileNo"));
//            MobileNo.Click();
//            MobileNo.Clear();
//            MobileNo.SendKeys("9121152020");
//            //Thread.Sleep(1000);

//            //محل نصب انگلسیسی 
//            IWebElement InstallLoc = driver.FindElement(By.Id("InstallLoc_NameEn"));
//            InstallLoc.Click();
//             InstallLoc.SendKeys("TestStore");

//            //شماره سریال 
//            IWebElement serialNo = driver.FindElement(By.Id("SerialNo"));
//            serialNo.Click();
//            serialNo.SendKeys("20221009");
//            //Thread.Sleep(2000);

//            ////زمان معکوس شدن تراکنش
//            //IWebElement RemainReversal = driver.FindElement(By.Id("txtTerminalRemainReversal"));
//            //RemainReversal.Click();
//            //RemainReversal.Clear();
           
//            //RemainReversal.SendKeys("30 دقیقه");
//            //Thread.Sleep(2000);
//            //RemainReversal.SendKeys(Keys.Down);
//            //RemainReversal.SendKeys(Keys.Enter);

//            ////زمان لازم برای ارسال تراکنش معکوس شده 
//            //IWebElement ReverseTimeOut = driver.FindElement(By.Id("txtReverseTimeout"));
//            //ReverseTimeOut.Click();
//            //ReverseTimeOut.Clear();
            
//            //ReverseTimeOut.SendKeys("25 دقیقه");
//            //Thread.Sleep(2000);


//            ///افزودن شبای پایانه 
              
//            //شبای قرارداد
//            IWebElement IBAN = driver.FindElement(By.Id("txtMerchantContractIBAN_PK"));
//            IBAN.Click();
//            Thread.Sleep(6000);
//            IBAN.SendKeys("IR810170000000227545995008");
//            IBAN.SendKeys(Keys.Down);
//            IBAN.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);
			
//            //تاثیر گذاری سهیم 
//            IWebElement BehaveID = driver.FindElement(By.Id("txtMultiplexingValueBehaviorId"));
//            BehaveID.Clear();
//            BehaveID.SendKeys("مقدار جاری");
//            Thread.Sleep(2000);
//            BehaveID.SendKeys(Keys.Down);
//            BehaveID.SendKeys(Keys.Enter);
//            Thread.Sleep(1000);

//            //اضافه کردن
//            IWebElement Add1 = driver.FindElement(By.XPath("//*[@id='merchantTerminalManagementFromId']//div[17]//input[@value='اضافه کردن']"));
//            Add1.Click();
//            Thread.Sleep(4000);

//            //تلفن سر خظ
//            IWebElement sarkhat = driver.FindElement(By.Id("TelephoneNo"));
//            sarkhat.Click();
//            sarkhat.SendKeys("21-22887665");
			
//            //اضافه کردن تلفن سر خط
//            IWebElement Add2 = driver.FindElement(By.XPath("//*[@id='merchantTerminalManagementFromId']//div[18]//input[@value='اضافه کردن']"));
//            Add2.Click();
//            Thread.Sleep(2000);

//            ///ارسال 
//            IWebElement Send = driver.FindElement(By.XPath("//input[@type='button' and @value='ارسال']"));
//            Send.Click();
//            Thread.Sleep(20000);

//            IWebElement successNotif = driver.FindElement(By.XPath("//*[@id='content']/div[3]/div[1]/div/ul"));
//            var ActualResult = successNotif.Text;
//            var ExpectedResult = "عملیات ثبت با موفقیت انجام شد";
//            Assert.IsTrue(ActualResult.Contains(ExpectedResult));
//            System.Diagnostics.Debug.WriteLine(ActualResult);

//            driver.Close();
//            driver.Quit();
//        }
//    }
//}
