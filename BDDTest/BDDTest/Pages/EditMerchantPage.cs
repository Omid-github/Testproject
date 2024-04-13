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
    public class EditMerchantPage
    {
        private IWebDriver Driver { get; set; }

        public EditMerchantPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public static string RelativeUrl => "/Merchants/merchant/Index";
        public static string Url => BaseTest.BaseUrl + RelativeUrl;


        //Edit Merchant
        public IWebElement OpenMenu => Driver.FindElement(By.CssSelector(".fa.blue.fa-plus"));
        public IWebElement Search => Driver.FindElement(By.XPath("//button[@type='button' and @class='btn btn-labeled btn-default ']"));

        public IWebElement CardAcqId => Driver.FindElement(By.XPath("//*[starts-with(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'CardAcqId')]"));


        public By VirayehGridBy => (By.XPath("//a[text()='ویرایش']"));
        public IWebElement VirayehGrid => Driver.FindElement(VirayehGridBy);

        public static By PersonTypeBy => By.Id("select2-personTypeLookupModelId-container");
        public IWebElement PersonType => Driver.FindElement(PersonTypeBy);


        public static By NationalCodeBy => By.Id("NationalCode");
        public IWebElement NationalCode => Driver.FindElement(NationalCodeBy);


        public static By FirstNameBy => By.Id("FirstName");
        public IWebElement FirstName => Driver.FindElement(FirstNameBy);


        public static By FirstNameEnBy => By.Id("FirstNameEn");
        public IWebElement FirstNameEn => Driver.FindElement(FirstNameEnBy);

        public static By ParentShaparakMccCodeBy => By.XPath("//*[starts-with(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'ParentShaparakMccCode')]");
        public IWebElement ParentShaparakMccCode => Driver.FindElement(ParentShaparakMccCodeBy);

        public static By ShaparakMCCBy => By.XPath("//*[starts-with(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'shaparakMCCId')]");
        public IWebElement ShaparakMCC => Driver.FindElement(ShaparakMCCBy);


        public static By JobTitleBy => By.Id("JobTitle");
        public IWebElement JobTitle => Driver.FindElement(JobTitleBy);


        public static By EMailAddressBy => By.Id("EMailAddress");
        public IWebElement EMailAddress => Driver.FindElement(EMailAddressBy);


        public static By WebSiteBy => By.Id("WebSite");
        public IWebElement WebSite => Driver.FindElement(WebSiteBy);


        public static By MerchantMobileNoBy => By.Id("MerchantMobileNo");
        public IWebElement MerchantMobileNo => Driver.FindElement(MerchantMobileNoBy);

        public static By OtherOrgAgencyPKBy => By.XPath("//*[starts-with(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'OtherOrgAgency')]");
        public IWebElement OtherOrgAgencyPK => Driver.FindElement(OtherOrgAgencyPKBy);


        public static By BirthDateBy => By.Id("BirthDate_dateTime");
        public IWebElement BirthDate => Driver.FindElement(BirthDateBy);

        public static By LicenseDateBy => By.Id("LicenseDate_dateTime");
        public IWebElement LicenseDate => Driver.FindElement(LicenseDateBy);

        public static By RelatedMerchantBy => By.Id("IsRelatedMerchant");
        public IWebElement RelatedMerchant => Driver.FindElement(RelatedMerchantBy);

        ///اطلاعات شخص حقیقی 
        //نام خانوادگی
        public static By LastNameBy => (By.Id("LastName"));
        public IWebElement LastName => Driver.FindElement(LastNameBy);

        //نام خانوادگی انگلیسی 
        public static By LastNameEnBy => (By.Id("LastNameEn"));
        public IWebElement LastNameEn => Driver.FindElement(LastNameEnBy);
        //نام پدر  
        public static By FatherNameBy => (By.Id("FatherName"));
        public IWebElement FatherName => Driver.FindElement(FatherNameBy);
        // شماره شناسنامه   
        public static By IdentityNoBy => (By.Id("IdentityNo"));
        public IWebElement IdentityNo => Driver.FindElement(IdentityNoBy);

        // سریال  شناسنامه   
        public static By IdNoSerialBy => (By.Id("IdNoSerial"));
        public IWebElement IdNoSerial => Driver.FindElement(IdNoSerialBy);


        //  حرف سریال
        public static By LetterIDBy => (By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'IdNoSeriesLetterID')]"));
        public IWebElement LetterID => Driver.FindElement(LetterIDBy);

        //  عدد سریال   
        public static By LIdNoSeriesNumberBy => (By.Id("IdNoSeriesNumber"));
        public IWebElement IdNoSeriesNumber => Driver.FindElement(LIdNoSeriesNumberBy);

        // وضعیت تاهل    
        public static By MaritalStatusBy => By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'MaritalStatusCode')]");
        public IWebElement MaritalStatus => Driver.FindElement(MaritalStatusBy);


        //جنسیت    
        public static By SexCodeBy => By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'SexCode')]");
        public IWebElement SexCode => Driver.FindElement(SexCodeBy);


        //تاریخ انقضای گذرنامه
        public static By PassExpiryDateBy => (By.Id("PassportExpireDate_dateTime"));
        public IWebElement PassExpiryDate => Driver.FindElement(PassExpiryDateBy);

        //شماره گذرنامه
        public static By PassportNoBy => (By.Id("PassportNo"));
        public IWebElement PassportNo => Driver.FindElement(PassportNoBy);

        //بعدی
        public static By NextBy => (By.XPath("//button[text() =  'مرحله بعدی']"));
        public IWebElement Next => Driver.FindElement(NextBy);



        ///مدیریت آدرس 

        //دکمه عملیات  

        public static By AmaliatButtonBy => (By.XPath("//a[text()='عملیات ']"));
        public IWebElement[] AmaliatButton => Driver.FindElements(AmaliatButtonBy).ToArray();


        //ویرایش اولین آدرس 

        public static By EditAddressGridButtonBy => (By.XPath("//a[text()=' ويرايش']"));
        public IWebElement[] EditAddressGridButton => Driver.FindElements(EditAddressGridButtonBy).ToArray();

        //تایید حذف آدرس 
        public static By DeleteReconfirmBy => (By.XPath("//button[text() = 'تایید']"));
        public IWebElement DeleteReconfirm => Driver.FindElement(DeleteReconfirmBy);


        //نوع آدرس 
        public static By TxtAddressTypeCodeBy => (By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'AddressTypeCode')]"));
        public IWebElement TxtAddressTypeCode => Driver.FindElement(TxtAddressTypeCodeBy);

        //شهر
        public static By TxtCityPKBy => (By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'CityPK')]"));
        public IWebElement TxtCityPK => Driver.FindElement(TxtCityPKBy);

        //شماره تماس
        public static By TNoBy => (By.Id("TelephoneNo"));
        public IWebElement TNo => Driver.FindElement(TNoBy);

        //منطقه شهری 
        public static By CitySectionBy => (By.Id("CitySection"));
        public IWebElement CitySection => Driver.FindElement(CitySectionBy);

        //آدرس کامل فارسی
        public static By AddressFullBy => (By.Id("AddressFull"));
        public IWebElement AddressFull => Driver.FindElement(AddressFullBy);

        //آدرس کامل انگلیسی
        public static By AddressFullEnBy => (By.Id("AddressFullEn"));
        public IWebElement AddressFullEn => Driver.FindElement(AddressFullEnBy);

        //کدپستی
        public static By PostalCodeBy => (By.Id("PostalCode"));
        public IWebElement PostalCode => Driver.FindElement(PostalCodeBy);

        //ذخیره
        public static By SaveBy => By.XPath("//*[text()=' ذخیره']");
        public IWebElement[] Save => Driver.FindElements(SaveBy).ToArray();

       
        ///مدیریت امضا
        //ردیف
        public static By RowSigBy => (By.Id("Row_No"));
        public IWebElement RowSig => Driver.FindElement(RowSigBy);

        //ملیت
        public static By SigNationalityBy => (By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'partialCountryLookupModelId')]"));
        public IWebElement SigNationality => Driver.FindElement(SigNationalityBy);

        //نام
        public static By SigFirstNameBy => (By.Id("SignatoryFirstName"));
        public IWebElement SigFirstName => Driver.FindElement(SigFirstNameBy);

        //نام خانوادگی
        public static By SigLastNameBy => (By.Id("SignatoryLastName"));
        public IWebElement SigLastName => Driver.FindElement(SigLastNameBy);

        //کد ملی
        public static By SigNationalCodeBy => (By.Id("SignatoryNationalCode"));
        public IWebElement SigNationalCode => Driver.FindElement(SigNationalCodeBy);

        //شماره گذرنامه 
        public static By SigPassNoBy => (By.Id("SignatoryPassportNo"));
        public IWebElement SigPassNo => Driver.FindElement(SigPassNoBy);

        //تاریخ تولد
        public static By SigBirthDateBy => (By.Id("SignatoryBirthDate_dateTime"));
        public IWebElement SigBirthDate => Driver.FindElement(SigBirthDateBy);
        //حذف اولین آدرس 

        public static By DeleteAdressButtonBy => (By.XPath("//a[text()=' حذف']"));
        public IWebElement[] DeleteAdressButton => Driver.FindElements(DeleteAdressButtonBy).ToArray();


        //شرکا

        //پذیرنده شریک
        public static By SubMerchantIdBy => By.XPath("//*[starts-with(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'SubMerchantPK')]");
        public IWebElement SubMerchantId => Driver.FindElement(SubMerchantIdBy);


        //کد اقتصادی
        public static By CommercialCodeBy => (By.Id("CommercialCode"));
        public IWebElement CommercialCode => Driver.FindElement(CommercialCodeBy);

        //ارتباط
        public static By RelationBy => (By.XPath("//*[starts-with(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'RelationTypeLookupId')]"));
        public IWebElement Relation => Driver.FindElement(RelationBy);

        //اضافه کردن
        // public static By AddButtonBy => (By.XPath("//input[@type='button' and @value='اضافه کردن']"));
        //public IWebElement[] AddButton => Driver.FindElements(AddButtonBy).ToArray();

        //بعدی
        public static By Next2By => (By.XPath("//input[@value='بعدی']"));
        public IWebElement Next2 => Driver.FindElement(Next2By);


        public static By SendBy => (By.XPath("//button[text() = 'ارسال']"));
        public IWebElement Send => Driver.FindElement(SendBy);

    }
}



