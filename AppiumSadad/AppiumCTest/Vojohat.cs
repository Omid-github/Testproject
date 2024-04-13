using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
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
    public class Vojohat
    {
        private AppiumDriver<AndroidElement> driver;

        [Test]

        public void Setup()
        {
            var driver = TestHelper.SetupIvaPre_Operation();
            TestHelper.LoginPre_Operation(driver);

            //سرویس وجوهات 

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





            AndroidElement Vojohat = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.LinearLayout/android.view.ViewGroup[2]/android.widget.RelativeLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/android.view.ViewGroup/android.widget.LinearLayout[4]/android.view.ViewGroup/android.widget.ImageView");
            Vojohat.Click();
            Thread.Sleep(2000);

            AndroidElement JavadiAmoli = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout[2]/android.view.ViewGroup");
            JavadiAmoli.Click();
            Thread.Sleep(2000);

            AndroidElement MozoeVajh = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.LinearLayout/android.view.ViewGroup/android.widget.ImageView");
            MozoeVajh.Click();
            Thread.Sleep(2000);

            AndroidElement Khoms = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.TextView");
            Khoms.Click();
            Thread.Sleep(2000);

            AndroidElement NoeVajhe = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.LinearLayout[2]/android.view.ViewGroup/android.widget.ImageView");
            NoeVajhe.Click();
            Thread.Sleep(2000);

            AndroidElement SelectSahmeSadat = driver.FindElementById("com.sadadpsp.eva:id/list_item_value");
            SelectSahmeSadat.Click();
            Thread.Sleep(2000);

            AndroidElement AmountBox = driver.FindElementById("com.sadadpsp.eva:id/textInputEditText");
            AmountBox.Click();
            AmountBox.SendKeys("1000");
            Thread.Sleep(2000);

            startwidth = 35;
            startheight = 767;

            endwidth = 35;
            endheight = 445;

            new TouchAction(driver)
            .Press(startwidth, startheight).Wait(1000).MoveTo(endwidth, endheight).Release().Perform();

            Thread.Sleep(1000);


            AndroidElement Name = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[3]/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.LinearLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
            Name.Click();
            Name.SendKeys("حسین");
            Thread.Sleep(2000);

            AndroidElement LastName = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[3]/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[2]/android.widget.LinearLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
            LastName.Click();
            LastName.SendKeys("پیرحیاتی");
            Thread.Sleep(2000);

            AndroidElement PhoneNumber = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[3]/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[3]/android.widget.LinearLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
            PhoneNumber.Click();
            PhoneNumber.SendKeys("09127794258");
            Thread.Sleep(2000);
                                                

            AndroidElement EmailAddress = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[3]/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[4]/android.widget.LinearLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
            EmailAddress.Click();
            EmailAddress.SendKeys("pirhayaty@gmail.com");
            Thread.Sleep(1000);

            startwidth = 35;
            startheight = 550;

            endwidth = 35;
            endheight = 250;

            new TouchAction(driver)
              .Press(startwidth, startheight).Wait(1000).MoveTo(endwidth, endheight).Release().Perform();
            Thread.Sleep(1000);

            //AndroidElement Address = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup[5]/android.widget.LinearLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
            //Address.Click();
            //Address.SendKeys("اشرفی اصفهانی خیابان باهنر");
            //Thread.Sleep(1000);


            AndroidElement Gender = driver.FindElementById("com.sadadpsp.eva:id/comboWidget_action1");
            Gender.Click();
            Thread.Sleep(2000);

            AndroidElement Mard = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout[2]/android.widget.RelativeLayout");
            Mard.Click();
            Thread.Sleep(2000);


            AndroidElement PeymentButtom = driver.FindElementById("com.sadadpsp.eva:id/widget_button_text");
            PeymentButtom.Click();
            Thread.Sleep(2000);


            TestHelper.Peyment(driver);




        }
    }
}
