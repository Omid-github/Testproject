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
    public class TakhsisIPG : BaseTest
    {
        [When(@"The user fills IPG Assign informations as following:")]
        public void WhenTheUserFillsIPGAssignInformationsAsFollowing(Table table)
        {
            var TakhsisInfo = table.CreateSet<TakhsisInfo>();

            //نوع پایانه 
            IWebElement TermType = Driver.FindElement(By.Id("txtTerminalModel_TermTypeCode"));
            TermType.Click();
            TermType.Clear();
            TermType.SendKeys(TakhsisInfo.First().TermType);
            Thread.Sleep(1000);

            //محل نصب انگلیسی 
            IWebElement InstallLocNameEN = Driver.FindElement(By.Id("InstallLoc_NameEn"));
            InstallLocNameEN.Click();
            InstallLocNameEN.Clear();
            InstallLocNameEN.SendKeys(TakhsisInfo.First().InstallLocNameEN);

            //کد پستی
            IWebElement PostalCode = Driver.FindElement(By.Id("InstallLoc_PostalCode"));
            PostalCode.Click();
            PostalCode.Clear();
            PostalCode.SendKeys(TakhsisInfo.First().PostalCode);

            //تلفن همراه
            IWebElement InstallLoc_MobileNo = Driver.FindElement(By.Id("InstallLoc_MobileNo"));
            InstallLoc_MobileNo.Click();
            InstallLoc_MobileNo.Clear();
            InstallLoc_MobileNo.SendKeys(TakhsisInfo.First().InstallLoc_MobileNo);

            ///افزودن شبای پایانه 
            //شبای قرارداد
            IWebElement IBAN = Driver.FindElement(By.Id("txtMerchantContractIBAN_PK"));
            IBAN.Click();
            IBAN.SendKeys(TakhsisInfo.First().IBAN);
            IBAN.SendKeys(Keys.Down);
            IBAN.SendKeys(Keys.Enter);
            Thread.Sleep(2000);


            ////تاثیر گذاری سهیم 
            //IWebElement BehaveID = Driver.FindElement(By.Id("txtMultiplexingValueBehaviorId"));
            //BehaveID.Clear();
            //BehaveID.SendKeys("مقدار جاری");
            //Thread.Sleep(2000);
            //BehaveID.SendKeys(Keys.Down);
            //BehaveID.SendKeys(Keys.Enter);
            //Thread.Sleep(1000);

            //اضافه کردن
            IWebElement Add1 = Driver.FindElement(By.XPath("//*[@id='merchantTerminalManagementFromId']//div[17]//input[@value='اضافه کردن']"));
            Add1.Click();
            Thread.Sleep(4000);

        }

        [When(@"The user fills IPG Specific information as following:")]
        public void WhenTheUserFillsIPGSpecificInformationAsFollowing(Table table)
        {

            var TakhsisInfo = table.CreateSet<TakhsisInfo>();
            //زمان معکوس شدن تراکنش
            IWebElement RemainReversal = Driver.FindElement(By.Id("txtTerminalRemainReversal"));
            RemainReversal.Click();
            RemainReversal.Clear();
            RemainReversal.SendKeys(TakhsisInfo.First().RemainReversal);
            Thread.Sleep(2000);
            RemainReversal.SendKeys(Keys.Down);
            RemainReversal.SendKeys(Keys.Enter);

            //زمان لازم برای ارسال تراکنش معکوس شده 
            IWebElement ReverseTimeOut = Driver.FindElement(By.Id("txtReverseTimeout"));
            ReverseTimeOut.Click();
            ReverseTimeOut.Clear();
            ReverseTimeOut.SendKeys(TakhsisInfo.First().ReverseTimeOut);

            ///اطلاعات اختصاصی IPG
            ///

            //url فروشگاه 
            IWebElement StoreURL = Driver.FindElement(By.Id("StoreURL"));
            StoreURL.Click();
            Thread.Sleep(2000);
            StoreURL.SendKeys(TakhsisInfo.First().StoreUrl);
            Thread.Sleep(2000);

            //سازمان
            IWebElement Organization = Driver.FindElement(By.Id("txtOrganizationCode"));
            Organization.Click();
            Thread.Sleep(2000);
            Organization.SendKeys(TakhsisInfo.First().Organization);
            RemainReversal.SendKeys(Keys.Down);
            RemainReversal.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            //Ip فروشگاه 
            IWebElement StoreIps = Driver.FindElement(By.XPath("/html/body//*[@class='select2-search__field' and @type='search']"));
            StoreIps.Click();
            StoreIps.SendKeys(TakhsisInfo.First().StoreIp);
            StoreIps.SendKeys(Keys.Enter);
            Thread.Sleep(4000);
            //پورت فروشگاه
            IWebElement StorePort = Driver.FindElement(By.Id("StorePort"));
            StorePort.Click();
            StorePort.SendKeys(TakhsisInfo.First().StorePort);

            //تاریخ شروع اعتبار اینماد
            IWebElement EnamadStartDate = Driver.FindElement(By.Id("StartDateEnamad_dateTime"));
            EnamadStartDate.Click();
            EnamadStartDate.SendKeys(TakhsisInfo.First().EnamadStartDate);
            EnamadStartDate.SendKeys(Keys.Enter);

            //تاریخ پایان اعتبار اینماد
            IWebElement EnamadEndDate = Driver.FindElement(By.Id("EndDateEnamad_dateTime"));
            EnamadEndDate.Click();
            EnamadEndDate.SendKeys(TakhsisInfo.First().EnamadEndDate);
            StoreIps.SendKeys(Keys.Enter);

            //ایمیل فروشگاه 
            IWebElement StoreEmail = Driver.FindElement(By.Id("StoreEmail"));
            StoreEmail.Click();
            StoreEmail.SendKeys(TakhsisInfo.First().StoreEmail);
            //مهلت دریافت نماد الکترونیکی 


            var  Add = Driver.FindElements(By.XPath("//input[@value='اضافه کردن']"));
            Add[0].Click();
            Thread.Sleep(2000);


        }

    }

}



