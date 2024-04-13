using BDDTest.Set;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDTest.Pages
{
    public class LoginPage
    {
        private IWebDriver Driver { get; set; }

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public static string RelativeUrl => "/Account/MainPage";
        public static string Url => BaseTest.BaseUrl + RelativeUrl;

        public IWebElement Username => Driver.FindElement(UsernameBy);
        public By UsernameBy => By.Id("UserName");

        public IWebElement Password => Driver.FindElement(PasswordBy);
        public By PasswordBy => By.Id("Password");

        public IWebElement Submit => Driver.FindElement(SubmitBy);
        public By SubmitBy => By.XPath("//button[@type='button'  and @class='btn btn-lg btn-primary w-100 mb-5']");
        public static By AddMerchantBy => By.XPath("//a[@data-original-title='اضافه كردن پذیرنده']");

        public IWebElement AddMerchant => Driver.FindElement(AddMerchantBy);

    }
}
