using System;
using TechTalk.SpecFlow;
using BDDTest.Set;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
namespace BDDTest.Features
{
    [Binding]
    public class RejectRequest : BaseTest
    {
        [When(@"The user rejects the TAKHSIS request")]
        public void WhenTheUserRejectsTheTAKHSISRequest()
        {

            //تخصیص به پذیرنده در گرید عملیات 

            var GridAmaliat = Driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
            //button#id//button.class//button[class='']//button.class[attribute='']
            GridAmaliat[0].Click();

            //تخصیص به پذیرنده در گرید عملیات 
            IWebElement Edit = Driver.FindElement(By.LinkText("رد درخواست"));
            Edit.Click();

            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
            // Edit.Click();
            Thread.Sleep(1000);
            IWebElement Reject = Driver.FindElement(By.XPath("//*[text()='تایید']"));
            Reject.Click();
            Thread.Sleep(3000);

        }

        [Then(@"The reject operation should be done successfully")]
        public void ThenTheRejectOperationShouldBeDoneSuccessfully()
        {
            var successNotif = Driver.FindElements(By.XPath("//*[text() = 'عملیات با موفقیت انجام شد']"));
            var ActualResult = successNotif[5].Text;
            var ExpectedResult = "عملیات با موفقیت انجام شد";
            Assert.IsTrue(ActualResult.Equals(ExpectedResult));
            System.Diagnostics.Debug.WriteLine(": نتیجه رد درخواست تخصیص " + "\n" + ActualResult);
            Console.WriteLine(" : نتیجه رد درخواست تخصیص" + "\n" + ActualResult);
        }

    }
    
}
