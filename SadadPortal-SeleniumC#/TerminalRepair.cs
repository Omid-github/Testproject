//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support;
//using OpenQA.Selenium.Interactions;
//using System.Threading;
//using System.Collections;
//using OpenQA.Selenium.Support.UI;
//using NUnit.Framework;
////using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
//using System.IO;

//namespace Selenium
//{


//    public class TerminalRepair     
//    {
//        // public IWebDriver driver;
        
//        [Test]
//        public void Terminal_Repair() 
//        {

//            //Initialize
//            var Login = new Login_portal();
//            var driver = Login.StartBrowser();

//            //ورود به فرم مدیریت پایانه ها 
//            IWebElement amaliat = driver.FindElement(By.XPath("//*[@id='el_5']/a/span"));
//            amaliat.Click();
//            Thread.Sleep(2000);
//            IWebElement menuTerminal = driver.FindElement(By.XPath("//*[@href='/Merchants/terminals/Index']"));
//            menuTerminal.Click();
//            Thread.Sleep(1000);
           
//            System.Threading.Thread.Sleep(2000);
//            //Assert.True(driver.Title.Contains("اضافه کردن / ویرایش پایانه"));

//            ///جستجوی سریال 
//            //شماره سریال

//            IWebElement serial = driver.FindElement(By.Id("SerialNo"));
//            serial.Click();
//            //Random rand = new Random();
//            //int serNo = rand.Next(20220101, 20221229);
//            serial.SendKeys("");
//            Thread.Sleep(2000);

//            //نوع پایانه
//            IWebElement termtype = driver.FindElement(By.Id("txtTermTypeCode"));
//            termtype.Click();
//            termtype.SendKeys("پایانه فروشگاهی");
//            Thread.Sleep(2000);
//            termtype.SendKeys(Keys.Down);
//            termtype.SendKeys(Keys.Enter);

//            ////مدل پایانه 
//            //IWebElement model = driver.FindElement(By.Id("txtTermModelCode"));
//            //model.Click();
//            //model.SendKeys("");
//            //Thread.Sleep(2000);
//            //model.SendKeys(Keys.Down);
//            //model.SendKeys(Keys.Enter);

           
//            //نمایندگی
//            IWebElement Agency = driver.FindElement(By.Id("txtAcqAgencyPk"));
//            Agency.Click();
//            Agency.SendKeys("آذربایجان غربی");
//            Thread.Sleep(2000);
//            Agency.SendKeys(Keys.Down);
//            Agency.SendKeys(Keys.Enter);

//            //وضعیت پایانه 
//            IWebElement Status = driver.FindElement(By.Id("txtTermStatusCode"));
//            Status.Click();
//            Status.SendKeys("تخصیص به پذیرنده");
//            Thread.Sleep(2000);
//            Status.SendKeys(Keys.Down);
//            Status.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);
//            //جستجو
//            IWebElement search = driver.FindElement(By.XPath("//input[@type='button' and @value='جستجو']"));
//            search.Click();
//            Thread.Sleep(2000);



//            //گرید عملیات 
//            var  gridAmaliat = driver.FindElements(By.CssSelector("button.ui-button[role='button']"));
//            //css=tag.class || tag#id
//            gridAmaliat[0].Click();

//            IWebElement Repair = driver.FindElement(By.LinkText("تعمیر"));

//            var href = Repair.GetAttribute("href");
//            driver.Navigate().GoToUrl(href);


//            //دسته بندی خرابی 
//            IWebElement RepairCategory = driver.FindElement(By.Id("txtParentRepairCategory"));
//            RepairCategory.Click();
//            RepairCategory.SendKeys("مشکلات نرم افزاری");
//            Thread.Sleep(3000);
//            RepairCategory.SendKeys(Keys.Down);
//            RepairCategory.SendKeys(Keys.Enter);
//            Thread.Sleep(3000);


//            //دلیل خرابی 
//            IWebElement RepairReason = driver.FindElement(By.Id("txtSubRepairReason"));
//            RepairReason.Click();
//            RepairReason.SendKeys("هنگ میکند");
//            Thread.Sleep(3000);
//            RepairReason.SendKeys(Keys.Down);
//            RepairReason.SendKeys(Keys.Enter);
//            Thread.Sleep(3000);
//            //شماره سریال جدید
//            IWebElement txtNewTerminalPk = driver.FindElement(By.Id("txtNewTerminalPk"));
//            txtNewTerminalPk.Click();
//            txtNewTerminalPk.SendKeys("375GR6DH4D75I461KL8516R3275U22");
//            Thread.Sleep(3000);
//            txtNewTerminalPk.SendKeys(Keys.Down);
//            txtNewTerminalPk.SendKeys(Keys.Enter);
//            Thread.Sleep(2000);

//            ///ارسال 
//            IWebElement Send = driver.FindElement(By.CssSelector("input[value='ارسال']"));
//            Send.Click();
//            Thread.Sleep(10000);
//            IWebElement returnAnswer = driver.FindElement(By.XPath("//*[@id='content']/div[3]/div[1]/div/ul/li"));
//            var Actualresult = returnAnswer.Text;
//            var Expectedresult = "عملیات تعمیر/جایگزینی پایانه با موفقیت انجام شد";
//            Assert.AreEqual(Actualresult,Expectedresult);
//            System.Diagnostics.Debug.WriteLine("نتیجه تعمیر پایانه " + "\n" + Actualresult);
//            Console.WriteLine(": نتیجه تعمیر پایانه " + "\n" + Actualresult);

//            /////انتخاب دستگاه جدید
//            //Actions action = new Actions(driver);
//            //action.MoveToElement(driver.FindElement(By.Id("IsNewDevice"))).Click().Build().Perform()

//            //ارسال
//            //IWebElement send = driver.FindElement(By.XPath("//input[@class ='btn bg-blue pull-right' and @type ='button']"));
//            //send.Click();
//            //Thread.Sleep(3000);

//            //IWebElement returnAnswer = driver.FindElement(By.XPath("//*[@id='notification']/following::*/ul[1]/li[1]"));
//            //var Actualresult = returnAnswer.Text;
//            //var Expectedresult = "عملیات ثبت با موفقیت انجام شد";
//            //Assert.IsTrue(Actualresult.Contains(Expectedresult));
//            //Assert.AreEqual(returnAnswer.Text, "عملیات ثبت با موفقیت انجام شد");
//            //System.Diagnostics.Debug.WriteLine(Actualresult + "\n" + serNo.ToString() + " :شماره پایانه ");
//            //driver.Close();
//        }

//    }

//}









   

       
    
    
