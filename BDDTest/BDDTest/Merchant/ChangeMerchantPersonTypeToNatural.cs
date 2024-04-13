using System;
using TechTalk.SpecFlow;
using System;
using TechTalk.SpecFlow;
using BDDTest.Set;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Diagnostics;
using System.Threading;
using TechTalk.SpecFlow.Assist;
using System.Linq;


    namespace BDDTest.Features
    {
        [Binding]
        public class ChangeMerchantPersonTypeToNatural : BaseTest
        {
        [Given(@"The user searches for a Legal merchant based on CardAcqId (.*) and PersonType (.*)")]
        public void GivenTheUserSearchesForALegalMerchantBasedOnCardAcqIdAndPersonType(string p0, string p1)
        {

            //ورود به فرم مدیریت  پذیرنده 

            IWebElement amaliat = Driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
            amaliat.Click();
            IWebElement menumerchant = Driver.FindElement(By.XPath("//*[@id='el_5']/ul/li[4]/a"));
            menumerchant.Click();
            System.Threading.Thread.Sleep(3000);
            IWebElement PersonTypeSearch = Driver.FindElement(By.Id("txtPersonType"));
            PersonTypeSearch.Click();
            PersonTypeSearch.Clear();
            PersonTypeSearch.SendKeys(p1);
            Thread.Sleep(2000);
            PersonTypeSearch.SendKeys(Keys.Down);
            PersonTypeSearch.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            Thread.Sleep(2000);
            IWebElement cardacqid = Driver.FindElement(By.Id("txtCardAcqId"));
            cardacqid.Click();
            //var ExcelObj = new Test_Data();
            //var excel = ExcelObj.MainTest();
            //cardacqid.SendKeys(excel[0].Cardacqid);
            cardacqid.SendKeys(p0);
            Thread.Sleep(2000);
            cardacqid.SendKeys(Keys.Down);
            cardacqid.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            //جستجو
            IWebElement search = Driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
            search.Click();
            Thread.Sleep(2000);

        }


    
        [When(@"The user fills out natural merchant information as following:")]
            public void WhenTheUserFillsOutNaturalMerchantInformationAsFollowing(Table table)
            {
            var amaliyatButton = Driver.FindElements(By.CssSelector("button.ui-button[role='button']"));

            amaliyatButton[0].Click();
            //ویرایش در گرید عملیات
            IWebElement Edit = Driver.FindElement(By.XPath("//*[text()='تغییر نوع پذیرنده']"));
            var href = Edit.GetAttribute("href");
            Driver.Navigate().GoToUrl(href);
            ///پذیرنده حقوقی به حقیقی  

            var MerchantInfo = table.CreateSet<MerchantInfo>();
            //نام
            IWebElement FirstName = Driver.FindElement(By.Id("FirstName"));
            FirstName.Click();
            FirstName.Clear();
            FirstName.SendKeys(MerchantInfo.First().FirstName);
            // نام انگلیسی
            IWebElement FirstNameEn = Driver.FindElement(By.Id("FirstNameEn"));
            FirstNameEn.Click();
            FirstNameEn.Clear();

            FirstNameEn.SendKeys(MerchantInfo.First().FirstNameEn);
            Thread.Sleep(2000);
            //کدملی
            IWebElement NationalCode = Driver.FindElement(By.Id("NationalCode"));
            NationalCode.Click();
            NationalCode.Clear();
            NationalCode.SendKeys(MerchantInfo.First().NationalCode);
            //نام خانوادگی
            IWebElement LastName = Driver.FindElement(By.Id("LastName"));
            LastName.Click();
            LastName.SendKeys(MerchantInfo.First().LastName);
            //نام خانوادگی انگلیسی 
            IWebElement LastNameEn = Driver.FindElement(By.Id("LastNameEn"));
            LastNameEn.Click();
            LastNameEn.Clear();
            LastNameEn.SendKeys(MerchantInfo.First().LastNameEn);

            //نام پدر  
            IWebElement FatherName = Driver.FindElement(By.Id("FatherName"));
            FatherName.Click();
            FatherName.Clear();
            FatherName.SendKeys(MerchantInfo.First().FatherName);

            //ملیت 
            IWebElement Nationality = Driver.FindElement(By.Id("txtCountryCode_A2"));
            Nationality.Click();
            Nationality.Clear();
            Nationality.SendKeys(MerchantInfo.First().txtCountryCode);
            // شماره شناسنامه   
            IWebElement IdentityNo = Driver.FindElement(By.Id("IdentityNo"));
            IdentityNo.Click();
            IdentityNo.Clear();
            IdentityNo.SendKeys("0082282838");
            // سریال  شناسنامه   
            IWebElement IdNoSerial = Driver.FindElement(By.Id("IdNoSerial"));
            IdNoSerial.Click();
            IdNoSerial.Clear();

            IdNoSerial.SendKeys(MerchantInfo.First().IdNoSerial);
            //  حرف سریال    
            IWebElement LetterID = Driver.FindElement(By.Id("txtIdNoSeriesLetterID"));
            LetterID.Click();
            LetterID.SendKeys(MerchantInfo.First().LetterID);
            LetterID.SendKeys(Keys.Down);
            LetterID.SendKeys(Keys.Enter);
            //  عدد سریال    
            IWebElement IdNoSeriesNumber = Driver.FindElement(By.Id("IdNoSeriesNumber"));
            IdNoSeriesNumber.Click();
            IdNoSeriesNumber.Clear();
            IdNoSeriesNumber.SendKeys(MerchantInfo.First().IdNoSeriesNumber);
            // وضعیت تاهل    
            IWebElement MaritalStatus = Driver.FindElement(By.Id("txtMaritalStatusCode"));
            MaritalStatus.Click();
            MaritalStatus.SendKeys(MerchantInfo.First().MaritalStatus);
            MaritalStatus.SendKeys(Keys.Down);
            MaritalStatus.SendKeys(Keys.Enter);

            //جنسیت    
            IWebElement SexCode = Driver.FindElement(By.Id("txtSexCode"));
            SexCode.Click();
            SexCode.SendKeys(MerchantInfo.First().SexCode);
            SexCode.SendKeys(Keys.Down);
            SexCode.SendKeys(Keys.Enter);

            //تاریخ انقضای گذرنامه
            IWebElement PassExpiryDate = Driver.FindElement(By.Id("PassportExpireDate_dateTime"));
            PassExpiryDate.Click();
            PassExpiryDate.Clear();
            PassExpiryDate.SendKeys(MerchantInfo.First().PassExpiryDate);

            //شماره گذرنامه
            IWebElement PassportNo = Driver.FindElement(By.Id("PassportNo"));
            PassportNo.Click();
            PassportNo.Clear();
            PassportNo.SendKeys(MerchantInfo.First().PassportNo);

        }

            [Then(@"The merchant should be changed to natural successfully")]
            public void ThenTheMerchantShouldBeChangedToNaturalSuccessfully()
            {
                IWebElement returnAnswer = Driver.FindElement(By.XPath("//*[text()= 'عملیات ثبت با موفقیت انجام شد']"));
                var Actualresult = returnAnswer.Text;
                var Expectedresult = "عملیات ثبت با موفقیت انجام شد";
                Assert.AreEqual(Actualresult, Expectedresult);
                System.Diagnostics.Debug.WriteLine("نتیجه تغییر پذیرنده حقوقی به حقیقی " + "\n" + Actualresult);
                Console.WriteLine("نتیجه تغییر پذیرنده حقوقی به حقیقی" + "\n" + Actualresult);

            }
        }
    }
