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
using BDDTest.Pages;

namespace BDDTest.Features
{
    [Binding]
    public class TakhsisPos : BaseTest
    {
        public TakhsisPage TakhsisPage { get; set; }

        public TakhsisPos() : base()

        {

          TakhsisPage = new TakhsisPage(Driver);

        }
        [Given(@"The user searches for the Merchant request based on (.*) and (.*)")]
        public void GivenTheUserSearchesForTheMerchantRequestBasedOnAnd(string p0, string p1)
        {

            //ورود به فرم ویرایش  پذیرنده 
            Driver.Navigate().GoToUrl(TakhsisPage.Url);
            Thread.Sleep(3000);
            //جستجو بر اساس شماره پذیرنده ,  شماره قرارداد
            TakhsisPage.OpenMenu.Click();
            Thread.Sleep(3000);

            TakhsisPage.Merchant.Click();
            //var ExcelObj = new Test_Data();
            //var excel = ExcelObj.MainTest();
            //cardacqid.SendKeys(excel[0].Cardacqid);
            Driver.SwitchTo().ActiveElement().SendKeys(p0);
            Thread.Sleep(2000);
            TakhsisPage.ContractNo.Click();
            //var ExcelObj = new Test_Data();
            //var excel = ExcelObj.MainTest();
            //cardacqid.SendKeys(excel[0].Cardacqid);
            Driver.SwitchTo()
                  .ActiveElement()
                  .SendKeys((p1));

            Thread.Sleep(2000);

            //جستجو
            TakhsisPage.Search.Click();
            Thread.Sleep(2000);

            ////شماره  قرارداد
            //IWebElement ContractNo = Driver.FindElement(By.Id("ContractNo"));
            //ContractNo.Click();
            //ContractNo.SendKeys(p1);
            //Thread.Sleep(1000);
            //ContractNo.SendKeys(Keys.Down);
            //ContractNo.SendKeys(Keys.Enter);
            //Thread.Sleep(1000);

            //IWebElement search = Driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
            //search.Click();
            //Thread.Sleep(3000);

        }
    
    [When(@"The user performs Takhsis operation")]
        public void WhenTheUserPerformsTakhsisOperation()
        {

            //تخصیص به پذیرنده در گرید عملیات 
            TakhsisPage.AmaliyatGrid.Click();
            //درخواست تغییر حساب
            Thread.Sleep(1000);
            Wait.Until(ExpectedConditions.ElementIsVisible(TakhsisPage.TakhsisBy));
            var href = TakhsisPage.Takhsis.GetAttribute("href");
            Driver.Navigate().GoToUrl(href);
            System.Threading.Thread.Sleep(3000);

            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
            // Edit.Click();
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(8);
            Thread.Sleep(2000);
        }

        [When(@"The user fills terminal request informations as following:")]
        public void WhenTheUserFillsTerminalRequestInformationsAsFollowing(Table table)
        {
            var TakhsisInfo = table.CreateSet<TakhsisInfo>();
            //مدل پایانه 
            TakhsisPage.TermModel.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(TakhsisInfo.First().TermModel);
            TakhsisPage.TermModel.SendKeys(Keys.Enter);

            Thread.Sleep(1000);
            // TakhsisPage.TermModel.SendKeys(Keys.Enter);

            ////سریال نامبر
            //IWebElement SerialNo = Driver.FindElement(By.Id("SerialNo"));
            //SerialNo.Click();
            //Thread.Sleep(1000);
            //SerialNo.SendKeys(TakhsisInfo.First().SerialNo);

            ////محل نصب انگلسیسی 
            //IWebElement InstallLocNameEN = Driver.FindElement(By.Id("InstallLoc_NameEn"));
            //InstallLocNameEN.Click();
            //InstallLocNameEN.Clear();
            //InstallLocNameEN.SendKeys(TakhsisInfo.First().InstallLocNameEN);

            //کد پستی

            TakhsisPage.PostalCode.Click();
            TakhsisPage.PostalCode.Clear();
            TakhsisPage.PostalCode.SendKeys(TakhsisInfo.First().PostalCode);
            Thread.Sleep(25000);

            //گروه صنفی 
            TakhsisPage.ParentShaparakMccCode.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(TakhsisInfo.First().ParentShaparakMccCode);
            Thread.Sleep(1000);

            TakhsisPage.ParentShaparakMccCode.SendKeys(Keys.Enter);
          //  Driver.SwitchTo().ActiveElement().SendKeys(Keys.Down);
          // Driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);

            Thread.Sleep(1000);
            // Thread.Sleep(1000);
            //TakhsisPage.ParentShaparakMccCode.SendKeys(Keys.Enter);

            //صنف 
            TakhsisPage.ShaparakMCC.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(TakhsisInfo.First().ShaparakMcc);
            Thread.Sleep(1000);
            TakhsisPage.ShaparakMCC.SendKeys(Keys.Enter);

            //Driver.SwitchTo().ActiveElement().SendKeys(TakhsisInfo.First().ShaparakMcc);
            //Driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);


            // Driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);


            //آخرین وضعیت موجود
            Wait.Until(ExpectedConditions.ElementToBeClickable(TakhsisPage.ExistanceStatusCodeBy));
            TakhsisPage.ExistanceStatusCode.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(TakhsisInfo.First().ExistanceStatusCode);
            Thread.Sleep(1000);
            TakhsisPage.ExistanceStatusCode.SendKeys(Keys.Enter);

            ///افزودن شبای پایانه 
            //شبای قرارداد

            TakhsisPage.TerminalIBANTab.Click();
            Thread.Sleep(1000);

            TakhsisPage.TerminalIBAN.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(TakhsisInfo.First().TerminalIBAN);
            Thread.Sleep(1000);
            TakhsisPage.TerminalIBAN.SendKeys(Keys.Enter);
            TakhsisPage.Add[1].Click();
            Thread.Sleep(2000);
            //تسهیم 
          
            TakhsisPage.MultiPlexingValuBehaviourId.Click();
            TakhsisPage.MultiPlexingValuBehaviourId.SendKeys(TakhsisInfo.First().MultiPlexingValuBehaviourId);
            TakhsisPage.MultiPlexingValuBehaviourId.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

        }


        [When(@"The user sumbits for TAKHSIS")]
        public void WhenTheUserSumbitsForTAKHSIS()
        {
            TakhsisPage.FinalSumbit.Click();
            Thread.Sleep(8000);

        }

        [Then(@"Terminal request should be assigned to a serialNo successfully")]
        public void ThenTerminalRequestShouldBeAssignedToASerialNoSuccessfully()
        {
            IWebElement successNotif = Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div//div[2]/text()"));
            var ActualResult = successNotif.Text;
            var ExpectedResult = "عملیات ثبت با موفقیت انجام شد";
            Assert.IsTrue(ActualResult.Contains(ExpectedResult));
            System.Diagnostics.Debug.WriteLine(ActualResult);
            Console.WriteLine(ActualResult);
        }

    }
}
