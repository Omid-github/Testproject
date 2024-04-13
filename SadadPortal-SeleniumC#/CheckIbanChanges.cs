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

//namespace Selenium
//{


//    public class CheckIbanChanges
//    {
//        // public IWebDriver driver;
        
//        [Test]
//        public void CheckIban_Changes()
//        {
//            //List<string> msgs = new List<string>();

//            //Initialize
//            var Login = new Login_portal();
//            var driver = Login.StartBrowser();

//            //ورود به فرم بررسی تغییرات شبا 


//            //تایید شاپرکی شبای اصلی  

//            driver.Url = "http://172.24.34.40/SubOperation/CheckIbanChanges/Index";
//            IWebElement cardacqid = driver.FindElement(By.Id("txtMerchantPkList"));
//            cardacqid.Click();
//            cardacqid.SendKeys("000000000000045");
//            Thread.Sleep(2000);
//            cardacqid.SendKeys(Keys.Down);
//            cardacqid.SendKeys(Keys.Enter);
//            //جستجوی
//            IWebElement Search1 = driver.FindElement(By.CssSelector("input[value='جستجو']"));
//            Search1.Click();
//            Thread.Sleep(3000);

//            var amaliyatButton = driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
//            //button#id//button.class//button[class='']//button.class[attribute='']

//            //ردیف اول
//            amaliyatButton[0].Click();
//            IWebElement VerifyRow1 = driver.FindElement(By.LinkText("تایید"));
//            VerifyRow1.Click();

//            //تایید دوم
//            IWebElement FinalApprove = driver.FindElement(By.Id("submitModal"));
//            FinalApprove.Click();
           
//            //تایید گروهی
//            //IWebElement ApproveAll = driver.FindElement(By.CssSelector("bulkCheckIban"));
//            //ApproveAll.Click();
//            //ردیف دوم
//            //amaliyatButton[1].Click();
//            //ردیف سوم
//            //amaliyatButton[2].Click();

//            //ردیف اول دکمه عملیات 
//            //IWebElement AmaliaytBtn = driver.FindElement(By.XPath("//html//table/tbody/tr[1]//button[@role='button']"));
//            //AmaliaytBtn.Click();

//            ////ردیف دوم
//            ////IWebElement GRID2 = driver.FindElement(By.Id("/html//table/tbody/tr[2]//button[@role='button']"));
//            ////GRID2.Click();

//            //IWebElement VerifyRow1 = driver.FindElement(By.LinkText("تایید"));
//            //VerifyRow1.Click();

//            //IWebElement submit = driver.FindElement(By.Id("submitModal"));
//            //submit.Click();
//            //Thread.Sleep(2000);
//            //////تایید شاپرکی شبای شریک 
//            //cardacqid.Clear();
//            //Thread.Sleep(2000);
//            //cardacqid.SendKeys("000000000000047");
//            //Thread.Sleep(2000);
//            //cardacqid.SendKeys(Keys.Down);
//            //cardacqid.SendKeys(Keys.Enter);
//            ////جستجوی
//            //Search1.Click();
//            //Thread.Sleep(3000);
//            //// ردیف اول دکمه عملیات 

//            //IWebElement AmaliaytBtn1 = driver.FindElement(By.XPath("//html//table/tbody/tr[1]//button[@role='button']"));
//            //AmaliaytBtn1.Click();
//            ////ردیف دوم
//            ////IWebElement GRID2 = driver.FindElement(By.Id("/html//table/tbody/tr[2]//button[@role='button']"));
//            ////GRID2.Click();

//            //IWebElement VerifyRowSharik = driver.FindElement(By.LinkText("تایید"));
//            //VerifyRowSharik.Click();
//            //submit.Click();




//        }
//    }
//}

                





           


        

    











   

       
    
    
