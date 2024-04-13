//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support;
//using OpenQA.Selenium.Interactions;
//using System.Threading;
//using System.Collections;
//using OpenQA.Selenium.Support.UI;
//using NUnit.Framework;
////using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
//using System.IO;
//using System.Diagnostics;

//namespace Selenium
//{


//    public class Create_Terminal
//    {
//        // public IWebDriver driver;
//        static void main()
//        {

//        }
//        [Test]
//        public void create_terminal() 
//        {


//            //Initialize
//            var Login = new Login_portal();
//            var driver = Login.StartBrowser();

//            //ورود به فرم مدیریت پایانه ها 
//            IWebElement amaliat = driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
//            amaliat.Click();
//            Thread.Sleep(2000);
//            IWebElement menuTerminal = driver.FindElement(By.XPath("//*[@href='/Merchants/terminals/Index']"));
//            menuTerminal.Click();
//            Thread.Sleep(1000);
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
//            IWebElement addTerminal = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='content']/a/i")));
//            addTerminal.Click();
//            System.Threading.Thread.Sleep(2000);
//            //Assert.True(driver.Title.Contains("اضافه کردن / ویرایش پایانه"));

//            ///ساخت ترمینال جدید
//             //نوع ترمنیال 
//            IWebElement termtype = driver.FindElement(By.Id("txttermTypeLookupModelId"));
//            termtype.Click();
//            termtype.SendKeys("پایانه فروشگاهی");
//            Thread.Sleep(2000);
//            termtype.SendKeys(Keys.Down);
//            termtype.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            //مدل ترمینال 
//            IWebElement model = driver.FindElement(By.Id("txtTermModelCode"));
//            model.Click();
//            model.SendKeys("BlueBird_CT360");
//            Thread.Sleep(2000);
//            model.SendKeys(Keys.Down);
//            model.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            //شماره سریال
//            IWebElement serial = driver.FindElement(By.Id("SerialNo"));
//            serial.Click();
//            Random rand = new Random();
//            int serNo = rand.Next(20220100, 20221890);
//            serial.SendKeys(serNo.ToString());
//            Thread.Sleep(2000);
//            model.SendKeys(Keys.Down);
//            model.SendKeys(Keys.Enter);

//            //نمایندگی
//            IWebElement Agency = driver.FindElement(By.Id("txtAcqAgencyPK"));
//            Agency.Click();
//            Agency.SendKeys("اصفهان");
//            Thread.Sleep(2000);
//            Agency.SendKeys(Keys.Down);
//            Agency.SendKeys(Keys.Enter);

//            //شرکت فروشنده 
//            IWebElement seller = driver.FindElement(By.Id("txtSellerCompanyPK"));
//            seller.Click();
//            seller.SendKeys("Blue Bird");
//            Thread.Sleep(2000);
//            seller.SendKeys(Keys.Down);
//            seller.SendKeys(Keys.Enter);
//            /////انتخاب دستگاه جدید
//            //Actions action = new Actions(driver);
//            //action.MoveToElement(driver.FindElement(By.Id("IsNewDevice"))).Click().Build().Perform()

//            //ارسال 
//            IWebElement send = driver.FindElement(By.XPath("//input[@class ='btn bg-blue pull-right' and @type ='button']"));
//            send.Click();
//            Thread.Sleep(3000);

//            IWebElement returnAnswer = driver.FindElement(By.XPath("//*[@id='notification']/following::*/ul[1]/li[1]"));
//            var Actualresult = returnAnswer.Text;
//            var Expectedresult = "عملیات ثبت با موفقیت انجام شد";
//            Assert.IsTrue(Actualresult.Contains(Expectedresult));
//            //Assert.AreEqual(returnAnswer.Text, "عملیات ثبت با موفقیت انجام شد");
//            //System.Diagnostics.Debug.WriteLine(Actualresult + "\n"+ serNo.ToString() + " :شماره پایانه ");
//            Debug.WriteLine(Actualresult + "\n"+ serNo.ToString() + " :شماره پایانه ");
//            Console.WriteLine(Actualresult + "\n" + serNo.ToString() + " :شماره پایانه ");
//            driver.Close();
//        }
        
//    }

//}









   

       
    
    
