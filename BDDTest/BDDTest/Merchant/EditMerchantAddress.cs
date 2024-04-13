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
    public class EditMerchantAddress  : BaseTest

    {       
        [When(@"The user updates merchant address information as following:")]
        public void WhenTheUserUpdatesMerchantAddressInformationAsFollowing(Table table)
        {

            var amaliyatButton = Driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
            //button#id//button.class//button[class='']//button.class[attribute='']
            // amaliyatButton[0].Click();
            //amaliyatButton[1].Click();
            //amaliyatButton[2].Click();
            amaliyatButton[0].Click();
            //ویرایش در گرید عملیات
            IWebElement Edit = Driver.FindElement(By.XPath("//*[text()='ویرایش آدرس']"));
            Edit.Click();
            Thread.Sleep(2000);
            //var href = Edit.GetAttribute("href");
            //Driver.Navigate().GoToUrl(href);

            var amaliyatButtonAddress = Driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
            Thread.Sleep(2000);

            amaliyatButtonAddress[0].Click();
            IWebElement GridEditAddress = Driver.FindElement(By.XPath("//*[text()='ويرايش']"));
            GridEditAddress.Click();
            Thread.Sleep(2000);


            ///مدیریت آدرس 
            //نوع آدرس 
            var MerchantInfo = table.CreateSet<MerchantInfo>();
            IWebElement txtAddressTypeCode = Driver.FindElement(By.Id("txtAddressTypeCode"));
            txtAddressTypeCode.Click();
            txtAddressTypeCode.SendKeys(MerchantInfo.First().TxtAddressTypeCode);
            Thread.Sleep(2000);
            txtAddressTypeCode.SendKeys(Keys.Down);
            Thread.Sleep(2000);
            txtAddressTypeCode.SendKeys(Keys.Enter);
            //شهر
            IWebElement txtCityPK = Driver.FindElement(By.Id("txtCityPK"));
            txtCityPK.Click();
            txtCityPK.Clear();

            txtCityPK.SendKeys(MerchantInfo.First().TxtCityPK);
            txtCityPK.SendKeys(Keys.Down);
            txtCityPK.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            //شماره تماس
            IWebElement TNo = Driver.FindElement(By.Id("TelephoneNo"));
            TNo.Click();
            TNo.Clear();
            Thread.Sleep(1000);
            TNo.SendKeys(MerchantInfo.First().TelephoneNo);
            Thread.Sleep(1000);

            //منطقه شهری 
            IWebElement CitySection = Driver.FindElement(By.Id("CitySection"));
            CitySection.Click();
            CitySection.Clear();

            CitySection.SendKeys(MerchantInfo.First().CitySection);
            //آدرس کامل فارسی
            IWebElement AddressFull = Driver.FindElement(By.Id("AddressFull"));
            AddressFull.Click();
            AddressFull.Clear();
            AddressFull.SendKeys(MerchantInfo.First().AddressFull);
            //آدرس کامل انگلیسی
            IWebElement AddressFullEn = Driver.FindElement(By.Id("AddressFullEn"));
            AddressFullEn.Click();
            AddressFullEn.Clear();

            AddressFullEn.SendKeys(MerchantInfo.First().AddressFullEn);
            //کدپستی
            IWebElement PostalCode = Driver.FindElement(By.Id("PostalCode"));
            PostalCode.Click();
            PostalCode.SendKeys(MerchantInfo.First().PostalCode);
            Thread.Sleep(15000);
            //اضافه کردن
            IWebElement Add = Driver.FindElement(By.XPath("//input[@value='ذخیره']"));
            Add.Click();
            Thread.Sleep(1000);



        }
        
        [Then(@"The merchant Address should be updated successfully")]
        public void ThenTheMerchantAddressShouldBeUpdatedSuccessfully()
        {
            IWebElement returnAnswer = Driver.FindElement(By.XPath("//*[text()='عملیات به روز رسانی با موفقیت انجام شد']"));
            var Actualresult = returnAnswer.Text;
            var Expectedresult = "عملیات به روز رسانی با موفقیت انجام شد";
            Assert.AreEqual(Actualresult, Expectedresult);
            System.Diagnostics.Debug.WriteLine("نتیجه بروز رسانی آدرس پذیرنده" + "\n" + Actualresult);
            Console.WriteLine("نتیجه بروز رسانی آدرس پذیرنده" + "\n" + Actualresult);


        }
    }
}
