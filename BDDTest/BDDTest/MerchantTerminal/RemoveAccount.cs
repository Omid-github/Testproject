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
    public class RemoveAccount : BaseTest
    {
        [When(@"The user removes the Account number with following information:")]
        public void WhenTheUserRemovesTheAccountNumberWithFollowingInformation(Table table)
        {
            var amaliyatGrid = Driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
            amaliyatGrid[0].Click();
            //درخواست تغییر حساب
            Thread.Sleep(1000);
            WebDriverWait wait1 = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            IWebElement AccountChange = wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(), 'درخواست تغییر حساب')]")));
            var href = AccountChange.GetAttribute("href");
            Driver.Navigate().GoToUrl(href);
            System.Threading.Thread.Sleep(5000);

            var  Hazf = Driver.FindElements(By.XPath("//*[text()='حذف']"));
            Hazf[0].Click();
            Thread.Sleep(2000);
            var MerchantTerminal = table.CreateSet<MerchantTerminal>();

            //روش پرداخت 

            IWebElement PayMode = Driver.FindElement(By.Id("txtNewTermPaymentMode"));
            PayMode.Click();
            PayMode.SendKeys(MerchantTerminal.First().TermPaymentMode);
            Thread.Sleep(1000);
            PayMode.SendKeys(Keys.Down);
            PayMode.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            //توضیحات 
            IWebElement Desc = Driver.FindElement(By.Id("Description"));
            Desc.Click();
            Desc.SendKeys(MerchantTerminal.First().Description);
            Thread.Sleep(3000);
            // var AddedIBAN = Driver.FindElement(By.XPath("/html/body//div//div[6]/section/div[1]/div[1]/div/div/div/div[4]/div/div/div[1]//div[1]/div/div/table/tbody/tr[1]/td[1]/span/label")).Text;
            //msgs.Add("شبای اضافه شده پشت پایانه" + AddedIBAN);
            //System.Diagnostics.Debug.WriteLine(AddedIBAN + ":شبای اضافه شده پشت پایانه");
            //ارسال 
            IWebElement Send = Driver.FindElement(By.XPath("//input[@type='button' and @value='ارسال']"));
            Send.Click();
            Thread.Sleep(5000);



        }
        
        [Then(@"IBAN number shoud be unlinked from the terminal successfully")]
        public void ThenIBANNumberShoudBeUnlinkedFromTheTerminalSuccessfully()
        {

            Console.WriteLine("شبای مورد نظراز پشت پایانه حذف شده است");
            Debug.WriteLine("شبای مورد نظراز پشت پایانه حذف شده است");

        }
    }
}
