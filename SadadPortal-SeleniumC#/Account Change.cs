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


//    public class AccountChange
//    {
//        // public IWebDriver driver;
//        static void main()
//        {

//        }
//        [Test]
//        public void Account_Change()
//        {
//            //List<string> msgs = new List<string>();

//            //Initialize
//            var Login = new Login_portal();
//            var driver = Login.StartBrowser();

//            //ورود به فرم مدیریت پایانه های پذیرندگان 
//            IWebElement amaliat = driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
//            amaliat.Click();
//            Thread.Sleep(2000);
//            IWebElement MerchantTerminal = driver.FindElement(By.XPath("//*[@href='/Merchants/MerchantTerminal/Edit']"));
//            MerchantTerminal.Click();
//            IWebElement cardacqid = driver.FindElement(By.Id("txtCardAcqId"));
//            cardacqid.Click();
//            cardacqid.SendKeys("000000000000068");
//            Thread.Sleep(2000);
//            cardacqid.SendKeys(Keys.Down);
//            cardacqid.SendKeys(Keys.Enter);
//            //وضعیت پایانه 
//            IWebElement TermStatus = driver.FindElement(By.Id("txtTermStatusCode"));
//            TermStatus.Click();
//            TermStatus.Clear();
//            TermStatus.SendKeys("راه اندازی شده");
//            Thread.Sleep(2000);
//            TermStatus.SendKeys(Keys.Down);
//            TermStatus.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);
//            // سرچ با پایانه
//            IWebElement Terminal = driver.FindElement(By.Id("txtTerminalId"));
//            Terminal.Click();
//            Terminal.SendKeys("00000165");
//            Thread.Sleep(4000);
//            Terminal.SendKeys(Keys.Down);
//            Terminal.SendKeys(Keys.Enter);
//            Thread.Sleep(1000);

//            //جستجو
//            IWebElement search = driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
//            search.Click();
//            Thread.Sleep(2000);
//            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
//            //IWebElement amaliyatGrid = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("button.ui-button[role='button']")));
//            ////button#id//button.class//button[class='']//button.class[attribute='']
//            //amaliyatGrid.Click();
//            var amaliyatGrid = driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
//            amaliyatGrid[0].Click();

//            //درخواست تغییر حساب
//            Thread.Sleep(1000);
//            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
//            IWebElement AccountChange = wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(), 'درخواست تغییر حساب')]")));
//            var href = AccountChange.GetAttribute("href");
//            driver.Navigate().GoToUrl(href);
//            System.Threading.Thread.Sleep(5000);

//            //حذف شبای اول 
//            var HazfLink = driver.FindElements(By.LinkText("حذف"));
//            HazfLink[0].Click();
//            //HazfLink[1].Click();
//            Thread.Sleep(10000);

         
//            //روش پرداخت 

//            IWebElement PayMode = driver.FindElement(By.Id("txtNewTermPaymentMode"));
//            PayMode.Click();
//            PayMode.SendKeys("واریز انتخابی");
//            Thread.Sleep(1000);
//            PayMode.SendKeys(Keys.Down);
//            PayMode.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            //شبای اول 
//            IWebElement FirstIBAN = driver.FindElement(By.Id("txtMerchantContractIbanPk"));
//            FirstIBAN.Click();
//            FirstIBAN.SendKeys(Keys.Down);
//            FirstIBAN.SendKeys(Keys.Enter);
//            //افزودن شبای قرارداد
//            IWebElement IBAN = driver.FindElement(By.Id("txtMerchantContractIbanPk"));
//            IBAN.Click();
//            var AddedIBAN = driver.FindElement(By.XPath("/html/body//div//div[6]/section/div[1]/div[1]/div/div/div/div[4]/div/div/div[1]//div[1]/div/div/table/tbody/tr[1]/td[1]/span/label")).Text;
//            //msgs.Add("شبای اضافه شده پشت پایانه" + AddedIBAN);
//            System.Diagnostics.Debug.WriteLine(AddedIBAN + ":شبای اضافه شده پشت پایانه");
//            IWebElement Tashim = driver.FindElement(By.Id("txtMultiplexingValueBehaviorId"));
//            Tashim.Click();
//            //مقدار جاری
//            Tashim.SendKeys(Keys.Down);
//            //مقدار باقیمانده
//            // Tashim.SendKeys(Keys.Down);
//            Tashim.SendKeys(Keys.Enter);
//            //وضعیت 
//            IWebElement Status = driver.FindElement(By.Id("txtMerchantTerminalIBAN_StatusCode"));
//            Status.Click();
//            //درخواست حساب غیر فعال 
//            //  Status.SendKeys(Keys.Down);

//            //درخواست   فعال 
//            Status.SendKeys("فعال");
//            Thread.Sleep(2000);
//            Status.SendKeys(Keys.Down);
//            Status.SendKeys(Keys.Enter);

//            //اضافه کردن 
//            IWebElement TOAddIBAN = driver.FindElement(By.XPath("//input[@type='button' and @value='اضافه کردن']"));
//            TOAddIBAN.Click();
//            Thread.Sleep(3000);

//            //توضیحات 
//            IWebElement Desc = driver.FindElement(By.Id("Description"));
//            Desc.Click();
//            Desc.SendKeys("درخواست تغییر حساب پذیرنده");
//            Thread.Sleep(3000);

//            //ارسال 
//            IWebElement Send = driver.FindElement(By.XPath("//input[@type='button' and @value='ارسال']"));
//            Send.Click();
//            Thread.Sleep(5000);

//            IWebElement successNotif = driver.FindElement(By.XPath("//*[@id='content']/div[3]/div[1]/div/ul/li"));
//            var ActualResult = successNotif.Text;
//            var ExpectedResult = "عملیات ثبت با موفقیت انجام شد";
//            if (ActualResult.Equals(ExpectedResult))
//            {

//                //تایید شاپرکی 

//                driver.Url = "http://172.24.34.40/Merchants/MerchantTerminal/MerchantTerminalIbanChangeRequests";
//                IWebElement pazirande = driver.FindElement(By.Id("txtMerchantPk"));
//                pazirande.Click();
//                pazirande.SendKeys("000000000000068");
//                Thread.Sleep(2000);
//                pazirande.SendKeys(Keys.Down);
//                pazirande.SendKeys(Keys.Enter);
//                //جستجوی
//                IWebElement Search1 = driver.FindElement(By.CssSelector("input[value='جستجو']"));
//                Search1.Click();
//                Thread.Sleep(3000);
//                //ردیف اول 
//                IWebElement GRID = driver.FindElement(By.XPath("//table/tbody/tr[1]//button[@role='button']"));
//                GRID.Click();
//                //ردیف دوم
//                //IWebElement GRID2 = driver.FindElement(By.Id("/html//table/tbody/tr[2]//button[@role='button']"));
//                //GRID2.Click();

//                IWebElement subGrid = driver.FindElement(By.LinkText("تایید درخواست"));
//                subGrid.Click();
//                //تایید همه موارد
//                //IWebElement ApproveAll = driver.FindElement(By.CssSelector("input[type='button'][value='تایید همه موارد']"));
//                // ApproveAll.Click();
//                Thread.Sleep(6000);
//                //ویرایش پایانه پذیرندگان
//                driver.Url = "http://172.24.34.40/Merchants/MerchantTerminal/Edit";
//                Thread.Sleep(3000);
//                IWebElement cardacqid1 = driver.FindElement(By.Id("txtCardAcqId"));
//                cardacqid1.Click();
//                cardacqid1.SendKeys("000000000000068");
//                Thread.Sleep(2000);
//                cardacqid1.SendKeys(Keys.Down);
//                cardacqid1.SendKeys(Keys.Enter);
//                // سرچ با پایانه
//                IWebElement Terminal1 = driver.FindElement(By.Id("txtTerminalId"));
//                Terminal1.Click();
//                Terminal1.SendKeys("00000165");
//                Thread.Sleep(2000);
//                Terminal1.SendKeys(Keys.Down);
//                Terminal1.SendKeys(Keys.Enter);
//                Thread.Sleep(1000);
//                IWebElement search1 = driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
//                search1.Click();
//                Thread.Sleep(2000);

//                var amaliyatGrid1 = driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
//                amaliyatGrid1[0].Click();

//                //ویرایش 
//                Thread.Sleep(2000);
//                IWebElement EDIT = driver.FindElement(By.XPath("//a[text() ='ویرایش']"));
//                var href1 = EDIT.GetAttribute("href");
//                driver.Navigate().GoToUrl(href1);
//                System.Threading.Thread.Sleep(5000);
//                //IR030170000000307413960008
//                //IR020170000000108984475008
//                var IBANonTerminal = driver.FindElement(By.XPath("/html/body//div[17]//table/tbody//td[1]//label")).Text;
//                System.Diagnostics.Debug.WriteLine(IBANonTerminal + ": شبای اضافه شده پس از تایید شاپرکی ");

//                if (AddedIBAN.Equals(IBANonTerminal))
//                {
//                   // Console.WriteLine("شبای مورد نظر با موفقیت پشت پایانه قرار گرفت");
//                    Debug.WriteLine("شبای مورد نظر با موفقیت پشت پایانه قرار گرفت");
//                    Console.WriteLine("شبای مورد نظر با موفقیت پشت پایانه قرار گرفت");


//                }

//                //Assert.IsTrue(AddedContractIBAN.Equals(IBANonTerminal));
//                else
//                {
//                    //Console.WriteLine("شبای مورد نظر پشت پایانه اضافه نشده است ");
//                    Debug.WriteLine("شبای مورد نظر پشت پایانه اضافه نشده است ");
//                    Console.WriteLine("شبای مورد نظر با موفقیت پشت پایانه قرار گرفت");


//                }

//            }

//            else
//            {

//                Console.WriteLine("درخواست حساب فعال/غیر فعال ناموفق");
//                Debug.WriteLine("درخواست حساب فعال/غیر فعال ناموفق");


//            }
//            //String Path = @"C:\\Program Files\\PS.text";
//            //if (!System.IO.Directory.Exists(Path))
//            //{
//            //    Directory.CreateDirectory(Path);
//            //    using (StreamWriter s = File.CreateText(Path))
//            //    {
//            //        s.WriteLine(string.Join(Environment.NewLine, msgs));
//            //    }
//            //}
//            driver.Close();

//        }
//    }
//}





























