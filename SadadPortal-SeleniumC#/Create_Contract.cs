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
//    public class Create_Contract
//    {
//        //public IWebDriver driver;
        
//        [Test]
//        public void CreateContract()
//        {
            
//            var login = new Login_portal();
//            var driver = login.StartBrowser();

//            //ورود به فرم ویرایش  پذیرنده 

//            IWebElement amaliat = driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
//            amaliat.Click();
//            IWebElement menuContract = driver.FindElement(By.XPath("//*[@href='/Merchants/Contracts/Index']"));
//            menuContract.Click();
//            System.Threading.Thread.Sleep(3000);
//            //اضافه کردن
//            IWebElement Add = driver.FindElement(By.XPath("//*[@href='/Merchants/Contracts/CreateMerchantContract']"));
//            Add.Click();
//            Thread.Sleep(1000);

//            //شماره پذیرنده
//            IWebElement CardAcqid = driver.FindElement(By.Id("txtPartialMerchantPK"));
//            CardAcqid.Click();
//            CardAcqid.SendKeys("000000140337788");
//            Thread.Sleep(2000);
//            CardAcqid.SendKeys(Keys.Down);
//            CardAcqid.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);


//            //نمایندگی
//            IWebElement Agency = driver.FindElement(By.Id("txtContracted_AcqAgencyPK"));
//            Agency.Click();
//            Agency.SendKeys("اصفهان");
//            Thread.Sleep(2000);
//            Agency.SendKeys(Keys.Down);
//            Agency.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);


//            //نام فروشگاه فارسی 
//            IWebElement StoreNameFA = driver.FindElement(By.Id("StoreName"));
//            StoreNameFA.Click();
//            StoreNameFA.Clear();
//            StoreNameFA.SendKeys("سوهان حاج محمدی و برادران");

//            //شعبه 
//            IWebElement Branch = driver.FindElement(By.Id("txtContracted_BankBranchPK"));
//            Branch.Click();
//            Branch.Clear();
//            Branch.SendKeys("سیدخندان");
//            Thread.Sleep(2000);
//            Agency.SendKeys(Keys.Down);
//            Agency.SendKeys(Keys.Enter);


//            //پایانه درخواستی 
//            IWebElement RequestedTermsCount = driver.FindElement(By.Id("RequestedTermsCount"));
//            RequestedTermsCount.Click();
//            RequestedTermsCount.Clear();
//            RequestedTermsCount.SendKeys("1");

//            //نوع پایانه 

//            IWebElement termtype = driver.FindElement(By.Id("txtTermTypeCode"));
//            termtype.Click();
//            termtype.SendKeys("پایانه فروشگاهی");
//            Thread.Sleep(1000);
//            termtype.SendKeys(Keys.Down);
//            termtype.SendKeys(Keys.Enter);

//            ///اضافه کردن شبای جدید 

//            //// پاک کردن صاحب حساب شریک تجاری مربوط به پذیرنده اصلی که به اشتباه لود  می شود --باگ سیستم 
//            //IWebElement RelatedMerchnatPK = driver.FindElement(By.Id("txtPatrialRelatedMerchnatPK"));
//            //RelatedMerchnatPK.Click();

//            //RelatedMerchnatPK.SendKeys(Keys.Backspace);
//            //IWebElement RowNo = driver.FindElement(By.Id("RowNo"));
//            //RowNo.Click();
//            //RowNo.Clear();
//            //RowNo.SendKeys("2");

//            // شماره شبا 
//            IWebElement iBAN = driver.FindElement(By.Id("IBAN"));
//            iBAN.Click();
//            iBAN.SendKeys("IR810170000000227545995008");
//            Thread.Sleep(25000);

//            //alert استعلام شبا 
//            IWebElement alert = driver.FindElement(By.XPath("//*[@type='button' and @class='btn btn-blue' and text()='متوجه شدم']"));
//            alert.Click();
//            Thread.Sleep(2000);

//            //شماره حساب 
//            IWebElement accountNo = driver.FindElement(By.XPath("//*[@id='contractManagementFromId']//*[@id='AccountNo']"));
//            accountNo.Click();
//            accountNo.SendKeys("0227545995008");

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

//            //ذخیره 
//            IWebElement Add1 = driver.FindElement(By.XPath("//input[@type='button' and @value='اضافه کردن']"));
//            Add1.Click();
//            Thread.Sleep(3000);

//            //ارسال
//            IWebElement Send = driver.FindElement(By.XPath("//input[@type='button' and  @value='ارسال']"));
//            Send.Click();
//            Thread.Sleep(25000);

//            //نتیجه ساخت قرارداد
//            IWebElement returnAnswer = driver.FindElement(By.XPath("//*[@id='content']/div[3]/div[1]/div/ul/li"));
//            var Actualresult = returnAnswer.Text;
//            var Expectedresult = "با موفقیت ذخیره شد";
//            Assert.IsTrue(Actualresult.Contains(Expectedresult));
//            System.Diagnostics.Debug.WriteLine("نتیجه ساخت قرارداد " + "\n" + Actualresult);
//            Console.WriteLine("نتیجه ساخت قرارداد " + "\n" + Actualresult);
//            Thread.Sleep(3000);

         
//            //تایید همه موارد
//            //IWebElement ApproveAll = driver.FindElement(By.CssSelector("input[type='button'][value='تایید همه موارد']"));
//            // ApproveAll.Click();
//            //driver.Close();
//            //driver.Quit();

//        }

//    }
//}
