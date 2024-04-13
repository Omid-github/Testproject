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
    public class EditMerchant : BaseTest
    {
        //[Given(@"The user login successfully")]
        //public void GivenTheUserLoginSuccessfully()
        //{
        //    Signin("controlpanel", "portal@1234");
        //}
        public EditMerchantPage EditMerchantPage { get; set; }
        public EditMerchant(): base()
            {

            EditMerchantPage = new EditMerchantPage(Driver);
            }

        [Given(@"The user navigated to the Merchant Page")]
        public void GivenTheUserNavigatedToTheMerchantPage()
        {

            Driver.Navigate().GoToUrl(CreateMerchantPage.Url);
            Thread.Sleep(2000);

        }
        [Given(@"The user searches for a merchant based on CardAcqId (.*)")]
        public void GivenTheUserSearchesForAMerchantBasedOnCardAcqId(string p0)
        {
            //ورود به فرم مدیریت  پذیرنده 

            EditMerchantPage.OpenMenu.Click();
            Thread.Sleep(1000);

            System.Threading.Thread.Sleep(3000);
            EditMerchantPage.CardAcqId.Click();
            //var ExcelObj = new Test_Data();
            //var excel = ExcelObj.MainTest();
            //cardacqid.SendKeys(excel[0].Cardacqid);

            Driver.SwitchTo().ActiveElement().SendKeys((p0));

            Thread.Sleep(2000);
            EditMerchantPage.CardAcqId.SendKeys(Keys.Down);
            EditMerchantPage.CardAcqId.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            //جستجو
            EditMerchantPage.Search.Click();
            Thread.Sleep(2000);
           

        }
        [Given(@"The user edits the specfied merchant")]
        public void GivenTheUserEditsTheSpecfiedMerchant()
        {
            Wait.Until(ExpectedConditions.ElementExists(EditMerchantPage.AmaliatButtonBy));
            EditMerchantPage.AmaliatButton[0].Click();
            //ویرایش در گرید عملیات
            EditMerchantPage.VirayehGrid.Click();

            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
            // Edit.Click();
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(4);
            Thread.Sleep(5000);

        }
        [When(@"The user edit merchant information as following :")]
        public void WhenTheUserEditMerchantInformationAsFollowing(Table table)
        {
           
            ///اطلاعات پذیرنده
            var MerchantInfo = table.CreateSet<MerchantInfo>();

            ////نوع پذیرنده
            //Thread.Sleep(4000);

            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            //IWebElement TermType = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("txtTermTypeShaparakabbr")));
            //TermType.Click();
            //TermType.SendKeys((string)MerchantInfo.First().TermType);
            //Thread.Sleep(1000);
            //TermType.SendKeys(Keys.Down);
            //TermType.SendKeys(Keys.Enter);

            ////نوع سوییچ
            //IWebElement switchtype = Driver.FindElement(By.Id("txtSwitchTypeCode"));
            //switchtype.Click();
            //switchtype.Clear();

            //switchtype.SendKeys(MerchantInfo.First().SwitchType);
            //Thread.Sleep(1000);
            //switchtype.SendKeys(Keys.Down);
            //switchtype.SendKeys(Keys.Enter);

            //// دسته
            //Thread.Sleep(2000);
            //IWebElement divcode = Driver.FindElement(By.Id("txtDivisionCode"));
            //divcode.Click();
            //divcode.Clear();
            //divcode.SendKeys(MerchantInfo.First().DivisionCode);
            //divcode.SendKeys(Keys.Down);
            //divcode.SendKeys(Keys.Enter);

            //////نوع شخصیت
            //EditMerchantPage.PersonType.Click();
            //Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().PersonType);
            //Thread.Sleep(2000);
            //EditMerchantPage.PersonType.SendKeys(Keys.Enter);
            //کدملی
            EditMerchantPage.NationalCode.Click();
            EditMerchantPage.NationalCode.Clear();
            EditMerchantPage.NationalCode.SendKeys(MerchantInfo.First().NationalCode);
            ////کد رهگیری مالیاتی 
            //IWebElement TaxPayerCode = Driver.FindElement(By.Id("TaxPayerCode"));
            //TaxPayerCode.Click();
            //TaxPayerCode.SendKeys("0061435171");

            //0480205604
            //نام
            EditMerchantPage.FirstName.Click();
            EditMerchantPage.FirstName.Clear();
            EditMerchantPage.FirstName.SendKeys(MerchantInfo.First().FirstName);
            Thread.Sleep(2000);
            // نام انگلیسی
            EditMerchantPage.FirstNameEn.Click();
            EditMerchantPage.FirstNameEn.Clear();
            EditMerchantPage.FirstNameEn.SendKeys(MerchantInfo.First().FirstNameEn);
            Thread.Sleep(2000);

            EditMerchantPage.ParentShaparakMccCode.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().ParentShaparakMccCode);
            Thread.Sleep(2000);
            EditMerchantPage.ParentShaparakMccCode.SendKeys(Keys.Down);
            EditMerchantPage.ParentShaparakMccCode.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            //صنف
            //IWebElement ShaparakMCC = Driver.FindElement(By.Id("txtshaparakMCCId"));
            //ShaparakMCC.Click();
            EditMerchantPage.ShaparakMCC.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().ShaparakMcc);
            Thread.Sleep(2000);
            EditMerchantPage.ShaparakMCC.SendKeys(Keys.Down);
            EditMerchantPage.ShaparakMCC.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            ////عنوان شغلی
            //IWebElement JobTitle = Driver.FindElement(By.Id("JobTitle"));
            //JobTitle.Click();
            //JobTitle.SendKeys(MerchantInfo.First().JobTitle);
            //آدرس ایمیل 
            Thread.Sleep(1000);
            EditMerchantPage.EMailAddress.Clear();
            EditMerchantPage.EMailAddress.Click();
            Thread.Sleep(1000);


            EditMerchantPage.EMailAddress.SendKeys(MerchantInfo.First().EmailAddress);

            //آدرس وب سایت 
            EditMerchantPage.WebSite.Click();
            EditMerchantPage.WebSite.Clear();
            EditMerchantPage.WebSite.SendKeys(MerchantInfo.First().WebSite);
            //موبایل 
            EditMerchantPage.MerchantMobileNo.Click();
            EditMerchantPage.MerchantMobileNo.Clear();
            EditMerchantPage.MerchantMobileNo.SendKeys(MerchantInfo.First().MerchantMobileNo);

            ////عاملیت
            //IWebElement OtherOrgAgencyPK = Driver.FindElement(By.Id("txtOtherOrgAgencyPK"));
            //OtherOrgAgencyPK.Click();
            //OtherOrgAgencyPK.SendKeys(MerchantInfo.First().OtherOrgAgency);
            //OtherOrgAgencyPK.SendKeys(Keys.Down);
            //OtherOrgAgencyPK.SendKeys(Keys.Enter);

            //تاریخ تولد/تاسیس
            EditMerchantPage.BirthDate.Click();
            EditMerchantPage.BirthDate.Clear();
            EditMerchantPage.BirthDate.SendKeys(MerchantInfo.First().BirthDate);

            ////تاریخ ثبت شرکت 
            //IWebElement LicenseDate = Driver.FindElement(By.Id("LicenseDate_dateTime"));
            //LicenseDate.Click();
            //LicenseDate.SendKeys(MerchantInfo.First().LicenseDate);

            ///اطلاعات شخص حقیقی 
            //نام خانوادگی
            EditMerchantPage.LastName.Click();
            EditMerchantPage.LastName.SendKeys(MerchantInfo.First().LastName);
            //نام خانوادگی انگلیسی 
            EditMerchantPage.LastNameEn.Click();
            EditMerchantPage.LastNameEn.Clear();
            EditMerchantPage.LastNameEn.SendKeys(MerchantInfo.First().LastNameEn);
            //نام پدر  
            EditMerchantPage.FatherName.Click();
            EditMerchantPage.FatherName.Clear();
            EditMerchantPage.FatherName.SendKeys(MerchantInfo.First().FatherName);
            // شماره شناسنامه   
            EditMerchantPage.IdentityNo.Click();
            EditMerchantPage.IdentityNo.Clear();
            EditMerchantPage.IdentityNo.SendKeys("0082282838");
            // سریال  شناسنامه   
            EditMerchantPage.IdNoSerial.Click();
            EditMerchantPage.IdNoSerial.Clear();

            EditMerchantPage.IdNoSerial.SendKeys(MerchantInfo.First().IdNoSerial);
            //  حرف سریال    
            EditMerchantPage.LetterID.Click();
            EditMerchantPage.LetterID.SendKeys(MerchantInfo.First().LetterID);
            EditMerchantPage.LetterID.SendKeys(Keys.Down);
            EditMerchantPage.LetterID.SendKeys(Keys.Enter);
            //  عدد سریال    
            EditMerchantPage.IdNoSeriesNumber.Click();
            EditMerchantPage.IdNoSeriesNumber.Clear();
            EditMerchantPage.IdNoSeriesNumber.SendKeys(MerchantInfo.First().IdNoSeriesNumber);
            // وضعیت تاهل    
            EditMerchantPage.MaritalStatus.Click();
            EditMerchantPage.MaritalStatus.SendKeys(MerchantInfo.First().MaritalStatus);
            Thread.Sleep(2000);
            EditMerchantPage.MaritalStatus.SendKeys(Keys.Down);
            EditMerchantPage.MaritalStatus.SendKeys(Keys.Enter);

            //جنسیت    
            EditMerchantPage.SexCode.Click();
            EditMerchantPage.SexCode.SendKeys(MerchantInfo.First().SexCode);
            Thread.Sleep(2000);

            EditMerchantPage.SexCode.SendKeys(Keys.Down);
            EditMerchantPage.SexCode.SendKeys(Keys.Enter);
            Thread.Sleep(2000);


            ////تاریخ انقضای گذرنامه
            //IWebElement PassExpiryDate = Driver.FindElement(By.Id("PassportExpireDate_dateTime"));
            //PassExpiryDate.Click();
            //PassExpiryDate.SendKeys(MerchantInfo.First().PassExpiryDate);

            ////شماره گذرنامه
            //IWebElement PassportNo = Driver.FindElement(By.Id("PassportNo"));
            //PassportNo.Click();
            //PassportNo.SendKeys(MerchantInfo.First().PassportNo);

            //بعدی
            EditMerchantPage.Next.Click();
            Thread.Sleep(1000);

        }

        [When(@"The user edit merchant address information as following:")]
        public void WhenTheUserEditMerchantAddressInformationAsFollowing(Table table)
        {
            ///مدیریت آدرس 


            ///مدیریت آدرس 
            ///ویرایش ادرس ردیف اول 
            ////*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[2]/td[9]/span/div/button"
            EditMerchantPage.AmaliatButton[0].Click();
            Thread.Sleep(1000);
            ///ویرایش ادرس ردیف دوم
            //*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[2]/td[9]/span/div/button"
            //ویرایش در گرید عملیات
            EditMerchantPage.EditAddressGridButton[0].Click();

            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            Thread.Sleep(3000);
            var MerchantInfo = table.CreateSet<MerchantInfo>();
            EditMerchantPage.TxtAddressTypeCode.Click();
            Thread.Sleep(2000);
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().TxtAddressTypeCode);
            Thread.Sleep(1000);
            EditMerchantPage.TxtAddressTypeCode.SendKeys(Keys.Down);
            EditMerchantPage.TxtAddressTypeCode.SendKeys(Keys.Enter);
            //شهر
            //IWebElement txtCityPK = Driver.FindElement(By.Id("txtCityPK"));
            EditMerchantPage.TxtCityPK.Click();
            EditMerchantPage.TxtCityPK.SendKeys(MerchantInfo.First().TxtCityPK);
            EditMerchantPage.TxtCityPK.SendKeys(Keys.Down);
            EditMerchantPage.TxtCityPK.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            //شماره تماس
            // IWebElement TNo = Driver.FindElement(By.Id("TelephoneNo"));
            EditMerchantPage.TNo.Click();
            EditMerchantPage.TNo.Clear();
            Thread.Sleep(1000);
            EditMerchantPage.TNo.SendKeys(MerchantInfo.First().TelephoneNo);
            Thread.Sleep(1000);

            //منطقه شهری 
            // IWebElement CitySection = Driver.FindElement(By.Id("CitySection"));
            EditMerchantPage.CitySection.Click();
            EditMerchantPage.CitySection.Clear();

            EditMerchantPage.CitySection.SendKeys(MerchantInfo.First().CitySection);
            //آدرس کامل فارسی
            //IWebElement AddressFull = Driver.FindElement(By.Id("AddressFull"));
            EditMerchantPage.AddressFull.Click();
            EditMerchantPage.AddressFull.Clear();

            EditMerchantPage.AddressFull.SendKeys(MerchantInfo.First().AddressFull);
            //آدرس کامل انگلیسی
            //IWebElement AddressFullEn = Driver.FindElement(By.Id("AddressFullEn"));
            EditMerchantPage.AddressFullEn.Click();
            EditMerchantPage.AddressFullEn.Clear();
            EditMerchantPage.AddressFullEn.SendKeys(MerchantInfo.First().AddressFullEn);
            //کدپستی
            //IWebElement PostalCode = Driver.FindElement(By.Id("PostalCode"));
            EditMerchantPage.PostalCode.Click();
            EditMerchantPage.PostalCode.Clear();
            EditMerchantPage.PostalCode.SendKeys(MerchantInfo.First().PostalCode);
            //ذخیره
            //IWebElement Add = Driver.FindElement(By.XPath("//input[@value='اضافه کردن']"));
            EditMerchantPage.Save[0].Click();
            Thread.Sleep(1000);
            //بعدی
            //IWebElement next1 = Driver.FindElement(By.XPath("//input[@value='بعدی']"));
            EditMerchantPage.Next.Click();
            Thread.Sleep(1000);
        }

        [When(@"The user edit signatory information as following:")]
        public void WhenTheUserEditSignatoryInformationAsFollowing(Table table)
        {
            var MerchantInfo = table.CreateSet<MerchantInfo>();

            ///مدیریت امضا
            //ردیف
            //IWebElement RowSig = Driver.FindElement(By.Id("Row_No"));
            //RowSig.Click();
            //RowSig.Clear();
            //RowSig.SendKeys(MerchantInfo.First().RowSig);
            // عملیات آدرس ردیف اول 
         
            Thread.Sleep(1000);
            //ملی
            //ردیف
            // IWebElement RowSig = Driver.FindElement(By.Id("Row_No"));
            EditMerchantPage.RowSig.Click();
            EditMerchantPage.RowSig.Clear();
            EditMerchantPage.RowSig.SendKeys(MerchantInfo.First().RowSig);
            //ملیت
            //IWebElement SigNationality = Driver.FindElement(By.Id("txtpartialCountryLookupModelId"));
            EditMerchantPage.SigNationality.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().SigNationality);
            Thread.Sleep(2000);
            EditMerchantPage.SigNationality.SendKeys(Keys.Down);
            EditMerchantPage.SigNationality.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            //نام
            // IWebElement SigFirstName = Driver.FindElement(By.Id("SignatoryFirstName"));
            EditMerchantPage.SigFirstName.Click();
            EditMerchantPage.SigFirstName.SendKeys(MerchantInfo.First().SigFirstname);
            //نام خانوادگی
            // IWebElement SigLastName = Driver.FindElement(By.Id("SignatoryLastName"));
            EditMerchantPage.SigLastName.Click();
            EditMerchantPage.SigLastName.SendKeys(MerchantInfo.First().SigLastname);
            //کد ملی
            // IWebElement SigNationalCode = Driver.FindElement(By.Id("SignatoryNationalCode"));
            EditMerchantPage.SigNationalCode.Click();
            EditMerchantPage.SigNationalCode.SendKeys(MerchantInfo.First().SigNationalcode);
            //شماره گذرنامه 
            // IWebElement SigPassNo = Driver.FindElement(By.Id("SignatoryPassportNo"));
            EditMerchantPage.SigPassNo.Click();
            EditMerchantPage.SigPassNo.SendKeys(MerchantInfo.First().SigPassNo);
            //تاریخ تولد
            // IWebElement SigBirthDate = Driver.FindElement(By.Id("SignatoryBirthDate_dateTime"));
            EditMerchantPage.SigBirthDate.Click();
            EditMerchantPage.SigBirthDate.SendKeys(MerchantInfo.First().SigBirthdate);
            EditMerchantPage.SigBirthDate.Click();
            EditMerchantPage.SigBirthDate.SendKeys(Keys.Enter);
            //اضافه کردن
            EditMerchantPage.Save[1].Click();

        }
        ///مجموعه پذیرندگان - شرکا
        ////پذیرنده
        //IWebElement SubMerchant = Driver.FindElement(By.Id("txtSubMerchantPK"));
        //    SubMerchant.Click();
        //    SubMerchant.SendKeys("000000130880743");
        //    Thread.Sleep(2000);
        //    SubMerchant.SendKeys(Keys.Down);
        //    SubMerchant.SendKeys(Keys.Enter);
        //    Thread.Sleep(1000);

        //[When(@"The user submit")]
        //public void WhenTheusersubmit()
        //{

        //    IWebElement Send = Driver.FindElement(By.XPath("//input[@type='button' and  @value='ارسال']"));
        //    Send.Click();
        //    Thread.Sleep(12000);

        //}

        [Then(@"The Merchant should be modified successfully")]
        public void ThenTheMerchantShouldBeModifiedSuccessfully()
        {

            IWebElement returnAnswer = Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/div[1]//ul/li"));
            var Actualresult = returnAnswer.Text;
            var Expectedresult = "عملیات به روز رسانی با موفقیت انجام شد";
            Assert.AreEqual(Actualresult, Expectedresult);
            System.Diagnostics.Debug.WriteLine(" نتیجه ویرایش پذیرنده : " + Actualresult );
            Console.WriteLine(" نتیجه ویرایش پذیرنده : " + Actualresult );
            TearDown();
           
        }

    }
}