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
//    public class Clone_MerchantContract 
//    {
//        //public IWebDriver driver;
        
//        [Test]
//        public void CloneMerchantContract()
//        {
            
//            var login = new Login_portal();
//            var driver = login.StartBrowser();

//            //ورود به فرم ویرایش  پذیرنده 
          
//            IWebElement amaliat = driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
//            amaliat.Click();
//            IWebElement menuContract = driver.FindElement(By.XPath("//*[@href='/Merchants/Contracts/Index']"));
//            menuContract.Click();
//            System.Threading.Thread.Sleep(3000);
//            IWebElement ContractNo = driver.FindElement(By.Id("ContractNo"));
//            ContractNo.Click();
//            ContractNo.SendKeys("MC0000001839551");
//            Thread.Sleep(2000);
  

//            //جستجو
//            IWebElement search = driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
//            search.Click();
//            Thread.Sleep(2000);
//            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
//            //IWebElement amaliyatGrid = wait.Until(ExpectedConditions.ElementExists(By.CssSelector("button.ui-button[role='button']")));
//            var AmaliyatGrid = driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
//            AmaliyatGrid[0].Click();


//            //کپی قرارداد, پذیرنده در گرید عملیات
//            IWebElement copy  = driver.FindElement(By.LinkText("کپی پذیرنده و قرارداد"));
//            copy.Click();

//            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(7);
//            // Edit.Click();
//            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(4);
//            Thread.Sleep(3000);


//            ///اطلاعات پذیرنده
//            //نوع پذیرنده

           
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
//            nationalcode.Clear();
//            nationalcode.SendKeys("0015952721");
//            //0480205604
//            //نام
//            IWebElement FirstName = driver.FindElement(By.Id("FirstName"));
//            FirstName.Click();
//            FirstName.SendKeys("حامد");
//            // نام انگلیسی
//            IWebElement FirstNameEn = driver.FindElement(By.Id("FirstNameEn"));
//            FirstNameEn.Click();
//            FirstNameEn.SendKeys("Hamed");
//            Thread.Sleep(2000);
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
//            birthdate.SendKeys("1369/05/25");

//            //تاریخ ثبت شرکت 
//            IWebElement LicenseDate = driver.FindElement(By.Id("LicenseDate_dateTime"));
//            LicenseDate.Click();
//            LicenseDate.SendKeys("1378/02/01");

//            ///اطلاعات شخص حقیقی 
//            //نام خانوادگی
//            IWebElement LastName = driver.FindElement(By.Id("LastName"));
//            LastName.Click();
//            LastName.SendKeys("لشکری");
//            //نام خانوادگی انگلیسی 
//            IWebElement LastNameEn = driver.FindElement(By.Id("LastNameEn"));
//            LastNameEn.Click();
//            LastNameEn.SendKeys("Lashgari");
//            //نام پدر  
//            IWebElement FatherName = driver.FindElement(By.Id("FatherName"));
//            FatherName.Click();
//            FatherName.SendKeys("اصغر");
//            // شماره شناسنامه   
//            IWebElement IDNum = driver.FindElement(By.Id("IdentityNo"));
//            IDNum.Click();
//            IDNum.SendKeys("0480205604");
//            // سریال  شناسنامه   
//            IWebElement SerialID = driver.FindElement(By.Id("IdNoSerial"));
//            SerialID.Click();
//            SerialID.SendKeys("912099");
//            //  حرف سریال    
//            IWebElement LetterID = driver.FindElement(By.Id("txtIdNoSeriesLetterID"));
//            LetterID.Click();
//            LetterID.SendKeys("ب");
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

//            //شماره  گذرنامه
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
//            Thread.Sleep(2000);
//            txtAddressTypeCode.SendKeys("آدرس محل کار");
//            txtAddressTypeCode.SendKeys(Keys.Down);
//            txtAddressTypeCode.SendKeys(Keys.Enter);
//            //شهر
//            IWebElement txtCityPK = driver.FindElement(By.Id("txtCityPK"));
//            txtCityPK.Click();
//            txtCityPK.SendKeys("تهران");
//            txtCityPK.SendKeys(Keys.Down);
//            txtCityPK.SendKeys(Keys.Enter);
//            //کدپستی
//            IWebElement PostalCode = driver.FindElement(By.Id("PostalCode"));
//            PostalCode.Click();
//            PostalCode.SendKeys("1541697145");
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
//            IWebElement Row = driver.FindElement(By.Id("Row_No"));
//            Row.Click();
//            Row.Clear();
//            Row.SendKeys("2");
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

//            //اضافه کردن
//            Thread.Sleep(1000);
//            IWebElement Add1 = driver.FindElement(By.XPath("//*[@id='merchantmanagementFormId']/div[11]/section/div/div[1]/div[2]/div/div/input"));
//            Add1.Click();
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
//            IWebElement Add2 = driver.FindElement(By.XPath("//*[@id='merchantmanagementFormId']/div[12]/section/div/div[1]/div[2]/div/div/input"));
//            Add2.Click();

//            ///ارسال 
//            IWebElement Send = driver.FindElement(By.XPath("//*[@id='merchantmanagementFormId']/div[14]/div/input"));
//            Send.Click();
//            Thread.Sleep(10000);
//            //  IWebElement returnAnswer = driver.FindElement(By.XPath("//*[@id='content']/div[3]/div[1]/div/ul/li"));
//            // var Actualresult= returnAnswer.Text;
//            // var Expectedresult = "با موفقیت ذخیره شد";
//            // Assert.IsTrue(Actualresult.Contains(Expectedresult));
//            // System.Diagnostics.Debug.WriteLine("نتیجه ساخت پذیرنده "+"\n"+Actualresult);
//            //Console.WriteLine("test2");
//            // Console.WriteLine("نتیجه ساخت پذیرنده " + "\n" + Actualresult);

//            ////خروج و بستن مرورگر
//            driver.Close();
//            driver.Quit();

//        }

//    }
//}
