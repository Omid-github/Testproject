package Tests;

import org.testng.Assert;
import org.testng.annotations.*;
import java.net.MalformedURLException;
import java.net.URL;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.remote.CapabilityType;
import org.openqa.selenium.remote.DesiredCapabilities;
import org.openqa.selenium.remote.RemoteWebDriver;
import org.testng.annotations.Test;
import io.appium.java_client.MobileElement;
import io.appium.java_client.android.AndroidDriver;
import io.appium.java_client.remote.AndroidMobileCapabilityType;
import io.appium.java_client.remote.MobileCapabilityType;

public class baseClass  {
	
	
	public AndroidDriver driver;
	
	@BeforeTest
	public void setup() throws MalformedURLException, InterruptedException  {
		
		
		
		  DesiredCapabilities caps = new DesiredCapabilities();
		//caps.setCapability("platformName", "ANDROID");
          caps.setCapability( "platformName" , "Android");
          caps.setCapability("deviceName" ,"SM_A307FN");
          caps.setCapability("platformVersion" , "11");
          caps.setCapability("noReset" , "true");
          caps.setCapability("skipUnlock" , "false");
          
            //caps.setCapability(AndroidMobileCapabilityType.DONT_STOP_APP_ON_RESET, "true");
            // caps.setCapability(AndroidMobileCapabilityType.AUTO_LAUNCH, "false")
            //caps.setCapability("appWaitPackage" , "com.sec.android.app.popupcalculator");

//------------------------------------------------------------
//for NotInstalled Application--apk path
//caps.setCapability("app" , "");
          
          
//for Installed Application
caps.setCapability( "appPackage", "com.sec.android.app.popupcalculator");
caps.setCapability( "appActivity", "com.sec.android.app.popupcalculator.Calculator");

//caps.setCapability(MobileCapabilityType.NEW_COMMAND_TIMEOUT ,60);


 driver = new AndroidDriver(new URL("http://127.0.0.1:4723/wd/hub"), caps);
 Thread.sleep(5000);
//caps.setCapability(MobileCapabilityType.UDID , "");

 //driver = new RemoteWebDriver(new URL("https://127.0.0.1:4723/wd/hub"), caps);
	}
	
	
 @Test
 public void test() throws Exception {
    //locate the Text on the calculator by using By.name()
	 MobileElement el6 = (MobileElement) driver.findElementByAccessibilityId("9");
	 el6.click();
	 
     MobileElement el8 = (MobileElement) driver.findElementByAccessibilityId("Plus");
	el8.click();
	MobileElement el7 = (MobileElement) driver.findElementByAccessibilityId("3");
    el7.click();
	MobileElement el9 = (MobileElement) driver.findElementByAccessibilityId("Equal");
	el9.click();
	Thread.sleep(2000 );
    //locate the edit box of the calculator by using By.tagName()
	MobileElement result= (MobileElement) driver.findElementById("com.sec.android.app.popupcalculator:id/calc_edt_formula");
			 

	Assert.assertEquals(result.getText(), "12");
	 if(result.getText().equals("12"))
    {
        System.out.println("Test Passed...");
     }
     else
   {
        System.out.println("Test Failed...");
     }
 }




@AfterTest
 public void teardown(){
 	//close the app
 	driver.quit();
 }




//el6.click();


//el8.click();
	
	}
	
	

	
	

