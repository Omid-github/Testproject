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
//    public class Edit_Merchant 
//    {
//        //public IWebDriver driver;
        
//        [Test]
//        public void EditMerchant() 
//        {
            
//            var login = new Login_portal();
//            var driver = login.StartBrowser();

//            //ورود به فرم ویرایش  پذیرنده 
          
//            IWebElement amaliat = driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
//            amaliat.Click();
//            IWebElement menumerchant = driver.FindElement(By.XPath("//*[@id='el_5']/ul/li[4]/a"));
//            menumerchant.Click();
//            System.Threading.Thread.Sleep(3000);
//            IWebElement cardacqid = driver.FindElement(By.Id("txtCardAcqId"));
//            cardacqid.Click();

//            //var ExcelObj = new Test_Data();
//            //var excel = ExcelObj.MainTest();
//            //cardacqid.SendKeys(excel[0].Cardacqid);

       

//            cardacqid.SendKeys("000000130511773");

//            Thread.Sleep(2000);
//            cardacqid.SendKeys(Keys.Down);
//            cardacqid.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            //جستجو
//            IWebElement search = driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
//            search.Click();
//            Thread.Sleep(2000);
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
//            IWebElement amaliyatGrid = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("button.ui-button[role='button']")));
//            //button#id//button.class//button[class='']//button.class[attribute='']
//            amaliyatGrid.Click();

//            //ویرایش در گرید عملیات
//            IWebElement Edit  = driver.FindElement(By.Id("ui-id-9")).FindElement(By.LinkText("ویرایش"));
//            Edit.Click();

//            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
//            // Edit.Click();
//            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(4);
//            Thread.Sleep(5000);
//            //NationalCode_Alias
//            IWebElement nationalcode = driver.FindElement(By.Id("NationalCode_Alias"));
//             nationalcode.Click();
//             nationalcode.SendKeys("0440034922");
//             Thread.Sleep(1000);

//            //birthdate
//             IWebElement BirthDateAlias = driver.FindElement(By.Id("BirthDate_Alias_dateTime"));
//             BirthDateAlias.Click();
//             BirthDateAlias.SendKeys("1378/02/31");
//             BirthDateAlias.SendKeys(Keys.Enter);

//            Thread.Sleep(1000);
//            //نام
//            IWebElement FirstName = driver.FindElement(By.Id("FirstName"));
//            FirstName.Click();
//            FirstName.Clear();
//            FirstName.SendKeys("حامد");
//            // نام انگلیسی
//            IWebElement FirstNameEn = driver.FindElement(By.Id("FirstNameEn"));
//            FirstNameEn.Click();
//            FirstNameEn.Clear();
//            FirstNameEn.SendKeys("Hamed");
//            Thread.Sleep(2000);
           
//            ///اطلاعات شخص حقیقی 
//            //نام خانوادگی
//            IWebElement LastName = driver.FindElement(By.Id("LastName"));
//            LastName.Click();
//            LastName.Clear();
//            LastName.SendKeys("لشکری");
//            //نام خانوادگی انگلیسی 
//            IWebElement LastNameEn = driver.FindElement(By.Id("LastNameEn"));
//            LastNameEn.Click();
//            LastNameEn.Clear();
//            LastNameEn.SendKeys("Lashgari");
//            //نام پدر  
//            IWebElement FatherName = driver.FindElement(By.Id("FatherName"));
//            FatherName.Click();
//            FatherName.Clear();
//            FatherName.SendKeys("اصغر");
//            // شماره شناسنامه   
//            IWebElement IDNum = driver.FindElement(By.Id("IdentityNo"));
//            IDNum.Click();
//            IDNum.Clear();
//            IDNum.SendKeys("0480205604");
//            // سریال  شناسنامه   
//            IWebElement SerialID = driver.FindElement(By.Id("IdNoSerial"));
//            SerialID.Click();
//            SerialID.Clear();
//            SerialID.SendKeys("912099");
//            //  حرف سریال    
//            IWebElement LetterID = driver.FindElement(By.Id("txtIdNoSeriesLetterID"));
//            LetterID.Click();
//            LetterID.Clear();
//            LetterID.SendKeys("ب");
//            LetterID.SendKeys(Keys.Down);
//            LetterID.SendKeys(Keys.Enter);

//            //  عدد سریال    
//            IWebElement IdNo = driver.FindElement(By.Id("IdNoSeriesNumber"));
//            IdNo.Click();
//            IdNo.Clear();
//            IdNo.SendKeys("35");
//            // وضعیت تاهل    
//            IWebElement MaritalStatus = driver.FindElement(By.Id("txtMaritalStatusCode"));
//            MaritalStatus.Click();
//            MaritalStatus.Clear();
//            MaritalStatus.SendKeys("مجرد");
//            MaritalStatus.SendKeys(Keys.Down);
//            MaritalStatus.SendKeys(Keys.Enter);

//            //جنسیت    
//            IWebElement SexCode = driver.FindElement(By.Id("txtSexCode"));
//            SexCode.Click();
//            SexCode.Clear();
//            SexCode.SendKeys("مرد");
//            SexCode.SendKeys(Keys.Down);
//            SexCode.SendKeys(Keys.Enter);

//            //تاریخ انقضای گذرنامه
//            IWebElement PassExpiryDate = driver.FindElement(By.Id("PassportExpireDate_dateTime"));
//            PassExpiryDate.Click();
//            PassExpiryDate.Clear();
//            PassExpiryDate.SendKeys("1401/02/01");

//            //شماره  گذرنامه
//            IWebElement PassportNo = driver.FindElement(By.Id("PassportNo"));
//            PassportNo.Click();
//            PassportNo.Clear();
//            PassportNo.SendKeys("25251236");

//            //گروه صنفی
//            IWebElement ParentShaparakMccCode = driver.FindElement(By.Id("txtParentShaparakMccCode"));
//            ParentShaparakMccCode.Clear();
//            //ParentShaparakMccCode.Click();
//            //*[@id="bodyOfGirdToSetTopScrollbar"]/table/tbody/tr[6]/td/span/label
//            ParentShaparakMccCode.SendKeys("تعاونی مسکن");
//            ParentShaparakMccCode.SendKeys(Keys.Down);
//            ParentShaparakMccCode.SendKeys(Keys.Enter);

//            //صنف
//            IWebElement ShaparakMCC = driver.FindElement(By.Id("txtshaparakMCCId"));
//            ShaparakMCC.Clear();
//            //ShaparakMCC.Click();
//            ShaparakMCC.SendKeys("تعاونی مسکن");
//            ShaparakMCC.SendKeys(Keys.Down);
//            ShaparakMCC.SendKeys(Keys.Enter);
//            //عنوان شغلی
//            IWebElement JobTitle = driver.FindElement(By.Id("JobTitle"));
//            JobTitle.Click();
//            JobTitle.Clear();
//            JobTitle.SendKeys("کارشناس تست اتومات");
//            //آدرس ایمیل 
//            IWebElement EMailAddress = driver.FindElement(By.Id("EMailAddress"));
//            EMailAddress.Click();
//            EMailAddress.Clear();
//            EMailAddress.SendKeys("test@sadadpsp.ir");

//            //آدرس وب سایت 
//            IWebElement WebSite = driver.FindElement(By.Id("WebSite"));
//            WebSite.Click();
//            WebSite.Clear();
//            WebSite.SendKeys("www.sadadportal.ir");
//            //موبایل 
//            IWebElement MerchantMobileNo = driver.FindElement(By.Id("MerchantMobileNo"));
//            MerchantMobileNo.Click();
//            MerchantMobileNo.Clear();
//            MerchantMobileNo.SendKeys("9125183748");

//            //عاملیت
//            IWebElement OtherOrgAgencyPK = driver.FindElement(By.Id("txtOtherOrgAgencyPK"));
//            OtherOrgAgencyPK.Click();
//            OtherOrgAgencyPK.Clear();
//            OtherOrgAgencyPK.SendKeys("تست عاملیت");
//            OtherOrgAgencyPK.SendKeys(Keys.Down);
//            OtherOrgAgencyPK.SendKeys(Keys.Enter);

//            //تاریخ تولد/تاسیس
//            IWebElement birthdate = driver.FindElement(By.Id("BirthDate_dateTime"));
//            birthdate.Click();
//            birthdate.Clear();
//            birthdate.SendKeys("1369/05/25");

//            //تاریخ ثبت شرکت 
//            IWebElement LicenseDate = driver.FindElement(By.Id("LicenseDate_dateTime"));
//            LicenseDate.Click();
//            LicenseDate.Clear();
//            LicenseDate.SendKeys("1378/02/01");

//            //نوع پذیرنده مولتی مرچنت 
//            IWebElement MultiMerchantTypePK = driver.FindElement(By.Id("txtMultiMerchantTypePK"));
//            MultiMerchantTypePK.Click();
//            MultiMerchantTypePK.Clear();
//            MultiMerchantTypePK.SendKeys("اصلی");
//            MultiMerchantTypePK.SendKeys(Keys.Down);
//            MultiMerchantTypePK.SendKeys(Keys.Enter);

//            //بعدی
//            IWebElement next = driver.FindElement(By.XPath("//input[@value='بعدی']"));
//            next.Click();
//            Thread.Sleep(1000);

//            ///مدیریت آدرس 
//            ///ویرایش ادرس ردیف اول 
//            IWebElement gridamaliat = driver.FindElement(By.XPath("//*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[1]/td[9]/span/div/button"));
//            ////*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[2]/td[9]/span/div/button"
//            gridamaliat.Click();
//            Thread.Sleep(3000);
//            ///ویرایش ادرس ردیف دوم
//            //*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[2]/td[9]/span/div/button"
//           //ویرایش در گرید عملیات
//            IWebElement Editadrs = driver.FindElement(By.XPath("//*[@id='bodyOfGirdToSetTopScrollbar']/table/tbody/tr[1]/td[9]//div//li[1]/a"));
//            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
//            Editadrs.Click();
//            Thread.Sleep(3000);
//            //نوع آدرس 
//            IWebElement txtAddressTypeCode = driver.FindElement(By.Id("txtAddressTypeCode"));
//            txtAddressTypeCode.Click();
//            txtAddressTypeCode.Clear();
//            txtAddressTypeCode.SendKeys("آدرس محل کار");
//            Thread.Sleep(1000);
//            txtAddressTypeCode.SendKeys(Keys.Down);
//            txtAddressTypeCode.SendKeys(Keys.Enter);
//            //شهر
//            IWebElement txtCityPK = driver.FindElement(By.Id("txtCityPK"));
//            txtCityPK.Click();
//            txtCityPK.Clear();
//            txtCityPK.SendKeys("تهران");
//            txtCityPK.SendKeys(Keys.Down);
//            txtCityPK.SendKeys(Keys.Enter);
//            //کدپستی
//            IWebElement PostalCode = driver.FindElement(By.Id("PostalCode"));
//            PostalCode.Click();
//            PostalCode.Clear();
//            PostalCode.SendKeys("1541697145");
//            //تلفن سر خط
//            IWebElement TNo = driver.FindElement(By.Id("TelephoneNo"));
//            TNo.Click();
//            TNo.Clear();
//            Thread.Sleep(1000);
//            TNo.SendKeys("21-22863023");
//            //منطقه شهری 
//            IWebElement Section = driver.FindElement(By.Id("CitySection"));
//            Section.Click();
//            Section.Clear();
//            Section.SendKeys("3");
//            //آدرس کامل فارسی
//            IWebElement AddressFull = driver.FindElement(By.Id("AddressFull"));
//            AddressFull.Click();
//            AddressFull.Clear();
//            AddressFull.SendKeys("خ پاسداران ، خ سوری ، پ17");

//            //آدرس کامل انگلیسی
//            IWebElement AddressFullEn = driver.FindElement(By.Id("AddressFullEn"));
//            AddressFullEn.Click();
//            AddressFullEn.Clear();
//            AddressFullEn.SendKeys("Pasdaran Alley, Soori St, No 17");

//            //ذخیره
//            IWebElement save = driver.FindElement(By.XPath("//*[@id='merchantmanagementFormId']//div[10]//input[@value='ذخیره']"));
//            save.Click();
//            Thread.Sleep(3000);

//            //بعدی
//            next.Click();
//            Thread.Sleep(2000);


//            ////////////////////////////////////////////////////////////// /////////////////سناریوی دوم --اضافه کردن ادرس جدید
//            ////نوع آدرس 
//            //IWebElement txtAddressTypeCode = driver.FindElement(By.Id("txtAddressTypeCode"));
//            //txtAddressTypeCode.Click();
//            //Thread.Sleep(1000);
//            //txtAddressTypeCode.SendKeys("آدرس محل کار");
//            //Thread.Sleep(2000);
//            //txtAddressTypeCode.SendKeys(Keys.Down);
//            //txtAddressTypeCode.SendKeys(Keys.Enter);
//            ////شهر
//            //IWebElement txtCityPK = driver.FindElement(By.Id("txtCityPK"));
//            //txtCityPK.Click();
//            //txtCityPK.SendKeys("تهران");
//            //txtCityPK.SendKeys(Keys.Down);
//            //txtCityPK.SendKeys(Keys.Enter);
//            ////کدپستی
//            //IWebElement PostalCode = driver.FindElement(By.Id("PostalCode"));
//            //PostalCode.Click();
//            //PostalCode.SendKeys("1541697145");
//            ////شماره تماس
//            //IWebElement TNo = driver.FindElement(By.Id("TelephoneNo"));
//            //TNo.Click();
//            //TNo.SendKeys("21-22863023");
//            ////منطقه شهری 
//            //IWebElement Section = driver.FindElement(By.Id("CitySection"));
//            //Section.Click();
//            //Section.SendKeys("3");
//            ////آدرس کامل فارسی
//            //IWebElement AddressFull = driver.FindElement(By.Id("AddressFull"));
//            //AddressFull.Click();
//            //AddressFull.SendKeys("خ پاسداران ، خ سوری ، پ17");

//            ////آدرس کامل انگلیسی
//            //IWebElement AddressFullEn = driver.FindElement(By.Id("AddressFullEn"));
//            //AddressFullEn.Click();
//            //AddressFullEn.SendKeys("Pasdaran Alley, Soori St, No 17");
//            ////ذخیره
//            //IWebElement save = driver.FindElement(By.XPath("//input[@value='ذخیره']"));
//            //save.Click();
//            //Thread.Sleep(3000);
//            ////بعدی
//            //IWebElement next = driver.FindElement(By.XPath("//input[@value='بعدی']"));
//            //next.Click();
//            //Thread.Sleep(1000);
//            /////////////////////////////////////////////////////////////////////////////////////////////

//            /////مدیریت امضا
//            //ردیف
//            IWebElement Row = driver.FindElement(By.Id("Row_No"));
//            Row.Click();
//            Row.Clear();
//            Row.SendKeys("2");
//             //ملیت
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
//            //ذخیره 
//            Thread.Sleep(1000);
//            IWebElement save1 = driver.FindElement(By.XPath("//*[@id='merchantmanagementFormId']//div[11]//input[@value='ذخیره']"));
//            save1.Click();
//            Thread.Sleep(4000);
//            //بعدی
//            next.Click();
//            Thread.Sleep(1000);
//            ///مجموعه پذیرندگان - شرکا
//              //پذیرنده
//            IWebElement SubMerchant = driver.FindElement(By.Id("txtSubMerchantPK"));
//            SubMerchant.Click();
//            SubMerchant.SendKeys("000000130880743");
//            Thread.Sleep(2000);
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
//            //ذخیره
//            IWebElement save2 = driver.FindElement(By.XPath("//*[@id='merchantmanagementFormId']//div[12]//input[@value='ذخیره']"));
//            save2.Click();
//            Thread.Sleep(4000);

//            //قبلی
//            IWebElement Previous = driver.FindElement(By.XPath("//input[@value='قبلی']"));
//            Previous.Click();
//            Thread.Sleep(1000);
//            Previous.Click();
//            Previous.Click();
//            Thread.Sleep(2000);
//            //ارسال 
//            IWebElement Send = driver.FindElement(By.XPath("//input[@type='button' and  @value='ارسال']"));
//            Send.Click();
//            Thread.Sleep(12000);
//            ////خروج و بستن مرورگر
//            driver.Close();
//            // Actions act = new Actions(driver);
//            // act.MoveToElement(edit).Click().Build().Perform();
//            //Thread.Sleep(5000);
//            //var href = edit.GetAttribute("href");
//            //driver.Navigate().GoToUrl(href);

//        }

//    }
//}
