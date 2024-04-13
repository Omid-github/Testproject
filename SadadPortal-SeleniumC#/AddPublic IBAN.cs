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
//using System.Diagnostics;

//namespace Selenium
//{
//    public class AddPublicIBAN
//    {
//        //public IWebDriver driver;

//        [Test]
//        public void Add_Public_IBAN()
//        {

//            var login = new Login_portal();
//            var driver = login.StartBrowser();

//            //ورود به فرم شبای عمومی 
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
//            IWebElement amaliat = driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
//            amaliat.Click();
//            IWebElement PublicIBAN = driver.FindElement(By.XPath("//*[@href='/SubOperation/PublicIBAN/Index']"));
//            PublicIBAN.Click();
//            System.Threading.Thread.Sleep(3000);

//            IWebElement CreateIBAN = driver.FindElement(By.XPath("//*[@href='/SubOperation/PublicIBAN/Create']"));
//            CreateIBAN.Click();
//            Thread.Sleep(3000);

//            IWebElement IBAN = driver.FindElement(By.Id("IBAN"));
//            IBAN.Click();
//            IBAN.SendKeys("IR810170000000227545995008");

//            IWebElement IBANStatusCode = driver.FindElement(By.Id("txtIBANStatusCode"));
//            IBANStatusCode.Click();
//            IBANStatusCode.SendKeys("فعال");
//            Thread.Sleep(2000);
//            IBANStatusCode.SendKeys(Keys.Down);
//            IBANStatusCode.SendKeys(Keys.Enter);
//            Thread.Sleep(1000);

//            //نوع حساب 
//            IWebElement AccountType = driver.FindElement(By.Id("txtBankAccountTypeCode"));
//            AccountType.Click();
//            AccountType.SendKeys("حساب سپرده متمرکز");
//            Thread.Sleep(2000);
//            AccountType.SendKeys(Keys.Down);
//            AccountType.SendKeys(Keys.Enter);
//            Thread.Sleep(1000);


//            //تاریخ موثر 
//            IWebElement EfDate = driver.FindElement(By.Id("IBAN_EffectDate_dateTime"));
//            EfDate.Click();
//            EfDate.SendKeys("1401/05/11");

//            //شمراه حساب 
//            IWebElement AccountNo = driver.FindElement(By.Id("AccountTitle"));
//            AccountNo.Click();
//            AccountNo.SendKeys("0227545995008");

//            //عنوان حساب 
//            IWebElement AccountTitle = driver.FindElement(By.Id("AccountTitle"));
//            AccountTitle.Click();
//            AccountTitle.SendKeys("حساب");

//            //توضیحات

//            IWebElement Comments = driver.FindElement(By.Id("Comments"));
//            Comments.Click();
//            Comments.SendKeys("تست تست");

//            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
//            // Edit.Click();
//            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
//            //Thread.Sleep(3000);

//            //بانک
//            IWebElement Banks = driver.FindElement(By.Id("txtpartialBank"));
//            Banks.Click();
//            Banks.SendKeys("ملی");
//            Thread.Sleep(1000);

//            //شعبه 
//            IWebElement Branch = driver.FindElement(By.Id("txtpartialBankBranch"));
//            Branch.Click();
//            Branch.SendKeys("آصف");
//            Thread.Sleep(1000);
//            Branch.SendKeys(Keys.Down);
//            Branch.SendKeys(Keys.Enter);
//            Thread.Sleep(1000);

//            //نوع شبای عمومی 
//            IWebElement IBANType = driver.FindElement(By.Id("txtIBANTypeCode"));
//            IBANType.Click();
//            IBANType.SendKeys("کد صنف");
//            Thread.Sleep(1000);
//            IBANType.SendKeys(Keys.Down);
//            IBANType.SendKeys(Keys.Enter);
//            Thread.Sleep(1000);

//            //نوع صنف
//            IWebElement ShaparakMCC = driver.FindElement(By.Id("txtShaparakMCC_PK"));
//            ShaparakMCC.Click();
//            ShaparakMCC.SendKeys("سایر");
//            ShaparakMCC.SendKeys(Keys.Down);
//            ShaparakMCC.SendKeys(Keys.Enter);
//            Thread.Sleep(1000);

//            //کشور 
//            IWebElement CountryCode = driver.FindElement(By.Id("txtCountryCode_A2"));
//            CountryCode.Click();
//            CountryCode.SendKeys("ایران");
//            CountryCode.SendKeys(Keys.Down);
//            CountryCode.SendKeys(Keys.Enter);
//            Thread.Sleep(1000);

//            //استان
//            IWebElement txtProvincePK = driver.FindElement(By.Id("txtProvincePK"));
//            txtProvincePK.Click();
//            txtProvincePK.SendKeys("تهران");
//            txtProvincePK.SendKeys(Keys.Down);
//            txtProvincePK.SendKeys(Keys.Enter);
//            Thread.Sleep(1000);



//            // ارسال
//            IWebElement send = driver.FindElement(By.XPath("//input[@type='button' and @value='ارسال']"));


//            send.Click();
//            Thread.Sleep(5000);

//            var ExpectedResult = "با موفقیت ذخیره شد";

//            bool elementFound = driver.FindElement(By.XPath("//*[@id='content']/div[1]//ul/li")).Displayed;
//            Assert.IsTrue(elementFound);

//            var ActualResult = driver.FindElement(By.XPath("//*[@id='content']/div[1]//ul/li")).Text;
//            Assert.AreEqual(ActualResult, ExpectedResult);
//            Debug.WriteLine("ذخیره شبای عمومی با موفقیت انجام شد");
//            driver.Close();
//        }
//    }
//}




