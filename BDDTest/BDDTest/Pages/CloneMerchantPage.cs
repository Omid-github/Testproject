using BDDTest.Set;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDTest.Pages
{
    public class CloneMerchantPage
    {
        private IWebDriver Driver { get; set; }

        public CloneMerchantPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public static string RelativeUrl => "/Merchants/merchant/Index";
       // public static string Url => BaseTest.BaseUrl + RelativeUrl;

       // public static By Amaliat => By.XPath("//a[@data-original-title='اضافه كردن پذیرنده']");


        public static By CardAcqIdBy => By.Id("txtCardAcqId");
        public IWebElement CardAcqId => Driver.FindElement(CardAcqIdBy);


        public static By SearchBy => By.XPath("//input[@type='button' and @value='جستجو']");
        public IWebElement Search => Driver.FindElement(SearchBy);


        public static By AmaliyatGridBy => By.XPath("//a[text()='عملیات ']");
        public IWebElement AmaliyatGrid => Driver.FindElement(AmaliyatGridBy);


        public static By CpMerchantBy => By.LinkText("کپی پذیرنده");
        public IWebElement CpMerchant => Driver.FindElement(CpMerchantBy);

        public IWebElement[] FirstRowDelete => Driver.FindElements(By.XPath("//*[text()='حذف ']")).ToArray();


        ///مدیریت آدرس 
        //نوع آدرس 
        public static By TxtAddressTypeCodeBy => (By.XPath("//*[contains(@aria-labelledby, 'AddressTypeCode')]"));
        public IWebElement TxtAddressTypeCode => Driver.FindElement(TxtAddressTypeCodeBy);

        //شهر
        public static By TxtCityPKBy => (By.XPath("//*[contains(@data-select2-id ,'select2-data')]//*[contains(@aria-labelledby, 'CityPK')]"));
        public IWebElement TxtCityPK => Driver.FindElement(TxtCityPKBy);

        //شماره تماس
        public static By TNoBy => (By.Id("TelephoneNo"));
        public IWebElement TNo => Driver.FindElement(TNoBy);


        //آدرس کامل فارسی
        public static By AddressFullBy => (By.Id("AddressFull"));
        public IWebElement AddressFull => Driver.FindElement(AddressFullBy);

        //آدرس کامل انگلیسی
        public static By AddressFullEnBy => (By.Id("AddressFullEn"));
        public IWebElement AddressFullEn => Driver.FindElement(AddressFullEnBy);

        //کدپستی
        public static By PostalCodeBy => (By.Id("PostalCode"));
        public IWebElement PostalCode => Driver.FindElement(PostalCodeBy);

        //اضافه کردن
        public static By AddBy => By.XPath("//button[text()=' اضافه کردن']");
        public IWebElement[] Add => Driver.FindElements(AddBy).ToArray();

        //بعدی
        public static By NextBy => (By.XPath("//button[text() =  'مرحله بعدی']"));
        public IWebElement Next => Driver.FindElement(NextBy);


        public IWebElement SuccessNotif => Driver.FindElement(By.XPath("//*[text()= 'با موفقیت ذخیره شد']"));




        public static By DivCodeBy => By.Id("txtDivisionCode");
        public IWebElement DivCode => Driver.FindElement(DivCodeBy);


        public static By PersonTypeBy => By.Id("txtpersonTypeLookupModelId");
        public IWebElement PersonType => Driver.FindElement(PersonTypeBy);


        public static By NationalCodeBy => By.Id("NationalCode");
        public IWebElement NationalCode => Driver.FindElement(NationalCodeBy);


        public static By FirstNameBy => By.Id("FirstName");
        public IWebElement FirstName => Driver.FindElement(NationalCodeBy);


        public static By FirstNameEnBy => By.Id("FirstNameEn");
        public IWebElement FirstNameEn => Driver.FindElement(FirstNameEnBy);

        public static By ParentShaparakMccCodeBy => By.Id("txtParentShaparakMccCode");
        public IWebElement ParentShaparakMccCode => Driver.FindElement(ParentShaparakMccCodeBy);

        public static By ShaparakMCCBy => By.Id("txtshaparakMCCId");
        public IWebElement ShaparakMCC => Driver.FindElement(ShaparakMCCBy);


        public static By JobTitleBy => By.Id("JobTitle");
        public IWebElement JobTitle => Driver.FindElement(JobTitleBy);


        public static By EMailAddressBy => By.Id("EMailAddress");
        public IWebElement EMailAddress => Driver.FindElement(EMailAddressBy);


        public static By WebSiteBy => By.Id("WebSite");
        public IWebElement WebSite => Driver.FindElement(WebSiteBy);


        public static By MerchantMobileNoBy => By.Id("MerchantMobile");
        public IWebElement MerchantMobileNo => Driver.FindElement(MerchantMobileNoBy);

        public static By OtherOrgAgencyPKBy => By.Id("OtherOrgAgencyPK");
        public IWebElement OtherOrgAgencyPK => Driver.FindElement(OtherOrgAgencyPKBy);


        public static By BirthDateBy => By.Id("BirthDate_dateTime");
        public IWebElement BirthDate => Driver.FindElement(BirthDateBy);

        public static By LicenseDateBy => By.Id("LicenseDate_dateTime");
        public IWebElement LicenseDate => Driver.FindElement(LicenseDateBy);


        ///اطلاعات شخص حقیقی 
        //نام خانوادگی
        public static By LastNameBy => (By.Id("LastName"));
        public IWebElement LastName => Driver.FindElement(LastNameBy);

        //نام خانوادگی انگلیسی 
        public static By LastNameEnBy => (By.Id("LastNameEn"));
        public IWebElement LastNameEn => Driver.FindElement(LastNameBy);
        //نام پدر  
        public static By FatherNameBy => (By.Id("FatherName"));
        public IWebElement FatherName => Driver.FindElement(LastNameBy);
        // شماره شناسنامه   
        public static By IdentityNoBy => (By.Id("IdentityNo"));
        public IWebElement IdentityNo => Driver.FindElement(IdentityNoBy);

        // سریال  شناسنامه   
        public static By IdNoSerialBy => (By.Id("IdNoSerial"));
        public IWebElement IdNoSerial => Driver.FindElement(IdNoSerialBy);


        //  حرف سریال
        public static By LetterIDBy => (By.Id("txtIdNoSeriesLetterID"));
        public IWebElement LetterID => Driver.FindElement(LetterIDBy);

        //  عدد سریال   

        public static By LIdNoSeriesNumberBy => (By.Id("IdNoSeriesNumber"));
        public IWebElement IdNoSeriesNumber => Driver.FindElement(LIdNoSeriesNumberBy);

        // وضعیت تاهل    

        public static By MaritalStatusBy => (By.Id("txtMaritalStatusCode"));
        public IWebElement MaritalStatus => Driver.FindElement(MaritalStatusBy);


        //جنسیت    
        public static By SexCodeBy => (By.Id("txtSexCode"));
        public IWebElement SexCode => Driver.FindElement(SexCodeBy);


        //تاریخ انقضای گذرنامه
        public static By PassExpiryDateBy => (By.Id("PassportExpireDate_dateTime"));
        public IWebElement PassExpiryDate => Driver.FindElement(PassExpiryDateBy);

        //شماره گذرنامه
        public static By PassportNoBy => (By.Id("PassportNo"));
        public IWebElement PassportNo => Driver.FindElement(PassportNoBy);



        //منطقه شهری 
        public static By CitySectionBy => (By.Id("CitySection"));
        public IWebElement CitySection => Driver.FindElement(CitySectionBy);

      

        //بعدی
        public static By Next1By => (By.XPath("//input[@value='بعدی']"));
        public IWebElement Next1 => Driver.FindElement(Next1By);

        ///مدیریت امضا
        //ردیف
        public static By RowSigBy => (By.Id("Row_No"));
        public IWebElement RowSig => Driver.FindElement(Next1By);

        //ملیت
        public static By SigNationalityBy => (By.Id("txtpartialCountryLookupModelId"));
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

        //اضافه کردن
        public static By AddButtonBy => (By.XPath("//button[@type='button' and  text()=' اضافه کردن']"));
        public IWebElement[] AddButton => Driver.FindElements(AddButtonBy).ToArray();

        //بعدی
        public static By Next2By => (By.XPath("//input[@value='بعدی']"));
        public IWebElement Next2 => Driver.FindElement(Next2By);


        public static By SendBy => (By.CssSelector("input[value='ارسال']"));
        public IWebElement Send => Driver.FindElement(SendBy);

        public IWebElement ReturnAnswer => Driver.FindElement(By.XPath("//*[@id='content']/div[3]/div[1]/div/ul/li"));

    }
}



