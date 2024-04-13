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
    public class CreateContract : BaseTest
    {
        [Given(@"Navigates to the CreateMerchantContract Form")]
        public void GivenNavigatesToTheCreateMerchantContractForm()
        {
            //ورود به فرم ویرایش  پذیرنده 

            IWebElement amaliat = Driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
            amaliat.Click();
            IWebElement menuContract = Driver.FindElement(By.XPath("//*[@href='/Merchants/Contracts/Index']"));
            menuContract.Click();
            System.Threading.Thread.Sleep(3000);
            //اضافه کردن
            IWebElement Add = Driver.FindElement(By.XPath("//*[@href='/Merchants/Contracts/CreateMerchantContract']"));
            Add.Click();
            Thread.Sleep(1000);

        }
            [When(@"The user fills out Contract information as following :")]
        public void WhenTheUserFillsOutContractInformationAsFollowing(Table table)
        {
            var ContractInfo = table.CreateSet<ContractInfo>();

            //شماره پذیرنده
            IWebElement CardAcqid = Driver.FindElement(By.Id("txtPartialMerchantPK"));
            CardAcqid.Click();
            CardAcqid.SendKeys(ContractInfo.First().CardAcqid);
            Thread.Sleep(2000);
            CardAcqid.SendKeys(Keys.Down);
            CardAcqid.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            //نمایندگی
            IWebElement Agency = Driver.FindElement(By.Id("txtContracted_AcqAgencyPK"));
            Agency.Click();
            Agency.SendKeys(ContractInfo.First().Agency);
            Thread.Sleep(2000);
            Agency.SendKeys(Keys.Down);
            Agency.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            //نام فروشگاه فارسی 
            IWebElement StoreNameFA = Driver.FindElement(By.Id("StoreName"));
            StoreNameFA.Click();
            StoreNameFA.Clear();
            StoreNameFA.SendKeys(ContractInfo.First().StoreNameFA);

            //شعبه 
            IWebElement Branch = Driver.FindElement(By.Id("txtContracted_BankBranchPK"));
            Branch.Click();
            Branch.Clear();
            Branch.SendKeys(ContractInfo.First().Branch);
            Thread.Sleep(2000);
            Branch.SendKeys(Keys.Down);
            Branch.SendKeys(Keys.Enter);

            //پایانه درخواستی 
            IWebElement RequestedTermsCount = Driver.FindElement(By.Id("RequestedTermsCount"));
            RequestedTermsCount.Click();
            RequestedTermsCount.Clear();
            RequestedTermsCount.SendKeys(ContractInfo.First().RequestedTermsCount);

            //نوع پایانه 

            IWebElement termtype = Driver.FindElement(By.Id("txtTermTypeCode"));
            termtype.Click();
            termtype.SendKeys(ContractInfo.First().Termtype);
            Thread.Sleep(1000);
            termtype.SendKeys(Keys.Down);
            termtype.SendKeys(Keys.Enter);

            ///اضافه کردن شبای جدید 

            //// پاک کردن صاحب حساب شریک تجاری مربوط به پذیرنده اصلی که به اشتباه لود  می شود --باگ سیستم 
            //IWebElement RelatedMerchnatPK = driver.FindElement(By.Id("txtPatrialRelatedMerchnatPK"));
            //RelatedMerchnatPK.Click();

            //RelatedMerchnatPK.SendKeys(Keys.Backspace);

            IWebElement RowNo = Driver.FindElement(By.Id("RowNo"));
            RowNo.Click();
            RowNo.Clear();
            RowNo.SendKeys(ContractInfo.First().RowNo);

            // شماره شبا 
            IWebElement iBAN = Driver.FindElement(By.Id("IBAN"));
            iBAN.Click();
            iBAN.SendKeys(ContractInfo.First().IBAN);
            Thread.Sleep(25000);

            //alert استعلام شبا 
            IWebElement alert = Driver.FindElement(By.XPath("//*[@type='button' and @class='btn btn-blue' and text()='متوجه شدم']"));
            alert.Click();
            Thread.Sleep(2000);

            //شماره حساب 
            IWebElement AccountNo = Driver.FindElement(By.XPath("//*[@id='contractManagementFromId']//*[@id='AccountNo']"));
            AccountNo.Click();
            AccountNo.SendKeys(ContractInfo.First().AccountNo);

            //بانک 
            IWebElement Bankpk = Driver.FindElement(By.Id("txtpartialBank"));
            Bankpk.Click();
            Bankpk.SendKeys(ContractInfo.First().PartialBank);
            Thread.Sleep(2000);
            Bankpk.SendKeys(Keys.Down);
            Bankpk.SendKeys(Keys.Enter);

            //حوزه 
            IWebElement Zone = Driver.FindElement(By.Id("txtpartialBankZone"));
            Zone.Click();
            Thread.Sleep(2000);
            Zone.SendKeys(ContractInfo.First().PartialBankZone);
            Thread.Sleep(2000);
            Zone.SendKeys(Keys.Down);
            Zone.SendKeys(Keys.Enter);

            //وضعیت کد شبا 
            IWebElement IBANStatusCode = Driver.FindElement(By.Id("txtIBANStatusCode"));
            IBANStatusCode.Clear();
            IBANStatusCode.SendKeys(ContractInfo.First().IBANStatusCode);
            Thread.Sleep(2000);
            IBANStatusCode.SendKeys(Keys.Down);
            IBANStatusCode.SendKeys(Keys.Enter);
            //ذخیره 
            IWebElement Add1 = Driver.FindElement(By.XPath("//input[@ type='button' and @value='اضافه کردن']"));
            Add1.Click();
            Thread.Sleep(3000);

        }

        [Then(@"The contract should be created successfully")]
        public void ThenTheContractShouldBeCreatedSuccessfully()
        {
            //نتیجه ساخت قرارداد
            IWebElement returnAnswer = Driver.FindElement(By.XPath("//*[@id='content']/div[3]/div[1]/div/ul/li"));
            var Actualresult = returnAnswer.Text;
            var Expectedresult = "با موفقیت ذخیره شد";
            Assert.IsTrue(Actualresult.Contains(Expectedresult));
            Debug.WriteLine("نتیجه ساخت قرارداد " + "\n" + Actualresult);
            Console.WriteLine("نتیجه ساخت قرارداد " + "\n" + Actualresult);
            Thread.Sleep(3000);

        }
    }
}
