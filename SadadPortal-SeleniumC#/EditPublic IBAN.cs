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
//    public class PublicIBAN
//    {
//        //public IWebDriver driver;
        
//        [Test]
//        public void Public_IBAN()
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
//            IWebElement IBAN = driver.FindElement(By.Id("IBAN"));
//            IBAN.Click();
//            IBAN.SendKeys("IR810170000000227545995008");
//            Thread.Sleep(3000);
//            IBAN.SendKeys(Keys.Down);
//            IBAN.SendKeys(Keys.Enter);

//            //جستجو
//            IWebElement search = driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
//            search.Click();
//            Thread.Sleep(2000);
//            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
//            var amaliyatButton = driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
//            //button#id//button.class//button[class='']//button.class[attribute='']
//            // amaliyatButton[0].Click();
//            //amaliyatButton[1].Click();
//            //amaliyatButton[2].Click();
//            amaliyatButton[0].Click();

//            //ویرایش در گرید عملیات
//            IWebElement Edit = driver.FindElement(By.XPath("//a[text() = 'ويرايش']"));
//            var href = Edit.GetAttribute("href");
//            driver.Navigate().GoToUrl(href);
//            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

//            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
//            // Edit.Click();
//            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
//            Thread.Sleep(5000);


//            IWebElement EditedIBAN = driver.FindElement(By.Id("IBAN"));
//            EditedIBAN.Click();
//            EditedIBAN.Clear();
//            Thread.Sleep(1000);
//            EditedIBAN.SendKeys("IR060170000000105341114002");
            

//            // ارسال
//            IWebElement send = driver.FindElement(By.XPath("//input[@type='button' and @value='ارسال']"));
//            send.Click();
//            Thread.Sleep(5000);


//            IWebElement successNotif = driver.FindElement(By.XPath("//*[@id='content']/div[1]//ul/li"));
//            var ActualResult = successNotif.Text;
//            var ExpectedResult = "عملیات به روز رسانی با موفقیت انجام شد";
//            if (ActualResult.Equals(ExpectedResult))
//            {
//                System.Diagnostics.Debug.WriteLine(ActualResult);

//            }
//            else { 
//            driver.Close();
//            }

//        }
//        }

//    }

