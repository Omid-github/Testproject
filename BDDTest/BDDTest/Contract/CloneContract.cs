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
    public class CloneContract : BaseTest
    {
        [When(@"The user clones a contract for the specified Merchant (.*)")]
        public void WhenTheUserClonesAContractForTheSpecifiedMerchant(string p0)
        {
            var amaliyatButton = Driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
            //button#id//button.class//button[class='']//button.class[attribute='']
            //ردیف اول
            amaliyatButton[0].Click();
            //amaliyatButton[1].Click();
            //amaliyatButton[2].Click();

            ///---using explicit wait--///
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            //IWebElement amaliyatGrid = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("button.ui-button[role='button']")));
            //button#id//button.class//button[class='']//button.class[attribute='']
            ///---using explicit wait--///
            //کپی قرارداد در گرید عملیات
            IWebElement copy = Driver.FindElement(By.LinkText("کپی قرارداد"));
            copy.Click();
            Thread.Sleep(5000);
            IWebElement CardAcqId = Driver.FindElement(By.Id("txtPartialMerchantPK"));
            CardAcqId.SendKeys(p0);
            CardAcqId.SendKeys(Keys.Down);
            CardAcqId.SendKeys(Keys.Enter);
            Thread.Sleep(2000);


            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
            // Edit.Click();
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            Thread.Sleep(5000);



        }
        
        [Then(@"The contract should be cloned successfully")]
        public void ThenTheContractShouldBeClonedSuccessfully()
        {
            var ExpectedResult = "عملیات به روز رسانی با موفقیت انجام شد";
            IWebElement successNotif = Driver.FindElement(By.XPath("//*[text()= 'عملیات به روز رسانی با موفقیت انجام شد']"));
            var ActualResult = successNotif.Text;
            Assert.IsTrue(ActualResult.Contains(ExpectedResult));
            System.Diagnostics.Debug.WriteLine("نتیجه کلون قرارداد " + "\n"+ ActualResult);
            Console.WriteLine("نتیجه کلون قرارداد " + "\n" +ActualResult);

        }
    }
}
