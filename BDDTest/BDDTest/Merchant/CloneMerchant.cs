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
    public class CloneMerchant : BaseTest
    {
        public CloneMerchantPage CloneMerchantPage { get; set; }
        public String ExpectedResult = "با موفقیت ذخیره شد";

        public CloneMerchant() : base()
        {

            CloneMerchantPage = new CloneMerchantPage(Driver);

        }

        [Given(@"The user clones the specfied merchant (.*)")]
        public void GivenTheUserClonesTheSpecfiedMerchant(string p0)
        {
            //ورود به فرم مدیریت پذیرنده 

            //جستجو
        
            Wait.Until(ExpectedConditions.ElementExists(CloneMerchantPage.AmaliyatGridBy));
            //button#id//button.class//button[class='']//button.class[attribute='']
            CloneMerchantPage.AmaliyatGrid.Click();
            CloneMerchantPage.CpMerchant.Click();
            Thread.Sleep(2000);
            //var ExcelObj = new Test_Data();
            //var excel = ExcelObj.MainTest();
            //cardacqid.SendKeys(excel[0].Cardacqid);
          
        }

        [When(@"The user customize merchant address information as following:")]
        public void WhenTheUserCustomizeMerchantAddressInformationAsFollowing(Table table)
        {


            //var FirstRowDelete = Driver.FindElements(By.XPath("//a[text()= 'حذف']"));
            ////*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[2]/td[9]/span/div/button"
            CloneMerchantPage.FirstRowDelete[0].Click();
            Thread.Sleep(1000);


            //اضافه کردن ادرس جدید
            var MerchantInfo = table.CreateSet<MerchantInfo>();
            // IWebElement txtAddressTypeCode = Driver.FindElement(By.Id("txtAddressTypeCode"));
            CloneMerchantPage.TxtAddressTypeCode.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().TxtAddressTypeCode);
            Thread.Sleep(2000);


            //شهر
            CloneMerchantPage.TxtCityPK.Click();
            CloneMerchantPage.TxtCityPK.SendKeys(MerchantInfo.First().TxtCityPK);
            CloneMerchantPage.TxtCityPK.SendKeys(Keys.Down);
            CloneMerchantPage.TxtCityPK.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            //شماره تماس
            //IWebElement TNo = Driver.FindElement(By.Id("TelephoneNo"));
            CloneMerchantPage.TNo.Click();
            CloneMerchantPage.TNo.Clear();

            Thread.Sleep(1000);
            CloneMerchantPage.TNo.SendKeys(MerchantInfo.First().TelephoneNo);
            Thread.Sleep(1000);


            //آدرس کامل فارسی
            CloneMerchantPage.AddressFull.Click();
            CloneMerchantPage.AddressFull.SendKeys(MerchantInfo.First().AddressFull);
            //آدرس کامل انگلیسی
            CloneMerchantPage.AddressFullEn.Click();
            CloneMerchantPage.AddressFullEn.SendKeys(MerchantInfo.First().AddressFullEn);
            //کدپستی
            //IWebElement PostalCode = Driver.FindElement(By.Id("PostalCode"));
            CloneMerchantPage.PostalCode.Click();
            CloneMerchantPage.PostalCode.SendKeys(MerchantInfo.First().PostalCode);

            //اضافه کردن 
            CloneMerchantPage.Add[0].Click();
            Thread.Sleep(2000);
            //IWebElement next2 = Driver.FindElement(By.XPath("//input[@value='بعدی']"));
            CloneMerchantPage.Next.Click();
            CloneMerchantPage.Next.Click();
            Thread.Sleep(1000);

        }


        [Then(@"The merchant should be cloned successfully")]
        public void ThenTheMerchantShouldBeClonedSuccessfully()
        {
           
            var ActualResult = CloneMerchantPage.SuccessNotif.Text;
            Assert.IsTrue(ActualResult.Contains(ExpectedResult));
            Debug.WriteLine("نتیجه کلون پذیرنده " + "\n" + ActualResult);
            Console.WriteLine("نتیجه کلون پذیرنده " + "\n" + ActualResult);
            TearDown();

        }
    }
}
