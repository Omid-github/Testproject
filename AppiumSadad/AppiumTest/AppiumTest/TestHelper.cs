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
    public class TestHelper
    {
        public static AndroidDriver<AndroidElement> SetupIvaPre_Operation()
        {



            var cap = new AppiumOptions();

            cap.AddAdditionalCapability("platformName", "Android");
            cap.AddAdditionalCapability("deviceName", "HUAWEI Y6 Prime 2019");
            cap.AddAdditionalCapability("PlatformVersion", "9");
            cap.AddAdditionalCapability("Udid", "A2C6R20507017513");
            cap.AddAdditionalCapability("NoReset", "true");


            cap.AddAdditionalCapability("appPackage", "com.sadadpsp.eva");
            cap.AddAdditionalCapability("appActivity", "com.sadadpsp.eva.view.activity.LogonActivity");



            cap.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, "200000");
           // cap.AddAdditionalCapability("chromedriverExecutable", @"C:\\chromedriver.exe");
            var driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
            Thread.Sleep(5000);

            var contexts = ((IContextAware)driver).Contexts;
            string webviewContext = null;
            for (var i = 0; i < contexts.Count; i++)
            {

                Console.WriteLine(contexts[i]);
                if (contexts[i].Contains("WEBVIEW"))
                {

                    webviewContext = contexts[i];
                    break;

                }

            }
                ((IContextAware)driver).Context = webviewContext;
            return driver;


        }
        public static void LoginPre_Operation(AppiumDriver<AndroidElement> driver)
        {
            Thread.Sleep(1000);

            AndroidElement Vorod = driver.FindElementById("com.sadadpsp.eva:id/widget_button_layout");
            Vorod.Click();
            Thread.Sleep(1000);


            AndroidElement ImportPhoneNumber = driver.FindElementById("com.sadadpsp.eva:id/editTextWidget_editText");
            ImportPhoneNumber.Click();
            Thread.Sleep(1000);
            ImportPhoneNumber.SendKeys("09190260221");
            Thread.Sleep(1000);

            AndroidElement Otp = driver.FindElementById("com.sadadpsp.eva:id/widget_button_layout");
            Otp.Click();
            Thread.Sleep(15000);

           // AndroidElement Allow = driver.FindElementById("com.google.android.gms:id/positive_button");
           // Allow.Click();
           // Thread.Sleep(1000);


            AndroidElement EdameButton = driver.FindElementById("com.sadadpsp.eva:id/widget_button_layout");
            EdameButton.Click();
            Thread.Sleep(3000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

            AndroidElement ChengeLoge = (AndroidElement)wait.Until(ExpectedConditions.ElementIsVisible(By.Id("com.sadadpsp.eva:id/fragment_dialog_popup_next")));
            ChengeLoge.Click();
            Thread.Sleep(2000);

            AndroidElement ChengeLoge1 = driver.FindElementById("com.sadadpsp.eva:id/fragment_dialog_popup_check");
            ChengeLoge1.Click();
            Thread.Sleep(1000);

        }
        public static AndroidDriver<AndroidElement> SetupIvaOperation()
        {

            var AppPath = @"C:\Users\hpirhayati\Desktop\AppiumTestChekMeli\iva_BazaarProductionHostRelease_2.9.4-protected.apk";


            var cap = new AppiumOptions();

            cap.AddAdditionalCapability("platformName", "Android");
            cap.AddAdditionalCapability("deviceName", "HUAWEI Y6 Prime 2019");
            cap.AddAdditionalCapability("PlatformVersion", "9");
            cap.AddAdditionalCapability("Udid", "A2C6R20507017513");
            cap.AddAdditionalCapability("NoReset", "true");
            cap.AddAdditionalCapability(MobileCapabilityType.App, AppPath);


            cap.AddAdditionalCapability("appPackage", "com.sadadpsp.eva");
            cap.AddAdditionalCapability("appActivity", "com.sadadpsp.eva.view.activity.LogonActivity");



            cap.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, "200000");

            var driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

            Thread.Sleep(10000);
            var contexts = ((IContextAware)driver).Contexts;
            string webviewContext = null;
            for (var i = 0; i < contexts.Count; i++)
            {

                Console.WriteLine(contexts[i]);
                if (contexts[i].Contains("WEBVIEW"))
                {

                    webviewContext = contexts[i];
                    break;

                }

            }
            ((IContextAware)driver).Context = webviewContext;
            return driver;


        }
        public static void LoginOperation(AppiumDriver<AndroidElement> driver)
        {


            AndroidElement Vorod = driver.FindElementById("com.sadadpsp.eva:id/widget_button_layout");
            Vorod.Click();
            Thread.Sleep(3000);


            AndroidElement ImportPhoneNumber = driver.FindElementById("com.sadadpsp.eva:id/editTextWidget_editText");
            ImportPhoneNumber.Click();
            Thread.Sleep(3000);
            ImportPhoneNumber.SendKeys("09376504899");
            Thread.Sleep(3000);

            AndroidElement Otp = driver.FindElementById("com.sadadpsp.eva:id/widget_button_layout");
            Otp.Click();
            Thread.Sleep(11000);

            //AndroidElement Allow = driver.FindElementById("com.google.android.gms:id/positive_button");
            //Allow.Click();
            //Thread.Sleep(1000);


            AndroidElement EdameButton = driver.FindElementById("com.sadadpsp.eva:id/widget_button_layout");
            EdameButton.Click();
            Thread.Sleep(3000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

            AndroidElement ChengeLoge = (AndroidElement)wait.Until(ExpectedConditions.ElementIsVisible(By.Id("com.sadadpsp.eva:id/fragment_dialog_popup_next")));
            ChengeLoge.Click();
            Thread.Sleep(2000);

            AndroidElement ChengeLoge1 = driver.FindElementById("com.sadadpsp.eva:id/fragment_dialog_popup_check");
            ChengeLoge1.Click();
            Thread.Sleep(1000);

        }
        public static void Peyment(AppiumDriver<AndroidElement> driver)
        {
            AndroidElement CardNumber = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/androidx.viewpager.widget.ViewPager/android.view.ViewGroup/android.widget.LinearLayout[1]/android.view.ViewGroup/android.widget.ImageView");
            CardNumber.Click();
            Thread.Sleep(1000);

            AndroidElement SelectCard = driver.FindElementById("com.sadadpsp.eva:id/constraint");
            SelectCard.Click();
            Thread.Sleep(1000);

            AndroidElement Cvv2 = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/androidx.viewpager.widget.ViewPager/android.view.ViewGroup/android.widget.LinearLayout[2]/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
            Cvv2.Click();
            Cvv2.SendKeys("6234");
            Thread.Sleep(1000);

            int startwidth, startheight, endwidth, endheight;

            startwidth = 355;
            startheight = 700;

            endwidth = 355;
            endheight = 192;

            new TouchAction((IPerformsTouchActions)driver)
            .Press(startwidth, startheight).Wait(2000).MoveTo(endwidth, endheight).Release().Perform();
            Thread.Sleep(2000);

            AndroidElement Pin2 = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/androidx.viewpager.widget.ViewPager/android.view.ViewGroup/android.widget.LinearLayout[3]/android.view.ViewGroup/android.widget.LinearLayout[2]/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.EditText");
            Pin2.Click();
            Pin2.SendKeys("03040506");
            Thread.Sleep(1000);


            AndroidElement PeymentButtom2 = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/androidx.viewpager.widget.ViewPager/android.view.ViewGroup/android.widget.LinearLayout[4]/android.view.ViewGroup");
            PeymentButtom2.Click();
            Thread.Sleep(8000);

            AndroidElement ShareButtom = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.LinearLayout[1]/android.view.ViewGroup/android.widget.TextView");
            ShareButtom.Click();
            Thread.Sleep(1000);

            AndroidElement MatneSadeh = driver.FindElementById("com.sadadpsp.eva:id/ivShareText");
            MatneSadeh.Click();
            Thread.Sleep(1000);

            AndroidElement Cancel = driver.FindElementById("com.huawei.android.internal.app:id/button_cancel");
            Cancel.Click();
            Thread.Sleep(1000);

            AndroidElement BackButtom = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.LinearLayout[2]/android.view.ViewGroup");
            BackButtom.Click();
            Thread.Sleep(3000);


        }
        public static void Loguot(AppiumDriver<AndroidElement> driver)
        {
            AndroidElement BishtarButtom = driver.FindElementByXPath("//android.widget.FrameLayout[@content-desc=\"بیشتر\"]/android.widget.ImageView");
            BishtarButtom.Click();
            Thread.Sleep(1000);

            int startwidth, startheight, endwidth, endheight;

            startwidth = 200;
            startheight = 1150;

            endwidth = 200;
            endheight = 630;

            new TouchAction((IPerformsTouchActions)driver)
            .Press(startwidth, startheight).Wait(2000).MoveTo(endwidth, endheight).Release().Perform();
            Thread.Sleep(2000);

            AndroidElement Exit = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout[9]/android.view.ViewGroup");
            Exit.Click();
            Thread.Sleep(1000);

            AndroidElement Accept = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.LinearLayout[2]/android.view.ViewGroup");
            Accept.Click();
            Thread.Sleep(1000);
        }

    }
}