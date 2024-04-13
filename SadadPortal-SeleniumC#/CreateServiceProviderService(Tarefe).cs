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
//    public class CreateServiceProvider 
//    {
//        //public IWebDriver driver;
        
//        [Test , Order(1)]
//        public void CreateService_Provider()
//        {
            
//            var login = new Login_portal();
//            var driver = login.StartBrowser();
//            //ورود به فرم گزارشات پایانه های اینترنتی   

//            driver.Url = "http://172.24.34.40/SubOperation/ServiceProviderService/CreateServiceProviderService";
//            Thread.Sleep(3000);
//            //کد سرویس 

//            IWebElement ServiceCode = driver.FindElement(By.Id("ServiceProviderServiceCode"));
//            ServiceCode.Click();
//            ServiceCode.SendKeys("113");
//            Thread.Sleep(1000);
//            //نام سرویس 
//            IWebElement ServiceName = driver.FindElement(By.Id("ServiceName"));
//            ServiceName.Click();
//            ServiceName.SendKeys("تست");


//            //نام سازمان 
//            IWebElement OrgName = driver.FindElement(By.Id("txtServiceProviderId"));
//            OrgName.Click();
//            OrgName.SendKeys("راهگشا");
//            Thread.Sleep(2000);
//            OrgName.SendKeys(Keys.Down);
//            OrgName.SendKeys(Keys.Enter);

//            //بعدی
//            IWebElement next = driver.FindElement(By.CssSelector("input[value='بعدی']"));
//            next.Click();
//            Thread.Sleep(2000);

//            //نوع سرویس 
//            IWebElement ServiceType = driver.FindElement(By.Id("txtServiceProviderServiceTypeEnum"));
//            ServiceType.Click();
//            ServiceType.SendKeys("مبلغ ثابت");
//            Thread.Sleep(2000);
//            ServiceType.SendKeys(Keys.Down);
//            ServiceType.SendKeys(Keys.Enter);

//            //مبلغ 
//            IWebElement Amount = driver.FindElement(By.Id("Amount"));
//            Amount.Click();
//            Amount.SendKeys("10000");
//            Thread.Sleep(2000);

//            //اضافه کردن 
//            IWebElement Add = driver.FindElement(By.CssSelector("input[value='اضافه کردن']"));
//            Add.Click();
//            Thread.Sleep(2000);

//            //ارسال 
//            IWebElement Send = driver.FindElement(By.CssSelector("input[value='ارسال']"));
//            Send.Click();
//            Thread.Sleep(2000);

//            //Validation
//            IWebElement VerifyTxt = driver.FindElement(By.XPath("//*[text() = 'طرح شما با موفقیت ایجاد شد']"));
//            var Actualresult = VerifyTxt.Text;
//            var Expectedresult = "طرح شما با موفقیت ایجاد شد";
//            Assert.AreEqual(Expectedresult,Actualresult);
//            Thread.Sleep(2000);
//            driver.Close();
           
//        }

//    }
//}
