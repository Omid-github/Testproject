using TechTalk.SpecFlow;
using BDDTest.Set;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow.Assist;
using System.Linq;
using System;
using NUnit.Framework;
using BDDTest.Pages;

namespace BDDTest.Features
{
    [Binding]
    public class CreateRelatedMerchant : BaseTest
    {
        //[Given(@"The user logins successfull")]
        //public void GivenTheUserLoginsSuccessfull()
        //{
        //    Signin("controlpanel", "portal@1234");
        //}
        public CreateMerchantPage CreateMerchantPage { get; set; }
        public CreateRelatedMerchant() : base()
        {
            CreateMerchantPage = new CreateMerchantPage(Driver);
        }
        [When(@"The User fills out merchant information as following :")]
        public void WhenTheUserFillsOutMerchantInformationAsFollowing(Table table)
        {

            ///اطلاعات پذیرنده
            //نوع پذیرنده
            
            var MerchantInfo = table.CreateSet<MerchantInfo>();

            // Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[3]/form/div[2]/div/div[2]/div[1]/div[2]/div[1]/div[1]/span/span[1]/span")).Click();

            CreateMerchantPage.TermType.Click();
            // CreateMerchantPage.TermType.SendKeys(MerchantInfo.First().TermType);
            Driver.SwitchTo().ActiveElement().SendKeys(MerchantInfo.First().TermType);
            Thread.Sleep(2000);
            CreateMerchantPage.TermType.SendKeys(Keys.Down);
            CreateMerchantPage.TermType.SendKeys(Keys.Enter);

            Thread.Sleep(2000);

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
            Thread.Sleep(3000);
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
            Thread.Sleep(2000);
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
            ///...شریک تجاری ...///
            CreateMerchantPage.RelatedMerchant.Click();
            Thread.Sleep(1000);
           
            //بعدی
            // IWebElement next = Driver.FindElement(By.XPath("//input[@value='بعدی']"));
            CreateMerchantPage.Next.Click();
            Thread.Sleep(1000);

        
        }
        [When(@"The user fill SubMerchant information as following:")]
        public void WhenTheUserFillSubMerchantInformationAsFollowing(Table table)
        {
            var SubMerchantInfo = table.CreateSet<MerchantInfo>();
            /////مجموعه پذیرندگان - شرکا
            //پذیرنده
            CreateMerchantPage.SubMerchantId.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(SubMerchantInfo.First().SubMerchantPk);
            Thread.Sleep(3000);
            CreateMerchantPage.SubMerchantId.SendKeys(Keys.Down);
            CreateMerchantPage.SubMerchantId.SendKeys(Keys.Enter);


            CreateMerchantPage.CommercialCode.Click();
            CreateMerchantPage.CommercialCode.SendKeys(SubMerchantInfo.First().CommercialCode);

            CreateMerchantPage.Relation.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(SubMerchantInfo.First().RelationTypeLookupId);
            Thread.Sleep(1000);
            CreateMerchantPage.Relation.SendKeys(Keys.Down);
            CreateMerchantPage.Relation.SendKeys(Keys.Enter);
            

            CreateMerchantPage.AddButton[2].Click();
            Thread.Sleep(2000);

        }

        [Then(@"The related merchant should be created successfully")]
        public void ThenTheRelatedMerchantShouldBeCreatedSuccessfully()
        {
            //IWebElement returnAnswer = Driver.FindElement(By.XPath("//*[@id='content']/div[3]/div[1]/div/ul/li"));
            var Actualresult =  CreateMerchantPage.ReturnAnswer.Text;
            var Expectedresult = "با موفقیت ذخیره شد";
            Assert.IsTrue(Actualresult.Contains(Expectedresult));
            System.Diagnostics.Debug.WriteLine("نتیجه ساخت پذیرنده شریک تجاری" + "\n" + Actualresult);
            Console.WriteLine("نتیجه ساخت پذیرنده شریک تجاری " + "\n" + Actualresult); 

        }
    }
}
