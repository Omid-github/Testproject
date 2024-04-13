using BDDTest.Set;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDTest.Pages
{
    public class AddRemoveAccountPage
    {
        private IWebDriver Driver { get; set; }

        public AddRemoveAccountPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public static string RelativeUrl => "/Merchants/MerchantTerminal/Edit";
        public static string RelativeUrl2 => "/Merchants/MerchantTerminal/MerchantTerminalIbanChangeRequests";

        public static string Url => BaseTest.BaseUrl + RelativeUrl;
        public static string IBANChangeRequestUrl => BaseTest.BaseUrl + RelativeUrl2;
        
        public IWebElement OpenMenu => Driver.FindElement(By.CssSelector(".fa.blue.fa-plus"));

        //Search For Merchant 
        public static By CardAcqIdBy => By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'CardAcqId')]");
        public IWebElement CardAcqId => Driver.FindElement(CardAcqIdBy);


        public static By TerminalIdBy => By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'TerminalId')]");
        public IWebElement TerminalId => Driver.FindElement(TerminalIdBy);


        public static By SearchBy => By.XPath("//button[text() =' جستجو']");
        public IWebElement Search => Driver.FindElement(SearchBy);

        public static By AmaliyatGridBy => By.XPath("//a[text()='عملیات ']");
        public IWebElement AmaliyatGrid => Driver.FindElement(AmaliyatGridBy);

        public static By AccountChangeBy => By.XPath("//a[contains(text(), 'درخواست تغییر حساب')]");
        public IWebElement AccountChange => Driver.FindElement(AccountChangeBy);

        public static By  MerchantIBANBy => By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'MerchantContractIbanPk')]");
        public IWebElement MerchantIBAN => Driver.FindElement(MerchantIBANBy);



        public static By TermPaymentModeBy => By.Id("select2-NewTermPaymentMode-container");
        public IWebElement TermPaymentMode => Driver.FindElement(TermPaymentModeBy);

        public IWebElement Description => Driver.FindElement(By.Id("Description"));

        public static By MultiPlexingValuBehaviourIdBy => By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'MultiplexingValueBehaviorId')]");
        public IWebElement MultiPlexingValuBehaviourId => Driver.FindElement(MultiPlexingValuBehaviourIdBy);

        public static By MerchantTerminalIBAN_StatusCodeBy => By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'MerchantTerminalIBAN_StatusCode')]");
        public IWebElement MerchantTerminalIBAN_StatusCode => Driver.FindElement(MerchantTerminalIBAN_StatusCodeBy);

        public static By AmountBy => By.Id("Amount");
        public IWebElement Amount => Driver.FindElement(AmountBy);

        public static By PercentageBy => By.Id("Percentage");
        public IWebElement Percentage => Driver.FindElement(PercentageBy);

        public static By AddBy => By.XPath("//button[text()= ' اضافه کردن']");
        public IWebElement Add => Driver.FindElement(AddBy);

        public IWebElement Send => Driver.FindElement(By.XPath("//*[text()=' ارسال']"));

        public IWebElement ApproveAll => Driver.FindElement(By.CssSelector("input[type = 'button'][value = 'تایید همه موارد']"));


        public static By MerchantBy => By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'MerchantPk')]");
        public IWebElement Merchant => Driver.FindElement(MerchantBy);

        public IWebElement SuccessNotif => Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[3]/div[3]/div/div[1]/div"));
        public IWebElement ShaparakConfirmMsg => Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[3]/div[1]/div/ul/li"));



    }
}



