using BDDTest.Set;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace BDDTest
{
    [Binding]
    public class MyHooks 
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        //options.PageLoadStrategy = PageLoadStrategy.Normal;
        //var cDriver = new ChromeDriver("", options, TimeSpan.FromHours(1));        
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            //  if (Driver == null)
            // {
            // Initialize();
            Console.WriteLine("Test Started");
          //  }
           // else throw new Exception("Couldn't initialize the Driver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
           
               // TearDown();
                Console.WriteLine("Test Completed");
           

            //TODO: implement logic that has to run after executing each scenario
        }

        //public void TearDown()
        //{

        //    if (Driver != null)
        //    {
        //        TearDown();
        //    }
        //    else throw new Exception("Error while trying to close the Driver");
        //    Driver.Quit();
        //}
    }
}
