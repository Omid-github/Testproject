using System;
using TechTalk.SpecFlow;
using BDDTest.Set;
using OpenQA.Selenium;
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
    public class AddIBAN : BaseTest
    {

        public AddRemoveAccountPage AddRemoveAccountPage { get; set; }

        public AddIBAN() : base()

        {
            AddRemoveAccountPage = new AddRemoveAccountPage(Driver);

        }

        [Given(@"Navigates to the MerchantTerminal form")]
        public void GivenNavigatesToTheMerchantTerminalForm()
        {

            //ورود به فرم مدیریت پایانه های پذیرندگان 
            Driver.Navigate().GoToUrl(AddRemoveAccountPage.Url);
            Thread.Sleep(3000);

        }

        [Given(@"The user searches for a contract based on MerchantNo (.*) and TerminalID (.*)")]
        public void GivenTheUserSearchesForAContractBasedOnMerchantNoAndTerminalID(string p0, string p1)
        {
            AddRemoveAccountPage.OpenMenu.Click();
            Thread.Sleep(1000);

            AddRemoveAccountPage.CardAcqId.Click();
            //var ExcelObj = new Test_Data();
            //var excel = ExcelObj.MainTest();
            //cardacqid.SendKeys(excel[0].Cardacqid);
            Driver.SwitchTo().ActiveElement().SendKeys((p0));

            Thread.Sleep(2000);


            AddRemoveAccountPage.TerminalId.Click();
            //var ExcelObj = new Test_Data();
            //var excel = ExcelObj.MainTest();
            //cardacqid.SendKeys(excel[0].Cardacqid);
            Driver.SwitchTo().ActiveElement().SendKeys((p1));

            Thread.Sleep(2000);

            //جستجو
            AddRemoveAccountPage.Search.Click();
            Thread.Sleep(2000);


        }

        [When(@"The user adds account information as following :")]
        public void WhenTheUserAddsAccountInformationAsFollowing(Table table)
        {


            AddRemoveAccountPage.AmaliyatGrid.Click();
            //درخواست تغییر حساب
            Thread.Sleep(1000);
            Wait.Until(ExpectedConditions.ElementIsVisible(AddRemoveAccountPage.AccountChangeBy));
            var href = AddRemoveAccountPage.AccountChange.GetAttribute("href");
            Driver.Navigate().GoToUrl(href);
            System.Threading.Thread.Sleep(3000);

            //نحوه پرداخت 
            var MerchantTerminal = table.CreateSet<MerchantTerminal>();

            AddRemoveAccountPage.TermPaymentMode.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantTerminal.First().TermPaymentMode);
            Thread.Sleep(1000);


            //انتخاب شبا از قرارداد

            AddRemoveAccountPage.MerchantIBAN.Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantTerminal.First().MerchantIBAN);

            //تسهیم
            AddRemoveAccountPage.MultiPlexingValuBehaviourId.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantTerminal.First().MultiplexingValueBehaviorId);
            Thread.Sleep(1000);
            ////درصد
            //AddRemoveAccountPage.Percentage.Click();
            //Driver.SwitchTo().ActiveElement().SendKeys(MerchantTerminal.First().Percentage);
            //Driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);


            ////مبلغ
            //AddRemoveAccountPage.Amount.Click();
            //Driver.SwitchTo().ActiveElement().SendKeys(MerchantTerminal.First().Amount);
            //Driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);

            //وضعیت
            AddRemoveAccountPage.MerchantTerminalIBAN_StatusCode.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantTerminal.First().MerchantTerminalIBAN_StatusCode);
            Thread.Sleep(2000);


            AddRemoveAccountPage.Add.Click();

            //توضیحات 
            AddRemoveAccountPage.Description.Click();
            AddRemoveAccountPage.Description.SendKeys(MerchantTerminal.First().Description);

            //ارسال 
            AddRemoveAccountPage.Send.Click();
            Thread.Sleep(2000);

        }


        [When(@"The user performs shaparak confirmation for the Merchant (.*)")]
        public void WhenTheUserPerformsShaparakConfirmationForTheMerchant(string p0)
        {
            var ActualResult = AddRemoveAccountPage.SuccessNotif.Text;
            var ExpectedResult = "عملیات ثبت با موفقیت انجام شد";

            if (ActualResult.Equals(ExpectedResult))
            {

                //تایید شاپرکی 
                Driver.Navigate().GoToUrl(AddRemoveAccountPage.IBANChangeRequestUrl);
                //Driver.Url = "http://172.24.34.40/Merchants/MerchantTerminal/MerchantTerminalIbanChangeRequests";

                AddRemoveAccountPage.Merchant.Click();
                Driver.SwitchTo().ActiveElement().SendKeys(p0);
                Thread.Sleep(2000);
                //جستجوی
                AddRemoveAccountPage.Search.Click();
                Thread.Sleep(2000);

                ////ردیف اول 
                //IWebElement GRID = Driver.FindElement(By.XPath("//table/tbody/tr[1]//button[@role='button']"));
                //GRID.Click();
                ////ردیف دوم
                ////IWebElement GRID2 = driver.FindElement(By.Id("/html//table/tbody/tr[2]//button[@role='button']"));
                ////GRID2.Click();

                //IWebElement subGrid = Driver.FindElement(By.LinkText("تایید درخواست"));
                //subGrid.Click();
                //تایید همه موارد
                AddRemoveAccountPage.ApproveAll.Click();
                Thread.Sleep(5000);


            }
            else
            {
                Console.WriteLine("خطا هنگام تغییر حساب");
                Debug.WriteLine("خطا هنگام تغییر حساب");
                TearDown();
            }

        }
        [Then(@"IBAN number shoud be linked to the terminal successfully")]
        public void ThenIBANNumberShoudBeLinkedToTheTerminalSuccessfully()
        {


           // IWebElement ShaparakConfirmMsg = Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[3]/div[3]/div/div[1]//text()"));
            if (AddRemoveAccountPage.ShaparakConfirmMsg.Displayed)
            {
                string ShaparakConfirmText = AddRemoveAccountPage.ShaparakConfirmMsg.Text;
                var ExpectedResult = "عملیات ثبت با موفقیت انجام شد";

                if (ShaparakConfirmText.Equals(ExpectedResult))
                {
                    Debug.WriteLine("شبای مورد نظر با موفقیت پشت پایانه قرار گرفت");
                    Console.WriteLine("شبای مورد نظر با موفقیت پشت پایانه قرار گرفت");
                  
                }
            }
            else
            {
                Debug.WriteLine(" تایید شاپرکی ناموفق بود و تغییر حساب انجام نشد");
                Console.WriteLine("تایید شاپرکی ناموفق بود و تغییر حساب انجام نشد");
                TearDown();

            }
            TearDown();

        }

    }

}
// var ShaparakConfirmText = ShaparakConfirmMsg.Text;
//var ExpectedResult = "عملیات ثبت با موفقیت انجام شد";
// 


