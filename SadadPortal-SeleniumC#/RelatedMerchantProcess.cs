//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support;
//using System.Threading;
//using System.Collections;
//using OpenQA.Selenium.Support.UI;
//using NUnit.Framework;
////using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
//using System.IO;
////using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium.Interactions;

//namespace Selenium
//{
//    public class Related_Merchant
//    {
//        //public IWebDriver driver;
        
//        [Test]
//        public void RelatedMerchant()
//        {
//            //ارجاع به صفحه اصلی  پرتال 
//            var login = new Login_portal();
//            var driver = login.StartBrowser();

//            //ساخت پذیرنده شریک
//            driver.Navigate().GoToUrl("http://172.24.34.40/Merchants/Merchant/CreateMerchant");

//            Thread.Sleep(5000);
//            IWebElement termtype = driver.FindElement(By.Id("txtTermTypeShaparakabbr"));
//            termtype.Click();
//            termtype.SendKeys("پایانه فروشگاهی");
//            Thread.Sleep(1000);
//            termtype.SendKeys(Keys.Down);
//            termtype.SendKeys(Keys.Enter);

//            //نوع سوییچ
//            IWebElement switchtype = driver.FindElement(By.Id("txtSwitchTypeCode"));
//            switchtype.Click();
//            switchtype.SendKeys("سوییچ دو");
//            Thread.Sleep(1000);
//            switchtype.SendKeys(Keys.Down);
//            switchtype.SendKeys(Keys.Enter);

//            // دسته
//            IWebElement divcode = driver.FindElement(By.Id("txtDivisionCode"));
//            divcode.Click();
//            divcode.SendKeys("تست سداد");
//            divcode.SendKeys(Keys.Down);
//            divcode.SendKeys(Keys.Enter);
//            //نوع شخصیت
//            IWebElement persontype = driver.FindElement(By.Id("txtpersonTypeLookupModelId"));
//            persontype.Click();
//            persontype.SendKeys("حقیقی");
//            persontype.SendKeys(Keys.Down);
//            persontype.SendKeys(Keys.Enter);
//            //کدملی
//            IWebElement nationalcode = driver.FindElement(By.Id("NationalCode"));
//            nationalcode.Click();
//            nationalcode.SendKeys("0082282838");
//            //0480205604
//            //نام
//            IWebElement FirstName = driver.FindElement(By.Id("FirstName"));
//            FirstName.Click();
//            FirstName.SendKeys("صادق ");
//            // نام انگلیسی
//            IWebElement FirstNameEn = driver.FindElement(By.Id("FirstNameEn"));
//            FirstNameEn.Click();
//            FirstNameEn.SendKeys("sadegh");
//            Thread.Sleep(2000);

//            //شریک تجاری 
//            var Related = driver.FindElements(By.XPath("//span[@class='check']"));
//            Related[1].Click();
//            Thread.Sleep(1000);

//            //گروه صنفی

//            IWebElement ParentShaparakMccCode = driver.FindElement(By.Id("txtParentShaparakMccCode"));
//            //ParentShaparakMccCode.Click();
//            //*[@id="bodyOfGirdToSetTopScrollbar"]/table/tbody/tr[6]/td/span/label
//            ParentShaparakMccCode.SendKeys("تعاونی مسکن");
//            ParentShaparakMccCode.SendKeys(Keys.Down);
//            ParentShaparakMccCode.SendKeys(Keys.Enter);

//            //صنف
//            IWebElement ShaparakMCC = driver.FindElement(By.Id("txtshaparakMCCId"));
//            //ShaparakMCC.Click();
//            ShaparakMCC.SendKeys("تعاونی مسکن");
//            ShaparakMCC.SendKeys(Keys.Down);
//            ShaparakMCC.SendKeys(Keys.Enter);
//            //عنوان شغلی
//            IWebElement JobTitle = driver.FindElement(By.Id("JobTitle"));
//            JobTitle.Click();
//            JobTitle.SendKeys("کارشناس تست اتومات");
//            //آدرس ایمیل 
//            IWebElement EMailAddress = driver.FindElement(By.Id("EMailAddress"));
//            EMailAddress.Click();
//            EMailAddress.SendKeys("test@sadadpsp.ir");

//            //آدرس وب سایت 
//            IWebElement WebSite = driver.FindElement(By.Id("WebSite"));
//            WebSite.Click();
//            WebSite.SendKeys("www.sadadportal.ir");
//            //موبایل 
//            IWebElement MerchantMobileNo = driver.FindElement(By.Id("MerchantMobileNo"));
//            MerchantMobileNo.Click();
//            MerchantMobileNo.SendKeys("9125183748");

//            //عاملیت
//            IWebElement OtherOrgAgencyPK = driver.FindElement(By.Id("txtOtherOrgAgencyPK"));
//            OtherOrgAgencyPK.Click();
//            OtherOrgAgencyPK.SendKeys("تست عاملیت");
//            OtherOrgAgencyPK.SendKeys(Keys.Down);
//            OtherOrgAgencyPK.SendKeys(Keys.Enter);

//            //تاریخ تولد/تاسیس
//            IWebElement birthdate = driver.FindElement(By.Id("BirthDate_dateTime"));
//            birthdate.Click();
//            birthdate.SendKeys("1368/05/18");

//            //تاریخ ثبت شرکت 
//            IWebElement LicenseDate = driver.FindElement(By.Id("LicenseDate_dateTime"));
//            LicenseDate.Click();
//            LicenseDate.SendKeys("1368/05/10");

//            ///اطلاعات شخص حقیقی 
//            //نام خانوادگی
//            IWebElement LastName = driver.FindElement(By.Id("LastName"));
//            LastName.Click();
//            LastName.SendKeys("یوسفی");
//            //نام خانوادگی انگلیسی 
//            IWebElement LastNameEn = driver.FindElement(By.Id("LastNameEn"));
//            LastNameEn.Click();
//            LastNameEn.SendKeys("hosseini");
//            //نام پدر  
//            IWebElement FatherName = driver.FindElement(By.Id("FatherName"));
//            FatherName.Click();
//            FatherName.SendKeys("عبدالحسین");
//            // شماره شناسنامه   
//            IWebElement IDNum = driver.FindElement(By.Id("IdentityNo"));
//            IDNum.Click();
//            IDNum.SendKeys("0082282838");
//            // سریال  شناسنامه   
//            IWebElement SerialID = driver.FindElement(By.Id("IdNoSerial"));
//            SerialID.Click();
//            SerialID.SendKeys("614351");
//            //  حرف سریال    
//            IWebElement LetterID = driver.FindElement(By.Id("txtIdNoSeriesLetterID"));
//            LetterID.Click();
//            LetterID.SendKeys("الف");
//            LetterID.SendKeys(Keys.Down);
//            LetterID.SendKeys(Keys.Enter);

//            //  عدد سریال    
//            IWebElement IdNo = driver.FindElement(By.Id("IdNoSeriesNumber"));
//            IdNo.Click();
//            IdNo.SendKeys("35");
//            // وضعیت تاهل    
//            IWebElement MaritalStatus = driver.FindElement(By.Id("txtMaritalStatusCode"));
//            MaritalStatus.Click();
//            MaritalStatus.SendKeys("مجرد");
//            MaritalStatus.SendKeys(Keys.Down);
//            MaritalStatus.SendKeys(Keys.Enter);

//            //جنسیت    
//            IWebElement SexCode = driver.FindElement(By.Id("txtSexCode"));
//            SexCode.Click();
//            SexCode.SendKeys("مرد");
//            SexCode.SendKeys(Keys.Down);
//            SexCode.SendKeys(Keys.Enter);

//            //تاریخ انقضای گذرنامه
//            IWebElement PassExpiryDate = driver.FindElement(By.Id("PassportExpireDate_dateTime"));
//            PassExpiryDate.Click();
//            PassExpiryDate.SendKeys("1401/02/01");

//            //شماره گذرنامه
//            IWebElement PassportNo = driver.FindElement(By.Id("PassportNo"));
//            PassportNo.Click();
//            PassportNo.SendKeys("25251236");

//            //بعدی
//            IWebElement next = driver.FindElement(By.XPath("//input[@value='بعدی']"));
//            next.Click();
//            Thread.Sleep(1000);

//            ///مدیریت آدرس 
//            //نوع آدرس 
//            IWebElement txtAddressTypeCode = driver.FindElement(By.Id("txtAddressTypeCode"));
//            txtAddressTypeCode.Click();
//            txtAddressTypeCode.SendKeys("آدرس محل کار");
//            Thread.Sleep(2000);
//            txtAddressTypeCode.SendKeys(Keys.Down);
//            Thread.Sleep(2000);
//            txtAddressTypeCode.SendKeys(Keys.Enter);
//            //شهر
//            IWebElement txtCityPK = driver.FindElement(By.Id("txtCityPK"));
//            txtCityPK.Click();
//            txtCityPK.SendKeys("تهران");
//            Thread.Sleep(2000);
//            txtCityPK.SendKeys(Keys.Down);
//            txtCityPK.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            //کدپستی
//            IWebElement PostalCode = driver.FindElement(By.Id("PostalCode"));
//            PostalCode.Click();
//            PostalCode.SendKeys("9456146633");
//            Thread.Sleep(4000);
//            //شماره تماس
//            IWebElement TNo = driver.FindElement(By.Id("TelephoneNo"));
//            TNo.Click();
//            TNo.SendKeys("21-22863023");
//            //منطقه شهری 
//            IWebElement Section = driver.FindElement(By.Id("CitySection"));
//            Section.Click();
//            Section.SendKeys("3");
//            //آدرس کامل فارسی
//            IWebElement AddressFull = driver.FindElement(By.Id("AddressFull"));
//            AddressFull.Click();
//            AddressFull.SendKeys("خ پاسداران ، خ سوری ، پ17");

//            //آدرس کامل انگلیسی
//            IWebElement AddressFullEn = driver.FindElement(By.Id("AddressFullEn"));
//            AddressFullEn.Click();
//            AddressFullEn.SendKeys("Pasdaran Alley, Soori St, No 17");
//            //اضافه کردن
//            IWebElement Add = driver.FindElement(By.XPath("//input[@value='اضافه کردن']"));
//            Add.Click();
//            Thread.Sleep(1000);
//            //بعدی
//            // IWebElement next1 = driver.FindElement(By.XPath("//input[@value='بعدی']"));
//            // next1.Click();
//            next.Click();
//            Thread.Sleep(1000);

//            ///مدیریت امضا
//            //ردیف
//            IWebElement RowSig = driver.FindElement(By.Id("Row_No"));
//            RowSig.Click();
//            RowSig.Clear();
//            RowSig.SendKeys("2");
//            //ملیت
//            IWebElement SigNationality = driver.FindElement(By.Id("txtpartialCountryLookupModelId"));
//            SigNationality.Click();
//            SigNationality.SendKeys("ایران");
//            Thread.Sleep(1000);
//            SigNationality.SendKeys(Keys.Down);
//            SigNationality.SendKeys(Keys.Enter);
//            //نام
//            IWebElement SigFirstName = driver.FindElement(By.Id("SignatoryFirstName"));
//            SigFirstName.Click();
//            SigFirstName.SendKeys("نوید");
//            //نام خانوادگی
//            IWebElement SigLastName = driver.FindElement(By.Id("SignatoryLastName"));
//            SigLastName.Click();
//            SigLastName.SendKeys("آرمانی پور");
//            //کد ملی
//            IWebElement SigNationalCode = driver.FindElement(By.Id("SignatoryNationalCode"));
//            SigNationalCode.Click();
//            SigNationalCode.SendKeys("0065923057");
//            //شماره گذرنامه 
//            IWebElement SigPassNo = driver.FindElement(By.Id("SignatoryPassportNo"));
//            SigPassNo.Click();
//            SigPassNo.SendKeys("25524612");
//            //تاریخ تولد
//            IWebElement SigBirthDate = driver.FindElement(By.Id("SignatoryBirthDate_dateTime"));
//            SigBirthDate.Click();
//            SigBirthDate.SendKeys("1362/10/09");
//            SigBirthDate.Click();
//            SigBirthDate.SendKeys(Keys.Enter);

//            //اضافه کردن
//            Thread.Sleep(2000);
//            var Add1 = driver.FindElements(By.XPath("//input[@type='button' and @value='اضافه کردن']"));
//            Add1[1].Click();
//            Thread.Sleep(1000);
//            //بعدی
//            next.Click();
//            Thread.Sleep(2000);

//            ///ارسال 
//            IWebElement Send = driver.FindElement(By.CssSelector("input[value='ارسال']"));
//            Send.Click();
//            Thread.Sleep(20000);

//            IWebElement returnAnswer = driver.FindElement(By.XPath("//*[@id='content']/div[3]/div[1]/div/ul/li"));
//            var Actualresult = returnAnswer.Text;
//            var Expectedresult = "با موفقیت ذخیره شد";
//            Assert.IsTrue(Actualresult.Contains(Expectedresult));
//            System.Diagnostics.Debug.WriteLine("نتیجه ساخت پذیرنده " + "\n" + Actualresult);
//            Console.WriteLine("نتیجه ساخت پذیرنده شریک تجاری  " + "\n" + Actualresult);
//            Thread.Sleep(3000);


//            //___________________________________________________________//

//            //ساخت پذیرنده عادی


//            driver.Url = "http://172.24.34.40/Merchants/Contracts/CreateMerchantContract";

//            IWebElement termtype1 = driver.FindElement(By.Id("txtTermTypeShaparakabbr"));
//            termtype1.Click();
//            termtype1.SendKeys("پایانه فروشگاهی");
//            Thread.Sleep(1000);
//            termtype1.SendKeys(Keys.Down);
//            termtype1.SendKeys(Keys.Enter);

//            //نوع سوییچ
//            IWebElement switchtype1 = driver.FindElement(By.Id("txtSwitchTypeCode"));
//            switchtype1.Click();
//            switchtype1.SendKeys("سوییچ دو");
//            Thread.Sleep(1000);
//            switchtype1.SendKeys(Keys.Down);
//            switchtype1.SendKeys(Keys.Enter);

//            // دسته
//            IWebElement divcode1 = driver.FindElement(By.Id("txtDivisionCode"));
//            divcode1.Click();
//            divcode1.SendKeys("تست سداد");
//            divcode1.SendKeys(Keys.Down);
//            divcode1.SendKeys(Keys.Enter);
//            //نوع شخصیت
//            IWebElement persontype1 = driver.FindElement(By.Id("txtpersonTypeLookupModelId"));
//            persontype1.Click();
//            persontype1.SendKeys("حقیقی");
//            persontype1.SendKeys(Keys.Down);
//            persontype1.SendKeys(Keys.Enter);
//            //کدملی
//            IWebElement nationalcode1 = driver.FindElement(By.Id("NationalCode"));
//            nationalcode1.Click();
//            nationalcode1.SendKeys("0082282838");
//            //0480205604
//            //نام
//            IWebElement FirstName1 = driver.FindElement(By.Id("FirstName"));
//            FirstName1.Click();
//            FirstName1.SendKeys("علی");
//            // نام انگلیسی
//            IWebElement FirstNameEn1 = driver.FindElement(By.Id("FirstNameEn"));
//            FirstNameEn1.Click();
//            FirstNameEn1.SendKeys("Ali");
//            Thread.Sleep(2000);
//            //گروه صنفی

//            IWebElement ParentShaparakMccCode1 = driver.FindElement(By.Id("txtParentShaparakMccCode"));
//            //ParentShaparakMccCode.Click();
//            //*[@id="bodyOfGirdToSetTopScrollbar"]/table/tbody/tr[6]/td/span/label
//            ParentShaparakMccCode1.SendKeys("تعاونی مسکن");
//            ParentShaparakMccCode1.SendKeys(Keys.Down);
//            ParentShaparakMccCode1.SendKeys(Keys.Enter);

//            //صنف
//            IWebElement ShaparakMCC1 = driver.FindElement(By.Id("txtshaparakMCCId"));
//            //ShaparakMCC.Click();
//            ShaparakMCC1.SendKeys("تعاونی مسکن");
//            ShaparakMCC1.SendKeys(Keys.Down);
//            ShaparakMCC1.SendKeys(Keys.Enter);
//            //عنوان شغلی
//            IWebElement JobTitle1 = driver.FindElement(By.Id("JobTitle"));
//            JobTitle1.Click();
//            JobTitle1.SendKeys("کارشناس تست اتومات");
//            //آدرس ایمیل 
//            IWebElement EMailAddress1 = driver.FindElement(By.Id("EMailAddress"));
//            EMailAddress1.Click();
//            EMailAddress1.SendKeys("test@sadadpsp.ir");

//            //آدرس وب سایت 
//            IWebElement WebSite1 = driver.FindElement(By.Id("WebSite"));
//            WebSite1.Click();
//            WebSite1.SendKeys("www.sadadportal.ir");
//            //موبایل 
//            IWebElement MerchantMobileNo1 = driver.FindElement(By.Id("MerchantMobileNo"));
//            MerchantMobileNo1.Click();
//            MerchantMobileNo1.SendKeys("9125183748");

//            //عاملیت
//            IWebElement OtherOrgAgencyPK1 = driver.FindElement(By.Id("txtOtherOrgAgencyPK"));
//            OtherOrgAgencyPK1.Click();
//            OtherOrgAgencyPK1.SendKeys("تست عاملیت");
//            OtherOrgAgencyPK1.SendKeys(Keys.Down);
//            OtherOrgAgencyPK1.SendKeys(Keys.Enter);

//            //تاریخ تولد/تاسیس
//            IWebElement birthdate1 = driver.FindElement(By.Id("BirthDate_dateTime"));
//            birthdate1.Click();
//            birthdate1.SendKeys("1368/05/18");

//            //تاریخ ثبت شرکت 
//            IWebElement LicenseDate1 = driver.FindElement(By.Id("LicenseDate_dateTime"));
//            LicenseDate1.Click();
//            LicenseDate1.SendKeys("1368/05/10");

//            ///اطلاعات شخص حقیقی 
//            //نام خانوادگی
//            IWebElement LastName1 = driver.FindElement(By.Id("LastName"));
//            LastName1.Click();
//            LastName1.SendKeys("صادق");
//            //نام خانوادگی انگلیسی 
//            IWebElement LastNameEn1 = driver.FindElement(By.Id("LastNameEn"));
//            LastNameEn1.Click();
//            LastNameEn1.SendKeys("Yousefi");
//            //نام پدر  
//            IWebElement FatherName1 = driver.FindElement(By.Id("FatherName"));
//            FatherName1.Click();
//            FatherName1.SendKeys("عبدالحسین");
//            // شماره شناسنامه   
//            IWebElement IDNum1 = driver.FindElement(By.Id("IdentityNo"));
//            IDNum1.Click();
//            IDNum1.SendKeys("0082282838");
//            // سریال  شناسنامه   
//            IWebElement SerialID1 = driver.FindElement(By.Id("IdNoSerial"));
//            SerialID1.Click();
//            SerialID1.SendKeys("614351");
//            //  حرف سریال    
//            IWebElement LetterID1 = driver.FindElement(By.Id("txtIdNoSeriesLetterID"));
//            LetterID1.Click();
//            LetterID1.SendKeys("الف");
//            LetterID1.SendKeys(Keys.Down);
//            LetterID1.SendKeys(Keys.Enter);

//            //  عدد سریال    
//            IWebElement IdNo1 = driver.FindElement(By.Id("IdNoSeriesNumber"));
//            IdNo1.Click();
//            IdNo1.SendKeys("35");
//            // وضعیت تاهل    
//            IWebElement MaritalStatus1 = driver.FindElement(By.Id("txtMaritalStatusCode"));
//            MaritalStatus1.Click();
//            MaritalStatus1.SendKeys("مجرد");
//            MaritalStatus1.SendKeys(Keys.Down);
//            MaritalStatus1.SendKeys(Keys.Enter);

//            //جنسیت    
//            IWebElement SexCode1 = driver.FindElement(By.Id("txtSexCode"));
//            SexCode1.Click();
//            SexCode1.SendKeys("مرد");
//            SexCode1.SendKeys(Keys.Down);
//            SexCode1.SendKeys(Keys.Enter);

//            //تاریخ انقضای گذرنامه
//            IWebElement PassExpiryDate1 = driver.FindElement(By.Id("PassportExpireDate_dateTime"));
//            PassExpiryDate1.Click();
//            PassExpiryDate1.SendKeys("1401/02/01");

//            //شماره گذرنامه
//            IWebElement PassportNo1 = driver.FindElement(By.Id("PassportNo"));
//            PassportNo1.Click();
//            PassportNo1.SendKeys("25251236");

//            //بعدی
//            IWebElement next1 = driver.FindElement(By.XPath("//input[@value='بعدی']"));
//            next1.Click();
//            Thread.Sleep(1000);

//            ///مدیریت آدرس 
//            //نوع آدرس 
//            IWebElement txtAddressTypeCode1 = driver.FindElement(By.Id("txtAddressTypeCode"));
//            txtAddressTypeCode1.Click();
//            txtAddressTypeCode1.SendKeys("آدرس محل کار");
//            Thread.Sleep(2000);
//            txtAddressTypeCode1.SendKeys(Keys.Down);
//            Thread.Sleep(2000);
//            txtAddressTypeCode1.SendKeys(Keys.Enter);
//            //شهر
//            IWebElement txtCityPK1 = driver.FindElement(By.Id("txtCityPK"));
//            txtCityPK1.Click();
//            txtCityPK1.SendKeys("تهران");
//            txtCityPK1.SendKeys(Keys.Down);
//            txtCityPK1.SendKeys(Keys.Enter);
//            Thread.Sleep(1000);
//            //کدپستی
//            IWebElement PostalCode1 = driver.FindElement(By.Id("PostalCode"));
//            PostalCode1.Click();
//            PostalCode1.SendKeys("9456146633");
//            Thread.Sleep(1000);
//            //شماره تماس
//            IWebElement TNo1 = driver.FindElement(By.Id("TelephoneNo"));
//            TNo1.Click();
//            TNo1.SendKeys("21-22863023");
//            //منطقه شهری 
//            IWebElement Section1 = driver.FindElement(By.Id("CitySection"));
//            Section1.Click();
//            Section1.SendKeys("3");
//            //آدرس کامل فارسی
//            IWebElement AddressFull1 = driver.FindElement(By.Id("AddressFull"));
//            AddressFull1.Click();
//            AddressFull1.SendKeys("خ پاسداران ، خ سوری ، پ17");

//            //آدرس کامل انگلیسی
//            IWebElement AddressFullEn1 = driver.FindElement(By.Id("AddressFullEn"));
//            AddressFullEn1.Click();
//            AddressFullEn1.SendKeys("Pasdaran Alley, Soori St, No 17");
//            //اضافه کردن
//            IWebElement Add2 = driver.FindElement(By.XPath("//input[@value='اضافه کردن']"));
//            Add2.Click();
//            Thread.Sleep(1000);
//            //بعدی
//            // IWebElement next1 = driver.FindElement(By.XPath("//input[@value='بعدی']"));
//            // next1.Click();
//            next.Click();
//            Thread.Sleep(1000);

//            ///مدیریت امضا
//            //ردیف
//            IWebElement RowSig1 = driver.FindElement(By.Id("Row_No"));
//            RowSig1.Click();
//            RowSig1.Clear();
//            RowSig1.SendKeys("2");
//            //ملیت
//            IWebElement SigNationality1 = driver.FindElement(By.Id("txtpartialCountryLookupModelId"));
//            SigNationality1.Click();
//            SigNationality1.SendKeys("ایران");
//            Thread.Sleep(1000);
//            SigNationality1.SendKeys(Keys.Down);
//            SigNationality1.SendKeys(Keys.Enter);
//            //نام
//            IWebElement SigFirstName1 = driver.FindElement(By.Id("SignatoryFirstName"));
//            SigFirstName1.Click();
//            SigFirstName1.SendKeys("نوید");
//            //نام خانوادگی
//            IWebElement SigLastName1 = driver.FindElement(By.Id("SignatoryLastName"));
//            SigLastName1.Click();
//            SigLastName1.SendKeys("آرمانی پور");
//            //کد ملی
//            IWebElement SigNationalCode1 = driver.FindElement(By.Id("SignatoryNationalCode"));
//            SigNationalCode1.Click();
//            SigNationalCode1.SendKeys("0065923057");
//            //شماره گذرنامه 
//            IWebElement SigPassNo1 = driver.FindElement(By.Id("SignatoryPassportNo"));
//            SigPassNo1.Click();
//            SigPassNo1.SendKeys("25524612");
//            //تاریخ تولد
//            IWebElement SigBirthDate1 = driver.FindElement(By.Id("SignatoryBirthDate_dateTime"));
//            SigBirthDate1.Click();
//            SigBirthDate1.SendKeys("1362/10/09");
//            SigBirthDate1.Click();
//            SigBirthDate1.SendKeys(Keys.Enter);

//            //اضافه کردن
//            Thread.Sleep(2000);
//            var Add3 = driver.FindElements(By.XPath("//input[@type='button' and @value='اضافه کردن']"));
//            Add3[1].Click();
//            Thread.Sleep(1000);
//            //بعدی
//            next.Click();
//            Thread.Sleep(2000);


//            ///مجموعه پذیرندگان - شرکا
//              //پذیرنده
//            IWebElement SubMerchant = driver.FindElement(By.Id("txtSubMerchantPK"));
//            SubMerchant.Click();
//            SubMerchant.SendKeys("000000130880743");
//            Thread.Sleep(1000);
//            SubMerchant.SendKeys(Keys.Down);
//            SubMerchant.SendKeys(Keys.Enter);
//            Thread.Sleep(1000);

//            //کد اقتصادی
//            IWebElement CommercialCode = driver.FindElement(By.Id("CommercialCode"));
//            CommercialCode.SendKeys("224455661012");
//            //ارتباط
//            IWebElement Relation = driver.FindElement(By.Id("txtRelationTypeLookupId"));
//            Relation.Click();
//            Relation.SendKeys("ت");//ن-نماینده رسمی 
//            Relation.SendKeys(Keys.Down);
//            Relation.SendKeys(Keys.Enter);
//            //اضافه کردن 
//            Add1[2].Click();

//            ///ارسال 
//            IWebElement Send1 = driver.FindElement(By.CssSelector("input[value='ارسال']"));
//            Send1.Click();
//            Thread.Sleep(20000);
//            IWebElement returnAnswer1 = driver.FindElement(By.XPath("//*[@id='content']/div[3]/div[1]/div/ul/li"));
//            var Actualresult1 = returnAnswer1.Text;
//            var Expectedresult1 = "با موفقیت ذخیره شد";
//            Assert.IsTrue(Actualresult.Contains(Expectedresult1));
//            System.Diagnostics.Debug.WriteLine("نتیجه ساخت پذیرنده " + "\n" + Actualresult1);
//            Console.WriteLine("نتیجه ساخت پذیرنده " + "\n" + Actualresult1);

//            //-----------------------------------------------------------------------------------//

//            //---------------------------------------------------------------------------------------//

//            //ساخت قرارداد شریک تجاری 

//            driver.Url = "http://172.24.34.40/Merchants/Contracts/CreateMerchantContract";

//            //شماره پذیرنده
//            IWebElement CardAcqid = driver.FindElement(By.Id("txtPartialMerchantPK"));
//            CardAcqid.Click();
//            CardAcqid.SendKeys("000000140337773");
//            Thread.Sleep(2000);
//            CardAcqid.SendKeys(Keys.Down);
//            CardAcqid.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            //نمایندگی
//            IWebElement Agency = driver.FindElement(By.Id("txtContracted_AcqAgencyPK"));
//            Agency.Click();
//            Agency.SendKeys("اصفهان");
//            Thread.Sleep(2000);
//            Agency.SendKeys(Keys.Down);
//            Agency.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            //نام فروشگاه فارسی 
//            IWebElement StoreNameFA = driver.FindElement(By.Id("StoreName"));
//            StoreNameFA.Click();
//            StoreNameFA.Clear();
//            StoreNameFA.SendKeys("سوهان حاج محمدی و برادران");

//            //شعبه 
//            IWebElement Branch = driver.FindElement(By.Id("txtContracted_BankBranchPK"));
//            Branch.Click();
//            Branch.Clear();
//            Branch.SendKeys("سیدخندان");
//            Thread.Sleep(2000);
//            Agency.SendKeys(Keys.Down);
//            Agency.SendKeys(Keys.Enter);


//            //پایانه درخواستی 
//            IWebElement RequestedTermsCount = driver.FindElement(By.Id("RequestedTermsCount"));
//            RequestedTermsCount.Click();
//            RequestedTermsCount.Clear();
//            RequestedTermsCount.SendKeys("1");

//            //نوع پایانه 

//            IWebElement termtypeContract = driver.FindElement(By.Id("txtTermTypeCode"));
//            termtypeContract.Click();
//            termtypeContract.SendKeys("پایانه فروشگاهی");
//            Thread.Sleep(1000);
//            termtypeContract.SendKeys(Keys.Down);
//            termtypeContract.SendKeys(Keys.Enter);

//            /// *شماره شبای پذیرنده اصلی * شریک    
//            IWebElement iBAN = driver.FindElement(By.Id("IBAN"));
//            iBAN.Click();
//            iBAN.SendKeys("IR810170000000227545995008");
//            Thread.Sleep(2000);

//            //alert استعلام شبا 
//            IWebElement alert = driver.FindElement(By.XPath("//*[@type='button' and @class='btn btn-blue' and text()='متوجه شدم']"));
//            alert.Click();
//            Thread.Sleep(2000);

//            //شماره حساب 
//            IWebElement accountNo = driver.FindElement(By.XPath("//*[@id='contractManagementFromId']//*[@id='AccountNo']"));
//            accountNo.Click();
//            accountNo.SendKeys("0360820754006");

//            //بانک 
//            IWebElement Bankpk = driver.FindElement(By.Id("txtpartialBank"));
//            Bankpk.Click();
//            Bankpk.SendKeys("ملی");
//            Thread.Sleep(2000);
//            Bankpk.SendKeys(Keys.Down);
//            Bankpk.SendKeys(Keys.Enter);

//            //حوزه 
//            IWebElement zone = driver.FindElement(By.Id("txtpartialBankZone"));
//            zone.Click();
//            Thread.Sleep(2000);
//            zone.SendKeys("اداره امور تست سداد");
//            Thread.Sleep(2000);
//            zone.SendKeys(Keys.Down);
//            zone.SendKeys(Keys.Enter);

//            //وضعیت کد شبا 
//            IWebElement IBANStatusCode = driver.FindElement(By.Id("txtIBANStatusCode"));
//            IBANStatusCode.Clear();
//            IBANStatusCode.SendKeys("درخواست حساب فعال");
//            Thread.Sleep(2000);
//            IBANStatusCode.SendKeys(Keys.Down);
//            IBANStatusCode.SendKeys(Keys.Enter);

//            //ذخیره 
//            IWebElement AddContract = driver.FindElement(By.XPath("//input[@type='button' and @value='اضافه کردن']"));
//            AddContract.Click();
//            Thread.Sleep(3000);

//            //---------------------------------------------------------------------------------//

//            //ساخت قرارداد پذیرنده عادی و افزودن شبای پذیرنده عادی و شریک  در آن
//            driver.Url = "http://172.24.34.40/Merchants/Contracts/CreateMerchantContract";

//            //شماره پذیرنده
//            IWebElement CardAcqidSharik = driver.FindElement(By.Id("txtPartialMerchantPK"));
//            CardAcqidSharik.Click();
//            CardAcqidSharik.SendKeys("000000140337773");
//            Thread.Sleep(2000);
//            CardAcqidSharik.SendKeys(Keys.Down);
//            CardAcqidSharik.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            //نمایندگی
//            IWebElement AgencySharik = driver.FindElement(By.Id("txtContracted_AcqAgencyPK"));
//            AgencySharik.Click();
//            AgencySharik.SendKeys("اصفهان");
//            Thread.Sleep(2000);
//            AgencySharik.SendKeys(Keys.Down);
//            AgencySharik.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            //نام فروشگاه فارسی 
//            IWebElement StoreNameFA1 = driver.FindElement(By.Id("StoreName"));
//            StoreNameFA1.Click();
//            StoreNameFA1.Clear();
//            StoreNameFA1.SendKeys("سوهان حاج محمدی و برادران");

//            //شعبه 
//            IWebElement Branch1 = driver.FindElement(By.Id("txtContracted_BankBranchPK"));
//            Branch1.Click();
//            Branch1.Clear();
//            Branch1.SendKeys("سیدخندان");
//            Thread.Sleep(2000);
//            Branch1.SendKeys(Keys.Down);
//            Branch1.SendKeys(Keys.Enter);


//            //پایانه درخواستی 
//            IWebElement RequestedTermsCount1 = driver.FindElement(By.Id("RequestedTermsCount"));
//            RequestedTermsCount1.Click();
//            RequestedTermsCount1.Clear();
//            RequestedTermsCount1.SendKeys("1");

//            //نوع پایانه 

//            IWebElement termtypeContract1 = driver.FindElement(By.Id("txtTermTypeCode"));
//            termtypeContract1.Click();
//            termtypeContract1.SendKeys("پایانه فروشگاهی");
//            Thread.Sleep(1000);
//            termtypeContract1.SendKeys(Keys.Down);
//            termtypeContract1.SendKeys(Keys.Enter);

//            /// شماره شبای پذیرنده اصلی  
//            IWebElement iBAN1 = driver.FindElement(By.Id("IBAN"));
//            iBAN1.Click();
//            iBAN1.SendKeys("IR810170000000227545995008");
//            Thread.Sleep(2000);

//            //alert استعلام شبا 
//            IWebElement alert2 = driver.FindElement(By.XPath("//*[@type='button' and @class='btn btn-blue' and text()='متوجه شدم']"));
//            alert2.Click();
//            Thread.Sleep(2000);

//            //شماره حساب 
//            IWebElement accountNo1 = driver.FindElement(By.XPath("//*[@id='contractManagementFromId']//*[@id='AccountNo']"));
//            accountNo1.Click();
//            accountNo1.SendKeys("0360820754006");

//            //بانک 
//            IWebElement Bankpk1 = driver.FindElement(By.Id("txtpartialBank"));
//            Bankpk1.Click();
//            Bankpk1.SendKeys("ملی");
//            Thread.Sleep(2000);
//            Bankpk1.SendKeys(Keys.Down);
//            Bankpk1.SendKeys(Keys.Enter);

//            //حوزه 
//            IWebElement zone1 = driver.FindElement(By.Id("txtpartialBankZone"));
//            zone1.Click();
//            Thread.Sleep(2000);
//            zone1.SendKeys("اداره امور تست سداد");
//            Thread.Sleep(2000);
//            zone1.SendKeys(Keys.Down);
//            zone1.SendKeys(Keys.Enter);

//            //وضعیت کد شبا 
//            IWebElement IBANStatusCode1 = driver.FindElement(By.Id("txtIBANStatusCode"));
//            IBANStatusCode1.Clear();
//            IBANStatusCode1.SendKeys("درخواست حساب فعال");
//            Thread.Sleep(2000);
//            IBANStatusCode1.SendKeys(Keys.Down);
//            IBANStatusCode1.SendKeys(Keys.Enter);

//            //ذخیره 
//            IWebElement AddContract1 = driver.FindElement(By.XPath("//input[@type='button' and @value='اضافه کردن']"));
//            AddContract1.Click();
//            Thread.Sleep(3000);


//            ///افزودن شبای شریک 
//            iBAN.Click();
//            iBAN.SendKeys("IR150151000002000060426415");
//            Thread.Sleep(2000);

//            //alert استعلام شبا 
//            IWebElement alert1 = driver.FindElement(By.XPath("//*[@type='button' and @class='btn btn-blue' and text()='متوجه شدم']"));
//            alert1.Click();
//            Thread.Sleep(2000);

//            //شماره حساب 
//            accountNo.Click();
//            accountNo.SendKeys("02000060426415");

//            //بانک 
//            Bankpk.Click();
//            Bankpk.SendKeys("ملی");
//            Thread.Sleep(2000);
//            Bankpk.SendKeys(Keys.Down);
//            Bankpk.SendKeys(Keys.Enter);
            
//            //حوزه 

//            zone.Click();
//            zone.SendKeys("اداره امور تست سداد");
//            Thread.Sleep(2000);
//            zone.SendKeys(Keys.Down);
//            zone.SendKeys(Keys.Enter);


//            //نام صاحب حساب 
//            IWebElement AccountHolder = driver.FindElement(By.Id("txtPatrialRelatedMerchnatPK"));
//            AccountHolder.Click();
//            AccountHolder.SendKeys("000000130880743");
//            Thread.Sleep(2000);
//            AccountHolder.SendKeys(Keys.Down);
//            AccountHolder.SendKeys(Keys.Enter);

//            //وضعیت کد شبا 
//            IBANStatusCode.Clear();
//            IBANStatusCode.SendKeys("درخواست حساب فعال");
//            Thread.Sleep(2000);
//            IBANStatusCode.SendKeys(Keys.Down);
//            IBANStatusCode.SendKeys(Keys.Enter);

//            AddContract.Click();

//            //ارسال
//            IWebElement SendContract = driver.FindElement(By.XPath("//input[@type='button' and  @value='ارسال']"));
//            SendContract.Click();

//            //تایید شاپرکی  همه موارد شامل شباهای پذیرنده اصلی و شریک تجاری 

//            driver.Url = "http://172.24.34.40/SubOperation/CheckIbanChanges/Index";
//            IWebElement cardacqid = driver.FindElement(By.Id("txtMerchantPkList"));
//            cardacqid.Click();
//            cardacqid.SendKeys("000000140337774");
//            Thread.Sleep(2000);
//            cardacqid.SendKeys(Keys.Down);
//            cardacqid.SendKeys(Keys.Enter);
//            //جستجوی
//            IWebElement Search1 = driver.FindElement(By.CssSelector("input[value='جستجو']"));
//            Search1.Click();
//            Thread.Sleep(3000);

//            var amaliyatButton = driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
//            //button#id//button.class//button[class='']//button.class[attribute='']

//            //ردیف اول
//            amaliyatButton[0].Click();
//            IWebElement Tayid = driver.FindElement(By.LinkText("تایید"));
//            Thread.Sleep(1000);
//            Tayid.Click();
//            IWebElement submit = driver.FindElement(By.Id("submitModal"));
//            Thread.Sleep(1000);
//            submit.Click();
//            Thread.Sleep(5000);
//            ////ردیف دوم
//            var amaliyatButton1 = driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
//            amaliyatButton1[0].Click();
//            IWebElement Tayid1 = driver.FindElement(By.LinkText("تایید"));
//            Thread.Sleep(1000);
//            Tayid1.Click();
//            IWebElement submit1 = driver.FindElement(By.Id("submitModal"));
//            Thread.Sleep(1000);
//            submit1.Click();
//            Thread.Sleep(5000);
//            ////ردیف سوم
//            var amaliyatButton2 = driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
//            amaliyatButton2[0].Click();
//             IWebElement Tayid2 = driver.FindElement(By.LinkText("تایید"));
//            Thread.Sleep(1000);
//            Tayid2.Click();
//            IWebElement submit2 = driver.FindElement(By.Id("submitModal"));
//            Thread.Sleep(1000);
//            submit2.Click();
//            Thread.Sleep(2000);

//            //ردیف چهارم 
//            var amaliyatButton3 = driver.FindElements(By.CssSelector("button.ui.-button[role='button']"));
//            amaliyatButton3[0].Click();
//            IWebElement tayid3 = driver.FindElement(By.LinkText("تایید"));
//            Thread.Sleep(3000);
//            tayid3.Click();
//            IWebElement submit3 = driver.FindElement(By.Id("submitModal"));
//            Thread.Sleep(2000);
//            submit3.Click();
//            Thread.Sleep(2000);

//            //amaliyatButton[2].Click();

//            ///---using explicit wait--///
//            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
//            //IWebElement amaliyatGrid = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("button.ui-button[role='button']")));
//            //button#id//button.class//button[class='']//button.class[attribute='']
//            ///---using explicit wait--///








//        }

//    }
//}
