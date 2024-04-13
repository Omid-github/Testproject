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
    public class TakhsisPage
    {
        private IWebDriver Driver { get; set; }

        public TakhsisPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public static string RelativeUrl => "/Merchants/MerchantTerminal/Index";
        public static string Url => BaseTest.BaseUrl + RelativeUrl;


        //Takhsis
        public IWebElement OpenMenu => Driver.FindElement(By.CssSelector(".fa.blue.fa-plus"));

        //Search For Merchant 
        public static By CardAcqIdBy => By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'CardAcqId')]");
        public IWebElement CardAcqId => Driver.FindElement(CardAcqIdBy);


        public static By ContractNoBy => By.Id("ContractNo");
        public IWebElement ContractNo => Driver.FindElement(ContractNoBy);

        public static By SearchBy => By.XPath("//button[text() =' جستجو']");
        public IWebElement Search => Driver.FindElement(SearchBy);

        public static By AmaliyatGridBy => By.XPath("//a[text()='عملیات ']");
        public IWebElement AmaliyatGrid => Driver.FindElement(AmaliyatGridBy);

        public static By TakhsisBy => By.XPath("//a[contains(text(), 'تخصیص به پذیرنده')]");
        public IWebElement Takhsis => Driver.FindElement(TakhsisBy);

        public static By MerchantIBANBy => By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'MerchantContractIbanPk')]");
        public IWebElement MerchantIBAN => Driver.FindElement(MerchantIBANBy);

        public static By TermModelBy => By.XPath("//*[contains(@aria-labelledby, 'TerminalModel_TermModelCode' )]");
        public IWebElement TermModel => Driver.FindElement(TermModelBy);


        public static By PostalCodeBy => By.Id("InstallLoc_PostalCode");
        public IWebElement PostalCode => Driver.FindElement(PostalCodeBy);

        public static By ParentShaparakMccCodeBy => By.XPath("//*[starts-with(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'ParentShaparakMccCode')]");
        public IWebElement ParentShaparakMccCode => Driver.FindElement(ParentShaparakMccCodeBy);

        public static By ShaparakMCCBy => By.XPath("//*[starts-with(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'ShaparakMCC_PK')]");
        public IWebElement ShaparakMCC => Driver.FindElement(ShaparakMCCBy);

        public static By ExistanceStatusCodeBy => By.XPath("//span[contains(@aria-labelledby, 'ExistanceStatusCode')]");
        public IWebElement ExistanceStatusCode => Driver.FindElement(ExistanceStatusCodeBy);

        public static By MultiPlexingValuBehaviourIdBy => By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'MultiplexingValueBehaviorId')]");
        public IWebElement MultiPlexingValuBehaviourId => Driver.FindElement(MultiPlexingValuBehaviourIdBy);

        public static By TerminalIBANTabBy => By.XPath("//a[contains(text(), 'شماره شباهای پایانه')]");
        public IWebElement TerminalIBANTab => Driver.FindElement(TerminalIBANTabBy);



        public static By TerminalIBANBy => By.XPath("//*[starts-with(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'MerchantContractIBAN_PK')]");
        public IWebElement TerminalIBAN => Driver.FindElement(TerminalIBANBy);

        public static By AddBy => By.XPath("//button[text()= ' اضافه کردن']");
        public IWebElement[] Add => Driver.FindElements(AddBy).ToArray();
        public IWebElement FinalSumbit => Driver.FindElement(By.XPath("//*[text()=' ارسال']"));


        public static By MerchantBy => By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'MerchantPK')]");
        public IWebElement Merchant => Driver.FindElement(MerchantBy);





















    }
}



