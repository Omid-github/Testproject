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
//    public class Clone_Contract : MyConstructorTest
//    {
//        //public IWebDriver driver;
//        public Clone_Contract()
//        {

//            Navigation();
//            Signin("controlpanel", "portal@1234");
//        }
//        [Test]
//        public void CloneContract()
//        {
            
//           // var login = new Login_portal();
//           // var driver = login.StartBrowser();


//            //ورود به فرم ویرایش  پذیرنده 
          
//            IWebElement amaliat = driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
//            amaliat.Click();
//            IWebElement menuContract = driver.FindElement(By.XPath("//*[@href='/Merchants/Contracts/Index']"));
//            menuContract.Click();
//            System.Threading.Thread.Sleep(5000);
//            IWebElement ContractNo = driver.FindElement(By.Id("ContractNo"));
//            ContractNo.Click();
//            ContractNo.SendKeys("MC0000001839551");
//            Thread.Sleep(2000);
  
//            //جستجو
//            IWebElement search = driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
//            search.Click();
//            Thread.Sleep(2000);
//            var amaliyatButton = driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
//            //button#id//button.class//button[class='']//button.class[attribute='']

//            //ردیف اول
//            amaliyatButton[0].Click();
//            //amaliyatButton[1].Click();
//            //amaliyatButton[2].Click();

//            ///---using explicit wait--///
//            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
//            //IWebElement amaliyatGrid = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("button.ui-button[role='button']")));
//            //button#id//button.class//button[class='']//button.class[attribute='']
//            ///---using explicit wait--///

//            //کپی قرارداد در گرید عملیات
//            IWebElement copy  = driver.FindElement(By.LinkText("کپی قرارداد"));
//            copy.Click();

//            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
//            // Edit.Click();
//            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
//            Thread.Sleep(5000);
            

//            //ارسال
//            IWebElement Send = driver.FindElement(By.XPath("//input[@type='button' and  @value='ارسال']"));
//            Send.Click();
//            Thread.Sleep(10000);

//            //driver.Close();
//           // driver.Quit();

//        }

//    }
//}
