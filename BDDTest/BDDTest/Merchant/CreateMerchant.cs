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

namespace BDDTest.Merchant
{
    [Binding]
    public class CreateMerchant : BaseTest
    {
        public CreateMerchantPage CreateMerchantPage { get; set; }
        public CreateMerchant() : base()
        {
            CreateMerchantPage = new CreateMerchantPage(Driver);
        }

        //[Scope(Tag="Create Merchant")]
        [Given(@"The user logins successfully")]
        public void GivenTheUserLoginsSuccessfully()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            Signin("controlpanel", "portal@1234");
        }

        [Given(@"The user is Navigated to the CreateMerchant form")]
        public void GivenTheUserIsNavigatedToTheCreateMerchantForm()
        
            {

            Driver.Navigate().GoToUrl(CreateMerchantPage.Url);
            System.Threading.Thread.Sleep(3000);
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(4));
            Wait.Until(ExpectedConditions.ElementExists(CreateMerchantPage.AddMerchantBy));
            // IWebElement addmerchant = Driver.FindElement(By.XPath("//a[@data-original-title='اضافه كردن پذیرنده']"));
            CreateMerchantPage.AddMerchant.Click();

        }

        [When(@"The user fills out merchant information as following :")]
        public void WhenTheUserFillsOutMerchantInformationAsFollowing(Table table)
        {
            ///اطلاعات پذیرنده
            //نوع پذیرنده
            Thread.Sleep(4000);
            var MerchantInfo = table.CreateSet<MerchantInfo>();

            // Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[3]/form/div[2]/div/div[2]/div[1]/div[2]/div[1]/div[1]/span/span[1]/span")).Click();

            CreateMerchantPage.TermType.Click();
           // CreateMerchantPage.TermType.SendKeys(MerchantInfo.First().TermType);
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().TermType);
            Thread.Sleep(2000);
            CreateMerchantPage.TermType.SendKeys(Keys.Down);
            CreateMerchantPage.TermType.SendKeys(Keys.Enter);

            Thread.Sleep(2000);
            //CreateMerchantPage.TermType.SendKeys(Keys.Down);
            //CreateMerchantPage.TermType.SendKeys(Keys.Enter);

            ////نوع سوییچ
            ////IWebElement switchtype = Driver.FindElement(By.Id("txtSwitchTypeCode"));
            //CreateMerchantPage.Switchtype.Click();
            //Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().SwitchType);
            //Thread.Sleep(1000);
            //CreateMerchantPage.Switchtype.SendKeys(Keys.Down);
            //CreateMerchantPage.Switchtype.SendKeys(Keys.Enter);

            //// دسته
            //CreateMerchantPage.DivCode.Click();
            //Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().DivisionCode);
            //CreateMerchantPage.DivCode.SendKeys(Keys.Down);
            //CreateMerchantPage.DivCode.SendKeys(Keys.Enter);

            ////نوع شخصیت
            //// IWebElement PersonType = Driver.FindElement(By.Id("txtpersonTypeLookupModelId"));
            //CreateMerchantPage.PersonType.Click();
            //Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().PersonType);
            //CreateMerchantPage.PersonType.SendKeys(Keys.Down);
            //CreateMerchantPage.PersonType.SendKeys(Keys.Enter);

            //کدملی
            //IWebElement NationalCode = Driver.FindElement(By.Id("NationalCode"));
            CreateMerchantPage.NationalCode.SendKeys(MerchantInfo.First().NationalCode);
            ////کد رهگیری مالیاتی 
            //IWebElement TaxPayerCode = Driver.FindElement(By.Id("TaxPayerCode"));
            //TaxPayerCode.Click();
            //TaxPayerCode.SendKeys("0061435171");

            //0480205604
            //نام
            // IWebElement FirstName = Driver.FindElement(By.Id("FirstName"));
           // CreateMerchantPage.FirstName.Click();
            CreateMerchantPage.FirstName.SendKeys(MerchantInfo.First().FirstName);
            // نام انگلیسی
            // IWebElement FirstNameEn = Driver.FindElement(By.Id("FirstNameEn"));
            CreateMerchantPage.FirstNameEn.Click();
            CreateMerchantPage.FirstNameEn.SendKeys(MerchantInfo.First().FirstNameEn);
            Thread.Sleep(2000);

            //گروه صنفی
            // IWebElement ParentShaparakMccCode = Driver.FindElement(By.Id("txtParentShaparakMccCode"));
            //ParentShaparakMccCode.Click();
            //*[@id="bodyOfGirdToSetTopScrollbar"]/table/tbody/tr[6]/td/span/label
            CreateMerchantPage.ParentShaparakMccCode.Click();
             Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().ParentShaparakMccCode);
            Thread.Sleep(2000);
            CreateMerchantPage.ParentShaparakMccCode.SendKeys(Keys.Down);
            CreateMerchantPage.ParentShaparakMccCode.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            //صنف
            //IWebElement ShaparakMCC = Driver.FindElement(By.Id("txtshaparakMCCId"));
            //ShaparakMCC.Click();
            CreateMerchantPage.ShaparakMCC.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().ShaparakMcc);
            Thread.Sleep(2000);
            CreateMerchantPage.ShaparakMCC.SendKeys(Keys.Down);
            CreateMerchantPage.ShaparakMCC.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            //عنوان شغلی
            // IWebElement JobTitle = Driver.FindElement(By.Id("JobTitle"));
            CreateMerchantPage.JobTitle.Click();
            CreateMerchantPage.JobTitle.SendKeys(MerchantInfo.First().JobTitle);
            //آدرس ایمیل 
            // IWebElement EMailAddress = Driver.FindElement(By.Id("EMailAddress"));
            CreateMerchantPage.EMailAddress.Click();
            CreateMerchantPage.EMailAddress.SendKeys(MerchantInfo.First().EmailAddress);

            //آدرس وب سایت 
            // IWebElement WebSite = Driver.FindElement(By.Id("WebSite"));
            CreateMerchantPage.WebSite.Click();
            CreateMerchantPage.WebSite.SendKeys(MerchantInfo.First().WebSite);
            //موبایل 
            // IWebElement MerchantMobileNo = Driver.FindElement(By.Id("MerchantMobileNo"));
            CreateMerchantPage.MerchantMobileNo.Click();
            CreateMerchantPage.MerchantMobileNo.SendKeys(MerchantInfo.First().MerchantMobileNo);

            //عاملیت
            // IWebElement OtherOrgAgencyPK = Driver.FindElement(By.Id("txtOtherOrgAgencyPK"));
            CreateMerchantPage.OtherOrgAgencyPK.Click();
            CreateMerchantPage.OtherOrgAgencyPK.SendKeys(MerchantInfo.First().OtherOrgAgency);
            CreateMerchantPage.OtherOrgAgencyPK.SendKeys(Keys.Down);
            CreateMerchantPage.OtherOrgAgencyPK.SendKeys(Keys.Enter);

            //تاریخ تولد/تاسیس
            //IWebElement birthdate = Driver.FindElement(By.Id("BirthDate_dateTime"));
            CreateMerchantPage.BirthDate.Click();
            CreateMerchantPage.BirthDate.SendKeys(MerchantInfo.First().BirthDate);

            //تاریخ ثبت شرکت 
            // IWebElement LicenseDate = Driver.FindElement(By.Id("LicenseDate_dateTime"));
            CreateMerchantPage.LicenseDate.Click();
            CreateMerchantPage.LicenseDate.SendKeys(MerchantInfo.First().LicenseDate);

            ///اطلاعات شخص حقیقی 
            //نام خانوادگی
            //IWebElement LastName = Driver.FindElement(By.Id("LastName"));
            CreateMerchantPage.LastName.Click();
            CreateMerchantPage.LastName.SendKeys(MerchantInfo.First().LastName);
            Thread.Sleep(1000);
            //نام خانوادگی انگلیسی 
            //IWebElement LastNameEn = Driver.FindElement(By.Id("LastNameEn"));
            CreateMerchantPage.LastNameEn.Click();
            CreateMerchantPage.LastNameEn.SendKeys(MerchantInfo.First().LastNameEn);
            Thread.Sleep(2000);
            //نام پدر  

            //IWebElement FatherName = Driver.FindElement(By.Id("FatherName"));
            CreateMerchantPage.FatherName.Click();
            Thread.Sleep(2000);
            CreateMerchantPage.FatherName.SendKeys(MerchantInfo.First().FatherName);
            // شماره شناسنامه   
            // IWebElement IdentityNo = Driver.FindElement(By.Id("IdentityNo"));
            CreateMerchantPage.IdentityNo.Click();
            CreateMerchantPage.IdentityNo.SendKeys("0082282838");
            // سریال  شناسنامه   
            // IWebElement IdNoSerial = Driver.FindElement(By.Id("IdNoSerial"));
            CreateMerchantPage.IdNoSerial.Click();
            CreateMerchantPage.IdNoSerial.SendKeys(MerchantInfo.First().IdNoSerial);
            //  حرف سریال    
            //IWebElement LetterID = Driver.FindElement(By.Id("txtIdNoSeriesLetterID"));
            CreateMerchantPage.LetterID.Click();
            CreateMerchantPage.LetterID.SendKeys(MerchantInfo.First().LetterID);
            CreateMerchantPage.LetterID.SendKeys(Keys.Down);
            CreateMerchantPage.LetterID.SendKeys(Keys.Enter);
            //  عدد سریال    
            //IWebElement IdNoSeriesNumber = Driver.FindElement(By.Id("IdNoSeriesNumber"));
            CreateMerchantPage.IdNoSeriesNumber.Click();
            CreateMerchantPage.IdNoSeriesNumber.SendKeys(MerchantInfo.First().IdNoSeriesNumber);
            // وضعیت تاهل    
            //IWebElement MaritalStatus = Driver.FindElement(By.Id("txtMaritalStatusCode"));
            CreateMerchantPage.MaritalStatus.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().MaritalStatus);
            Thread.Sleep(1000);
            CreateMerchantPage.MaritalStatus.SendKeys(Keys.Down);
            CreateMerchantPage.MaritalStatus.SendKeys(Keys.Enter);
            Thread.Sleep(1000);


            //جنسیت    
            // IWebElement SexCode = Driver.FindElement(By.Id("txtSexCode"));
            CreateMerchantPage.SexCode.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().SexCode);
            Thread.Sleep(1000);
            CreateMerchantPage.SexCode.SendKeys(Keys.Down);
            CreateMerchantPage.SexCode.SendKeys(Keys.Enter);
            Thread.Sleep(1000);


            //تاریخ انقضای گذرنامه
            // IWebElement PassExpiryDate = Driver.FindElement(By.Id("PassportExpireDate_dateTime"));
            CreateMerchantPage.PassExpiryDate.Click();
            CreateMerchantPage.PassExpiryDate.SendKeys(MerchantInfo.First().PassExpiryDate);

            //شماره گذرنامه
            // IWebElement PassportNo = Driver.FindElement(By.Id("PassportNo"));
            CreateMerchantPage.PassportNo.Click();
            CreateMerchantPage.PassportNo.SendKeys(MerchantInfo.First().PassportNo);
            //اضافه کردن 
            CreateMerchantPage.PassportNo.Click();
            CreateMerchantPage.PassportNo.SendKeys(MerchantInfo.First().PassportNo);




            //بعدی
            // IWebElement next = Driver.FindElement(By.XPath("//input[@value='بعدی']"));
            CreateMerchantPage.Next.Click();
            Thread.Sleep(1000);

        }

        [When(@"The user fills Merchant address information as following:")]
        public void WhenTheUserFillsMerchantAddressInformationAsFollowing(Table table)
        {
            ///مدیریت آدرس 
            //نوع آدرس 
            var MerchantInfo = table.CreateSet<MerchantInfo>();
            // IWebElement txtAddressTypeCode = Driver.FindElement(By.Id("txtAddressTypeCode"));
            CreateMerchantPage.TxtAddressTypeCode.Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().TxtAddressTypeCode);
            Thread.Sleep(1000);
            CreateMerchantPage.TxtAddressTypeCode.SendKeys(Keys.Down);
            CreateMerchantPage.TxtAddressTypeCode.SendKeys(Keys.Enter);
            //شهر
            //IWebElement txtCityPK = Driver.FindElement(By.Id("txtCityPK"));
            CreateMerchantPage.TxtCityPK.Click();
            CreateMerchantPage.TxtCityPK.SendKeys(MerchantInfo.First().TxtCityPK);
            CreateMerchantPage.TxtCityPK.SendKeys(Keys.Down);
            CreateMerchantPage.TxtCityPK.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            //شماره تماس
            // IWebElement TNo = Driver.FindElement(By.Id("TelephoneNo"));
            CreateMerchantPage.TNo.Click();
            Thread.Sleep(1000);
            CreateMerchantPage.TNo.SendKeys(MerchantInfo.First().TelephoneNo);
            Thread.Sleep(1000);

            //منطقه شهری 
            // IWebElement CitySection = Driver.FindElement(By.Id("CitySection"));
            CreateMerchantPage.CitySection.Click();
            CreateMerchantPage.CitySection.Clear();

            CreateMerchantPage.CitySection.SendKeys(MerchantInfo.First().CitySection);
            //آدرس کامل فارسی
            //IWebElement AddressFull = Driver.FindElement(By.Id("AddressFull"));
            CreateMerchantPage.AddressFull.Click();
            CreateMerchantPage.AddressFull.Clear();

            CreateMerchantPage.AddressFull.SendKeys(MerchantInfo.First().AddressFull);
            //آدرس کامل انگلیسی
            //IWebElement AddressFullEn = Driver.FindElement(By.Id("AddressFullEn"));
            CreateMerchantPage.AddressFullEn.Click();
            CreateMerchantPage.AddressFullEn.Clear();
            CreateMerchantPage.AddressFullEn.SendKeys(MerchantInfo.First().AddressFullEn);
            //کدپستی
            //IWebElement PostalCode = Driver.FindElement(By.Id("PostalCode"));
            CreateMerchantPage.PostalCode.Click();
            CreateMerchantPage.PostalCode.SendKeys(MerchantInfo.First().PostalCode);
            Thread.Sleep(15000);
            //اضافه کردن
            //IWebElement Add = Driver.FindElement(By.XPath("//input[@value='اضافه کردن']"));
            CreateMerchantPage.AddButton[0].Click();
            Thread.Sleep(1000);
            //بعدی
            //IWebElement next1 = Driver.FindElement(By.XPath("//input[@value='بعدی']"));
            CreateMerchantPage.Next.Click();
            Thread.Sleep(1000);

        }

        [When(@"The user fill signatory information as following:")]
        public void WhenTheUserFillSignatoryInformationAsFollowing(Table table)
        {

            var MerchantInfo = table.CreateSet<MerchantInfo>();
            ///مدیریت امضا
            //ردیف
            // IWebElement RowSig = Driver.FindElement(By.Id("Row_No"));
            CreateMerchantPage.RowSig.Click();
            CreateMerchantPage.RowSig.Clear();
            CreateMerchantPage.RowSig.SendKeys(MerchantInfo.First().RowSig);
            //ملیت
            //IWebElement SigNationality = Driver.FindElement(By.Id("txtpartialCountryLookupModelId"));
            CreateMerchantPage.SigNationality.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().SigNationality);
            Thread.Sleep(2000);
            CreateMerchantPage.SigNationality.SendKeys(Keys.Down);
            CreateMerchantPage.SigNationality.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            //نام
            // IWebElement SigFirstName = Driver.FindElement(By.Id("SignatoryFirstName"));
            CreateMerchantPage.SigFirstName.Click();
            CreateMerchantPage.SigFirstName.SendKeys(MerchantInfo.First().SigFirstname);
            //نام خانوادگی
            // IWebElement SigLastName = Driver.FindElement(By.Id("SignatoryLastName"));
            CreateMerchantPage.SigLastName.Click();
            CreateMerchantPage.SigLastName.SendKeys(MerchantInfo.First().SigLastname);
            //کد ملی
            // IWebElement SigNationalCode = Driver.FindElement(By.Id("SignatoryNationalCode"));
            CreateMerchantPage.SigNationalCode.Click();
            CreateMerchantPage.SigNationalCode.SendKeys(MerchantInfo.First().SigNationalcode);
            //شماره گذرنامه 
            // IWebElement SigPassNo = Driver.FindElement(By.Id("SignatoryPassportNo"));
            CreateMerchantPage.SigPassNo.Click();
            CreateMerchantPage.SigPassNo.SendKeys(MerchantInfo.First().SigPassNo);
            //تاریخ تولد
            // IWebElement SigBirthDate = Driver.FindElement(By.Id("SignatoryBirthDate_dateTime"));
            CreateMerchantPage.SigBirthDate.Click();
            CreateMerchantPage.SigBirthDate.SendKeys(MerchantInfo.First().SigBirthdate);
            CreateMerchantPage.SigBirthDate.Click();
            CreateMerchantPage.SigBirthDate.SendKeys(Keys.Enter);

            //اضافه کردن
            Thread.Sleep(2000);
            //var Add1 = Driver.FindElements(By.XPath("//input[@type='button' and @value='اضافه کردن']"));
            CreateMerchantPage.AddButton[1].Click();
            Thread.Sleep(1000);
            //بعدی

            //IWebElement next2 = Driver.FindElement(By.XPath("//input[@value='بعدی']"));
            CreateMerchantPage.Next.Click();
            Thread.Sleep(1000);
        }

        [When(@"The user submits")]
        public void WhenTheUserSubmits()
        {

            //IWebElement Send = Driver.FindElement(By.CssSelector("input[value='ارسال']"));
            CreateMerchantPage.Send.Click();
            Thread.Sleep(20000);
        }
        [Then(@"The Merchant should be created successfully")]
        public void ThenTheMerchantShouldBeCreatedSuccessfully()
        {
            var Actualresult = CreateMerchantPage.ReturnAnswer.Text;
            var Expectedresult = "با موفقیت ذخیره شد";
            Assert.IsTrue(Actualresult.Contains(Expectedresult));
            System.Diagnostics.Debug.WriteLine("نتیجه ساخت پذیرنده " + "\n" + Actualresult);
            Console.WriteLine("نتیجه ساخت پذیرنده " + "\n" + Actualresult);
            TearDown();
        }
    }
}
