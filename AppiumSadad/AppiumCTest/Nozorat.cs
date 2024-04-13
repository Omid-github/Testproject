using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Interfaces;
using LamarCodeGeneration.Util;
using Uno;
using System.Threading;
using OpenQA.Selenium.Remote;
using System.Runtime.InteropServices;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Drawing;

namespace AppiumCTest
{
    public class Nozorat
    {

        private AppiumDriver<AndroidElement> driver;

        [Test]

        public void Setup()
        {
            var driver=TestHelper.SetupIvaPre_Operation();
            TestHelper.LoginPre_Operation(driver);
           
            //سرویس نذورات 

            int startwidth, startheight, endwidth, endheight;

              startwidth = 703;
              startheight = 580;

              endwidth = 10;
              endheight = 580;

              new TouchAction(driver)
              .Press(startwidth, startheight).Wait(1000).MoveTo(endwidth, endheight).Release().Perform();

              Thread.Sleep(1000);


              startwidth = 703;
              startheight = 580;

              endwidth = 10;
              endheight = 580;

              new TouchAction(driver)
              .Press(startwidth, startheight).Wait(1000).MoveTo(endwidth, endheight).Release().Perform();

              Thread.Sleep(1000);

              startwidth = 10;
              startheight = 580;

              endwidth = 703;
              endheight = 580;

              new TouchAction(driver)
              .Press(startwidth, startheight).Wait(1000).MoveTo(endwidth, endheight).Release().Perform();



              AndroidElement Nozorat = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.LinearLayout/android.view.ViewGroup[2]/android.widget.RelativeLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/android.view.ViewGroup/android.widget.LinearLayout[1]/android.view.ViewGroup/android.widget.ImageView");
              Nozorat.Click();
              Thread.Sleep(2000);


              startwidth = 355;
              startheight = 1380;

              endwidth = 355;
              endheight = 200;

              new TouchAction((IPerformsTouchActions)driver)
              .Press(startwidth, startheight).Wait(2000).MoveTo(endwidth, endheight).Release().Perform();
              Thread.Sleep(2000);

              startwidth = 355;
              startheight = 200;

              endwidth = 355;
              endheight = 1380;

              new TouchAction(driver)
              .Press(startwidth, startheight).Wait(2000).MoveTo(endwidth, endheight).Release().Perform();
              Thread.Sleep(1000);

              //نذر اولی ها

              AndroidElement Avaliha = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout[4]/android.view.ViewGroup/android.widget.TextView[1]");
              Avaliha.Click();
              Thread.Sleep(1000);

              AndroidElement Amount = driver.FindElementById("com.sadadpsp.eva:id/textInputEditText");
              Amount.Click();
              Amount.SendKeys("1000");
              Thread.Sleep(1000);

              AndroidElement Name = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.LinearLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
              Name.Click();
              Name.SendKeys("حسین پیرحیاتی");
              Thread.Sleep(1000);

              AndroidElement PhoneNumber = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[2]/android.widget.LinearLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
              PhoneNumber.Click();
              PhoneNumber.SendKeys("09127794258");
              Thread.Sleep(1000);

              AndroidElement Adress = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[3]/android.widget.LinearLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
              Adress.Click();
              Adress.SendKeys("اشرفی اصفهانی خیابان باهنر ");
              Thread.Sleep(1000);

              startwidth = 355;
              startheight = 715;

              endwidth = 355;
              endheight = 435;

              new TouchAction(driver)
              .Press(startwidth, startheight).Wait(2000).MoveTo(endwidth, endheight).Release().Perform();
              Thread.Sleep(2000);


              AndroidElement GenderButtom = driver.FindElementById("com.sadadpsp.eva:id/comboWidget_action1");
              GenderButtom.Click();
              Thread.Sleep(1000);

              AndroidElement Mard = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout[2]/android.widget.RelativeLayout/android.widget.TextView");
              Mard.Click();
              Thread.Sleep(1000);

              AndroidElement PeymentButtom = driver.FindElementById("com.sadadpsp.eva:id/widget_button_text");
              PeymentButtom.Click();
              Thread.Sleep(1000);

              TestHelper.Peyment(driver);

              startwidth = 690;
              startheight = 430;

              endwidth = 10;
              endheight = 430;

              new TouchAction(driver)
              .Press(startwidth, startheight).Wait(1000).MoveTo(endwidth, endheight).Release().Perform();

              Thread.Sleep(1000);

              //مشارکت ها

              AndroidElement Nozorat2 = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.LinearLayout/android.view.ViewGroup[2]/android.widget.RelativeLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/android.view.ViewGroup/android.widget.LinearLayout[1]/android.view.ViewGroup/android.widget.ImageView");
              Nozorat2.Click();
              Thread.Sleep(3000);

              AndroidElement Mosharekatha = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout[2]/android.view.ViewGroup");
              Mosharekatha.Click();
              Thread.Sleep(2000);

              AndroidElement JahatPardakht = driver.FindElementById("com.sadadpsp.eva:id/comboWidget_action1");
              JahatPardakht.Click();
              Thread.Sleep(1000);

              AndroidElement HvadesTabiee = driver.FindElementById("com.sadadpsp.eva:id/list_item_value");
              HvadesTabiee.Click();
              Thread.Sleep(1000);

              AndroidElement Amount2 = driver.FindElementById("com.sadadpsp.eva:id/textInputEditText");
              Amount2.Click();
              Amount2.SendKeys("10000");
              Thread.Sleep(2000);

              AndroidElement Name2 = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[3]/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.LinearLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
              Name2.Click();
              Name2.SendKeys("سمیرا رحیمی");
              Thread.Sleep(2000);


              startwidth = 355;
              startheight = 730;

              endwidth = 355;
              endheight = 435;

              new TouchAction(driver)
              .Press(startwidth, startheight).Wait(2000).MoveTo(endwidth, endheight).Release().Perform();
              Thread.Sleep(2000);



              AndroidElement PhoneNumber2 = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[3]/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[2]/android.widget.LinearLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
              PhoneNumber2.Click();
              PhoneNumber2.SendKeys("09127794258");
              Thread.Sleep(1000);



              AndroidElement GenderButtom2 = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[4]/android.widget.LinearLayout/android.view.ViewGroup/android.widget.ImageView");
              GenderButtom2.Click();
              Thread.Sleep(1000);

              AndroidElement Zan = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout[1]/android.widget.RelativeLayout");
              Zan.Click();
              Thread.Sleep(1000);

              AndroidElement PeymentButtom3 = driver.FindElementById("com.sadadpsp.eva:id/widget_button_text");
              PeymentButtom3.Click();
              Thread.Sleep(1000);

              TestHelper.Peyment(driver);
            

              TestHelper.Loguot(driver);




        }
























    }

    //[Test]
    //public void Test1()
    //{






    //}
}

