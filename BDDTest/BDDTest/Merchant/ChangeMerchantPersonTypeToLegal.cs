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
    public class ChangeMerchantPersonTypeToLegal : BaseTest
    {
        [When(@"The user fills out legal merchant information as following:")]
        public void WhenTheUserFillsOutLegalMerchantInformationAsFollowing(Table table)
        {
            var amaliyatButton = Driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
          
            amaliyatButton[0].Click();
            //ویرایش در گرید عملیات
            IWebElement Edit = Driver.FindElement(By.XPath("//*[text()='تغییر نوع پذیرنده']"));
            var href = Edit.GetAttribute("href");
            Driver.Navigate().GoToUrl(href);
            ///پذیرنده حقیقی به حقوقی 
            
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


            //ثبت شرکت
            IWebElement LicenseNo = Driver.FindElement(By.Id("LicenseNo"));
            LicenseNo.Click();
            LicenseNo.Clear();
            Thread.Sleep(1000);
            LicenseNo.SendKeys(MerchantInfo.First().LicenseNo);

            //تاریخ ثبت شرکت 
            IWebElement LicenseDate = Driver.FindElement(By.Id("LicenseDate_dateTime"));
            LicenseDate.Click();
            LicenseDate.Clear();
            LicenseDate.SendKeys(MerchantInfo.First().LicenseDate);
            LicenseDate.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

        }

        [Then(@"The merchant should be changed to Legal successfully")]
        public void ThenTheMerchantShouldBeChangedToLegalSuccessfully()
        {

            IWebElement returnAnswer = Driver.FindElement(By.XPath("//*[text()= 'عملیات ثبت با موفقیت انجام شد']"));
            var Actualresult = returnAnswer.Text;
            var Expectedresult = "عملیات ثبت با موفقیت انجام شد";
            Assert.AreEqual(Actualresult, Expectedresult);
            System.Diagnostics.Debug.WriteLine("نتیجه تغییر پذیرنده حقیقی به حقوقی " + "\n" + Actualresult);
            Console.WriteLine("نتیجه تغییر پذیرنده حقیقی به حقوقی " + "\n" + Actualresult);


        }
    }
}
