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
//    public class Edit_Contract
//    {
//        //public IWebDriver driver;
        
//        [Test]
//        public void Editcontract()
//        {
            
//            var login = new Login_portal();
//            var driver = login.StartBrowser();
//            //ورود به فرم ویرایش  پذیرنده 

//            IWebElement amaliat = driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
//            amaliat.Click();
//            IWebElement menuContract = driver.FindElement(By.XPath("//*[@href='/Merchants/Contracts/Index']"));
//            menuContract.Click();
//            System.Threading.Thread.Sleep(3000);
//            IWebElement ContractNo = driver.FindElement(By.Id("ContractNo"));
//            ContractNo.Click();
//            ContractNo.SendKeys("MC0000001839551");
//            Thread.Sleep(2000);
  
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
//            IWebElement Edit  = driver.FindElement(By.LinkText("ويرايش"));

//            var href = Edit.GetAttribute("href");
//            driver.Navigate().GoToUrl(href);

//            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
//            // Edit.Click();
//            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(4);
//            Thread.Sleep(3000);


//            //نام فروشگاه فارسی 
//            IWebElement StoreNameFA = driver.FindElement(By.Id("StoreName"));
//            StoreNameFA.Click();
//            StoreNameFA.Clear();
//            StoreNameFA.SendKeys("سوهان حاج محمدی و برادران");

//            //نام فروشگاه انگلیسی  
//            IWebElement StoreNameEn = driver.FindElement(By.Id("StoreNameEn"));
//            StoreNameEn.Click();
//            StoreNameEn.Clear();
//            StoreNameEn.SendKeys("SOHAN MAMADI");

//            Thread.Sleep(3000);

//            ///اضافه کردن شبای جدید 

//            IWebElement RowNo = driver.FindElement(By.Id("RowNo"));
//            RowNo.Click();
//            RowNo.Clear();
//            RowNo.SendKeys("2");

//            // شماره شبا 
//            IWebElement iBAN = driver.FindElement(By.Id("IBAN"));
//            iBAN.Click();
//            iBAN.SendKeys("IR270170000000212797252001");
//            Thread.Sleep(2000);

//            //alert استعلام شبا 
//            IWebElement alert = driver.FindElement(By.XPath("//*[@type='button' and @class='btn btn-blue' and text()='متوجه شدم']"));
//            alert.Click();
//            Thread.Sleep(2000);

//            //شماره حساب 
//            IWebElement accountNo = driver.FindElement(By.XPath("//*[@id='contractManagementFromId']//*[@id='AccountNo']"));
//            accountNo.Click();
//            accountNo.SendKeys("0212797252001");

//            //بانک 
//            IWebElement Bankpk = driver.FindElement(By.Id("txtpartialBank"));
//            Bankpk.Click();
//            Bankpk.SendKeys("ملی");
//            Thread.Sleep(2000);
//            Bankpk.SendKeys(Keys.Down);
//            Bankpk.SendKeys(Keys.Enter);

//            //حوزه 
//            IWebElement zone = driver.FindElement(By.Id("txtpartialBankZone"));
//            zone.Click();
//            Thread.Sleep(2000);
//            zone.SendKeys("اداره امور تست سداد");
//            Thread.Sleep(2000);
//            zone.SendKeys(Keys.Down);
//            zone.SendKeys(Keys.Enter);

//            //وضعیت کد شبا 
//            IWebElement IBANStatusCode = driver.FindElement(By.Id("txtIBANStatusCode"));
//            IBANStatusCode.Clear();
//            IBANStatusCode.SendKeys("درخواست حساب فعال");
//            Thread.Sleep(2000);
//            IBANStatusCode.SendKeys(Keys.Down);
//            IBANStatusCode.SendKeys(Keys.Enter);

//            /////ویرایش  شبای موجود 
//            ///گرید عملیات
//            IWebElement gridamaliat = driver.FindElement(By.XPath("//*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[1]/td[12]/span/a"));
//            //*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[2]/td[12]/span/a
//            gridamaliat.Click();
//            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(4);
//            Thread.Sleep(3000);

//            ///ویرایش ادرس ردیف دوم
//            //*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[2]/td[12]/span/a

//            //حوزه 
//            IWebElement zone1 = driver.FindElement(By.Id("txtpartialBankZone"));
//            zone1.Click();
//            zone1.Clear();
//            Thread.Sleep(2000);
//            zone1.SendKeys("اداره امور تست سداد");
//            Thread.Sleep(2000);
//            zone1.SendKeys(Keys.Down);
//            zone1.SendKeys(Keys.Enter);

//            //شعبه  
//            //IWebElement Bankbranch = driver.FindElement(By.Id("txtpartialBankBranch"));
//            //Bankbranch.Click();
//            //Bankbranch.SendKeys("");
//            //Thread.Sleep(2000);
//            //Bankbranch.SendKeys(Keys.Down);
//            //Bankbranch.SendKeys(Keys.Enter);

//            //وضعیت کد شبا 
//            IWebElement IBANStatusCode1 = driver.FindElement(By.Id("txtIBANStatusCode"));
//            IBANStatusCode1.Clear();
//            IBANStatusCode1.SendKeys("درخواست حساب فعال");
//            Thread.Sleep(2000);
//            IBANStatusCode1.SendKeys(Keys.Down);
//            IBANStatusCode1.SendKeys(Keys.Enter);

//            //ذخیره 
//            IWebElement save = driver.FindElement(By.XPath("//input[@type='button' and @value='ذخیره']"));
//            save.Click();
//            Thread.Sleep(6000);

//            //ارسال
//            IWebElement Send = driver.FindElement(By.XPath("//input[@type='button' and  @value='ارسال']"));
//            Send.Click();
//            Thread.Sleep(10000);



//            driver.Close();
//            driver.Quit();

//        }

//    }
//}
