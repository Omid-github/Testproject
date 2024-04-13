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
////using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;

//namespace Selenium
//{
//    class New_Contract
//    {

//        [Test]
//        public void NewContract()
//        {

//            //Initialize
//            var Login = new Login_portal();
//            var driver = Login.StartBrowser();

//            //مدیریت قرارداد

//            IWebElement amaliat = driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
//            amaliat.Click();
//            IWebElement menucontract = driver.FindElement(By.XPath("//a[@href='/Merchants/Contracts/Index']"));
//            menucontract.Click();
//            System.Threading.Thread.Sleep(3000);
//            //ایجاد قرارداد
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
//            IWebElement addContract = wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id='contractManagementFromId']/a/i")));
//            // IWebElement addmerchant = driver.FindElement(By.XPath("//a[@data-original-title='اضافه كردن پذیرنده']"));
//            addContract.Click();

//            ///اطلاعات پذیرنده
//               //شماره پذیرنده 
//            Thread.Sleep(3000);
//            IWebElement merchantNo = driver.FindElement(By.Id("txtPartialMerchantPK"));
//            merchantNo.Click();
//            merchantNo.SendKeys("000000000000086");
//            Thread.Sleep(2000);
//            merchantNo.SendKeys(Keys.Down);
//            merchantNo.SendKeys(Keys.Enter);



//            //نمایندگی
//            IWebElement Agency = driver.FindElement(By.Id("txtContracted_AcqAgencyPK"));
//            Agency.Click();
//            Agency.SendKeys("تهران . شمال");
//            Thread.Sleep(2000);
//            Agency.SendKeys(Keys.Down);
//            Agency.SendKeys(Keys.Enter);

//            //نام فوشگاه فارسی 
//            IWebElement StoreName = driver.FindElement(By.Id("StoreName"));
//            StoreName.Click();
//            StoreName.SendKeys("سوهان احمدی و برادران");

//            //حوزه 
//            IWebElement zone1 = driver.FindElement(By.Id("txtBankZonePk"));
//            zone1.Click();
//            zone1.SendKeys("اداره امور تست سداد");
//            Thread.Sleep(2000);
//            zone1.SendKeys(Keys.Down);
//            zone1.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            //پایانه درخواستی 
//            IWebElement terminalInc = driver.FindElement(By.Id("RequestedTermsCount"));
//            terminalInc.Click();
//            terminalInc.Clear();
//            terminalInc.SendKeys("1");
//            Thread.Sleep(1000);

//            ///مدیریت شبا
//            //شماره شبا 
//            IWebElement IbanNo = driver.FindElement(By.Id("IBAN"));
//            IbanNo.Click();
//            IbanNo.SendKeys("IR060170000000344019841003");
//            Thread.Sleep(3000);

//            //alert استعلام شبا 
//            IWebElement alert = driver.FindElement(By.XPath("//*[@type='button' and @class='btn btn-blue' and text()='متوجه شدم']"));
//            alert.Click();
//            Thread.Sleep(1000);

//            //شماره حساب 
//            IWebElement AccountNo = driver.FindElement(By.Id("AccountNo"));
//            AccountNo.Click();
//            AccountNo.SendKeys("0344019841003");
//            Thread.Sleep(1000);
//            //حوزه 
//            IWebElement zone = driver.FindElement(By.Id("txtpartialBankZone"));
//            zone.Click();
            
//            zone.SendKeys("اداره امور تست سداد");
//            Thread.Sleep(2000);
//            zone.SendKeys(Keys.Down);
//            zone.SendKeys(Keys.Enter);
//            //شعبه 
//            IWebElement Bzone = driver.FindElement(By.Id("txtpartialBankBranch"));
//            Bzone.Click();
//            Bzone.SendKeys("اول");
//            Thread.Sleep(2000);
//            Bzone.SendKeys(Keys.Down);
//            Bzone.SendKeys(Keys.Enter);
//            //وضعیت شبا
//            IWebElement statuscode = driver.FindElement(By.Id("txtIBANStatusCode"));
//            statuscode.Click();
//            statuscode.SendKeys("درخواست حساب فعال");
//            Thread.Sleep(2000);
//            statuscode.SendKeys(Keys.Down);
//            statuscode.SendKeys(Keys.Enter);

//            //اضافه کردن 
//            IWebElement Add3 = driver.FindElement(By.XPath("//*[@id='contractManagementFromId']/div[8]/section/div/div[1]/div[2]/div/div/input"));
//            Add3.Click();

//            ///ارسال 
//            IWebElement Send = driver.FindElement(By.XPath("//*[@id='contractManagementFromId']/div[1]/div/input"));
//            Send.Click();
//            Thread.Sleep(10000);


//            IWebElement returnAnswer = driver.FindElement(By.XPath("//*[@id='content']/div[3]/div[1]/div/ul/li"));
//            var Actualresult = returnAnswer.Text;
//            var Expectedresult = "دستور نصب/تغییر نمایندگی";
//            Assert.IsTrue(Actualresult.Contains(Expectedresult));
//            System.Diagnostics.Debug.WriteLine("نتیجه ساخت قرارداد " + "\n" + Actualresult);
//            driver.Close();
//        }
//        //Console.WriteLine("test2");

//        ////خروج و بستن مرورگر

//    }
//}











































