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


//    public class Create_MobileOperatorService : MyConstructorTest

//    {
//        // public IWebDriver driver;
//        public Create_MobileOperatorService()
            
//        {

//            Navigation();
//            Signin("controlpanel", "portal@1234");

//        }

//        [Test]
//        public void CreateMobileOperatorService()
//        {
//            //List<string> msgs = new List<string>();

//            //Initialize

//            //ورود به فرم مدیریت پایانه های پذیرندگان 
//            driver.Url = "http://172.24.34.40/Topup/MobileOperatorService/Create";
//            Thread.Sleep(3000);

//            //عنوان خدمت 
//            IWebElement ServiceName = driver.FindElement(By.Id("ServiceName"));
//            ServiceName.Click();
//            ServiceName.SendKeys("تست اتومات سداد");
//            Thread.Sleep(1000);

//            //کد سرویس 
//            IWebElement ServiceCode = driver.FindElement(By.Id("ServiceCode"));
//            ServiceCode.Click();
//            ServiceCode.SendKeys("246");
//            Thread.Sleep(1000);
//            // دسته بندی  خدمت اپراتور
//            IWebElement CategoryID = driver.FindElement(By.Id("txtMobileOperatorServiceCategoryId"));
//            CategoryID.Click();
//            CategoryID.SendKeys(Keys.Down);
//            CategoryID.SendKeys(Keys.Down);
//            CategoryID.SendKeys(Keys.Down);
//            CategoryID.SendKeys(Keys.Down);
//            CategoryID.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            //مالیات
//            IWebElement TAX = driver.FindElement(By.Id("VATL"));
//            TAX.Click();
//            TAX.Clear();
//            TAX.SendKeys("100");

//            //مبلغ
//            IWebElement Amount = driver.FindElement(By.Id("AmountL"));
//            Amount.Click();
//            Amount.SendKeys("100000");
//            Thread.Sleep(1000);

//            // اپراتور 
//            IWebElement Operator = driver.FindElement(By.Id("txtMobileOperatorId"));
//            Operator.Click();
//            Operator.SendKeys("همراه اول");
//            Thread.Sleep(1000);
//            Operator.SendKeys(Keys.Down);
//            Operator.SendKeys(Keys.Enter);
//            Thread.Sleep(1000);

//            //کد دستوری اپراتور 
//            IWebElement OperatorCommand = driver.FindElement(By.Id("txtMobileOperatorCommandId"));
//            OperatorCommand.SendKeys("SaleRequest");
//            Thread.Sleep(1000);
//            OperatorCommand.SendKeys(Keys.Down);
//            OperatorCommand.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            ////نوع 

//            // IWebElement InternetDurationId = driver.FindElement(By.Id("txtInternetDurationId"));
//            //InternetDurationId.SendKeys("");
//            //Thread.Sleep(1000);
//            //InternetDurationId.SendKeys(Keys.Down);
//            //InternetDurationId.SendKeys(Keys.Enter);
//            //Thread.Sleep(2000);

//            //اپراتور پروفایل 
//            IWebElement ProfileOperator = driver.FindElement(By.Id("OperatorProfile"));
//            ProfileOperator.Click();
//            ProfileOperator.SendKeys("تست اتومات سداد");

//            //شناسه نوع بسته 
//            IWebElement DivisionId = driver.FindElement(By.Id("txtMobileOperatorServiceDivisionId"));
//            DivisionId.SendKeys("919");
//            Thread.Sleep(1000);
//            DivisionId.SendKeys(Keys.Down);
//            DivisionId.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            //حجم به مگا بایت
//            IWebElement Capacity = driver.FindElement(By.Id("Capacity"));
//            Capacity.Click();
//            Capacity.SendKeys("1000");

//            //فعال 
//            IWebElement Active = driver.FindElement(By.XPath("/html/body/div[1]/div/section/div/form/div[2]/div[2]/div/div[6]/div[2]/div/label//span[@class='checkbox-material']"));
//            Active.Click();

//            //توضیحات حجم به بسته 
//            IWebElement DescTocap = driver.FindElement(By.Id("CapacityDescription"));
//            DescTocap.Click();
//            DescTocap.SendKeys("1");

//            //توضیحات بسته 
//            IWebElement PackDesc = driver.FindElement(By.Id("PackageDescription"));
//            PackDesc.Click();
//            PackDesc.SendKeys("بسته 1 گیگی");

//            //ارسال 
//            IWebElement Send = driver.FindElement(By.XPath("//input[@type='button' and @value='ارسال']"));
//            Send.Click();
//            Thread.Sleep(5000);

//            var ExpectedResult = "عملیات ثبت با موفقیت انجام شد";
//            IWebElement successNotif = driver.FindElement(By.XPath("//*[text() = 'عملیات ثبت با موفقیت انجام شد']"));
//            var ActualResult = successNotif.Text;
            
//            Assert.AreEqual(ActualResult,ExpectedResult);
//            TearDown();



//            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
//            //IWebElement amaliyatGrid = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("button.ui-button[role='button']")));
//            ////button#id//button.class//button[class='']//button.class[attribute='']
//            //amaliyatGrid.Click();


//        }
//    }
//}





























