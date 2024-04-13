using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Threading;
using System.Collections;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
//using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.IO;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using BDDTest.Set;
using TechTalk.SpecFlow.Assist;

namespace BDDTest.Features
{
    [Binding]
    public class ContractSteps : BaseTest
    {
        [Given(@"Navigates to the MerchantContract Form")]
        public void GivenNavigatesToTheMerchantContractForm()
        {

            IWebElement amaliat = Driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
            amaliat.Click();
            IWebElement menuContract = Driver.FindElement(By.XPath("//*[@href='/Merchants/Contracts/Index']"));
            menuContract.Click();
            System.Threading.Thread.Sleep(3000);
           

        }

        [Given(@"The user searches for a contract based on MerchantNo (.*) and ContractNo (.*)")]
        public void GivenTheUserSearchesForAContractBasedOnMerchantNoAndContractNo(string p0, string p1)
        {

            IWebElement MerchantNo = Driver.FindElement(By.Id("txtMerchantPkList"));
            MerchantNo.Click();
            MerchantNo.SendKeys(p0);
            Thread.Sleep(4000);
            MerchantNo.SendKeys(Keys.Down);
            MerchantNo.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            //شماره  قرارداد
            IWebElement ContractNo = Driver.FindElement(By.Id("ContractNo"));
            ContractNo.Click();
            ContractNo.SendKeys(p1);
            Thread.Sleep(1000);
            ContractNo.SendKeys(Keys.Down);
            ContractNo.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            //جستجو
            IWebElement search = Driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
            search.Click();
            Thread.Sleep(2000);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
           

        }
        
        [When(@"The user Edits Contract information as following:")]
        public void WhenTheUserEditsContractInformationAsFollowing(Table table)
        {
            var amaliyatButton = Driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
            //button#id//button.class//button[class='']//button.class[attribute='']
            // amaliyatButton[0].Click();
            //amaliyatButton[1].Click();
            //amaliyatButton[2].Click();
            amaliyatButton[0].Click();
            //ویرایش در گرید عملیات
            IWebElement Edit = Driver.FindElement(By.LinkText("ويرايش"));

            var href = Edit.GetAttribute("href");
            Driver.Navigate().GoToUrl(href);

            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
            // Edit.Click();
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(4);
            Thread.Sleep(3000);
            var ContractInfo = table.CreateSet<ContractInfo>();

            //نام فروشگاه فارسی 
            IWebElement StoreNameFA = Driver.FindElement(By.Id("StoreName"));
            StoreNameFA.Click();
            StoreNameFA.Clear();
            StoreNameFA.SendKeys(ContractInfo.First().StoreNameFA);

            //نام فروشگاه انگلیسی  
            IWebElement StoreNameEn = Driver.FindElement(By.Id("StoreNameEn"));
            StoreNameEn.Click();
            StoreNameEn.Clear();
            StoreNameEn.SendKeys(ContractInfo.First().StoreNameEN);

            Thread.Sleep(3000);

            ///اضافه کردن شبای جدید 

            IWebElement RowNo = Driver.FindElement(By.Id("RowNo"));
            RowNo.Click();
            RowNo.Clear();
            RowNo.SendKeys(ContractInfo.First().RowNo);
            //عنوان حساب
            IWebElement AccountTitle = Driver.FindElement(By.Id("AccountTitle"));
            AccountTitle.Click();
            AccountTitle.Clear();
            AccountTitle.SendKeys(ContractInfo.First().AccountTitle);
            // شماره شبا 
            IWebElement iBAN = Driver.FindElement(By.Id("IBAN"));
            iBAN.Click();
            iBAN.SendKeys(ContractInfo.First().IBAN);
            Thread.Sleep(20000);

            //alert استعلام شبا 
            IWebElement alert = Driver.FindElement(By.XPath("//*[@type='button' and @class='btn btn-blue' and text()='متوجه شدم']"));
            alert.Click();
            Thread.Sleep(2000);

            //شماره حساب 
            IWebElement accountNo = Driver.FindElement(By.XPath("//*[@id='contractManagementFromId']//*[@id='AccountNo']"));
            accountNo.Click();
            accountNo.SendKeys(ContractInfo.First().AccountNo);

            //بانک 
            IWebElement Bankpk = Driver.FindElement(By.Id("txtpartialBank"));
            Bankpk.Click();
            Bankpk.SendKeys(ContractInfo.First().PartialBank);
            Thread.Sleep(2000);
            Bankpk.SendKeys(Keys.Down);
            Bankpk.SendKeys(Keys.Enter);

            //حوزه 
            IWebElement zone = Driver.FindElement(By.Id("txtpartialBankZone"));
            zone.Click();
            Thread.Sleep(2000);
            zone.SendKeys(ContractInfo.First().PartialBankZone);
            Thread.Sleep(2000);
            zone.SendKeys(Keys.Down);
            zone.SendKeys(Keys.Enter);

            //وضعیت کد شبا 
            IWebElement IBANStatusCode = Driver.FindElement(By.Id("txtIBANStatusCode"));
            IBANStatusCode.Clear();
            IBANStatusCode.SendKeys(ContractInfo.First().IBANStatusCode);
            Thread.Sleep(2000);
            IBANStatusCode.SendKeys(Keys.Down);
            IBANStatusCode.SendKeys(Keys.Enter);

            //ذخیره 
            IWebElement save = Driver.FindElement(By.XPath("//input[@type='button' and @value='ذخیره']"));
            save.Click();
            Thread.Sleep(6000);
            /////ویرایش  شبای موجود 
            ///گرید عملیات
            IWebElement gridamaliat = Driver.FindElement(By.XPath("//*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[1]/td[12]/span/a"));
            //*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[2]/td[12]/span/a
            gridamaliat.Click();
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(4);
            Thread.Sleep(3000);

            ///ویرایش ادرس ردیف دوم
            //*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[2]/td[12]/span/a

            //حوزه 
            IWebElement zone1 = Driver.FindElement(By.Id("txtpartialBankZone"));
            zone1.Click();
            zone1.Clear();
            Thread.Sleep(2000);
            zone1.SendKeys(ContractInfo.First().PartialBankZone);
            Thread.Sleep(2000);
            zone1.SendKeys(Keys.Down);
            zone1.SendKeys(Keys.Enter);

            //شعبه  
            IWebElement Bankbranch = Driver.FindElement(By.Id("txtpartialBankBranch"));
            Bankbranch.Click();
            Bankbranch.SendKeys(ContractInfo.First().Branch);
            Thread.Sleep(2000);
            Bankbranch.SendKeys(Keys.Down);
            Bankbranch.SendKeys(Keys.Enter);

            //وضعیت کد شبا 
            IWebElement IBANStatusCode1 = Driver.FindElement(By.Id("txtIBANStatusCode"));
            IBANStatusCode1.Clear();
            IBANStatusCode1.SendKeys(ContractInfo.First().IBANStatusCode);
            Thread.Sleep(2000);
            IBANStatusCode1.SendKeys(Keys.Down);
            IBANStatusCode1.SendKeys(Keys.Enter);

            //ذخیره 
            IWebElement save1 = Driver.FindElement(By.XPath("//input[@type='button' and @value='ذخیره']"));
            save1.Click();
            Thread.Sleep(6000);
           
        }

        [Then(@"The contract should be modified successfully")]
        public void ThenTheContractShouldBeModifiedSuccessfully()
        {


            var ExpectedResult = "عملیات به روز رسانی با موفقیت انجام شد";
            IWebElement successNotif = Driver.FindElement(By.XPath("//*[text()= 'عملیات به روز رسانی با موفقیت انجام شد']"));
            var ActualResult = successNotif.Text;
            Assert.AreEqual(ActualResult,ExpectedResult);
            System.Diagnostics.Debug.WriteLine(ActualResult);
            Console.WriteLine(ActualResult);

        }
    }
}
