//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support;
//using System.Threading;
//using System.Collections;
//using OpenQA.Selenium.Support.UI;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using OpenQA.Selenium.Interactions;
////using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
//using System.Diagnostics;

//namespace Selenium
//{
//    class AmuzeshClass
//    {
//        public IWebDriver Driver;
//        [Test]
//        public void Amuzesh_Class()
//        {

//            //Initialize
//            //var Login = new Login_portal();
//            //var driver = Login.StartBrowser();
//            ChromeOptions options = new ChromeOptions();
//            options.BinaryLocation = @"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
//            options.PageLoadStrategy = PageLoadStrategy.Normal;
//            //var cDriver = new ChromeDriver("", options, TimeSpan.FromHours(1));
//            IWebDriver driver = new ChromeDriver(@"C:\\Users\\oostadhaji\\", options);
//            Thread.Sleep(3000);
//            //driver.Navigate().GoToUrl("http://172.24.34.40");
//            driver.Url = "http://172.24.34.40/";
//            Thread.Sleep(5000);
//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//            Thread.Sleep(5000);


//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//            IWebElement UserName = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//main//Section//input[@id='UserName']")));
//            //IWebElement username = driver.FindElement(By.XPath("//main//Section//input[@id='UserName']"));
//            UserName.Click();
//            UserName.SendKeys("controlpanel");

//            //var excelObject = new Test_Data();
//            //var excel = excelObject.MainTest();
//            //UserName.SendKeys(excel[0].UserName);

//            IWebElement password = driver.FindElement(By.XPath("//section//input[@id='Password']"));
//            password.Click();
//            // password.SendKeys(excel[0].Password);
//            password.SendKeys("portal@1234");
           
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

//            IWebElement Enter = driver.FindElement(By.XPath("//input[@class='btn bg-green pull-left']"));
//            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
//            //IWebElement Enter = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[value=ورود].btn.bg-green")));
//            Enter.Click();
//            Thread.Sleep(5000);
//            var actualresult = driver.Title;
//            //Debug.WriteLine(actualresult);
//            var Expectedresult = "پورتال پذیرندگان سداد - میز کارi";
            
//            driver.Close();
//            driver.Quit();




//            IWebElement checkbox2 = driver.FindElement(By.XPath("/html/body/div[1]/div/section/div/form/div[2]/div/div[2]/div/div[1]/div/div[2]/div/div[1]/div[1]/div[2]/div/label/span/span"));
//            IWebElement checkbox3 = driver.FindElement(By.XPath("/html/body/div[1]/div/section/div/form/div[2]/div/div[2]/div/div[1]/div/div[2]/div/div[1]/div[1]/div[2]/div/label/span/span"));

//            Boolean display2 = checkbox2.Displayed;
//            Boolean display3 = checkbox3.Displayed;

//            if (display2 == true)
//            {
//                checkbox2.Click();
//                Thread.Sleep(3000);
//            }





//            //IWebElement amaliat = driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
//            //amaliat.Click();
//            //IWebElement menumerchant = driver.FindElement(By.XPath("//*[@id='el_5']/ul/li[4]/a"));
//            //menumerchant.Click();
//            //System.Threading.Thread.Sleep(3000);
//            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

//            //IWebElement addmerchant = wait.Until(ExpectedConditions.ElementExists(By.XPath("//a[@data-original-title='اضافه كردن پذیرنده']")));
//            //// IWebElement addmerchant = driver.FindElement(By.XPath("//a[@data-original-title='اضافه كردن پذیرنده']"));
//            //addmerchant.Click();
//            //IWebElement info = driver.FindElement(By.XPath("//html/body//*[text() ='اطلاعات پذیرنده']"));
//            //IWebElement FirstNameEn = driver.FindElement(By.XPath("//input[@id='FirstNameEn']"));







//            ////خروج و بستن مرورگر

//        }
//    }
//}











































