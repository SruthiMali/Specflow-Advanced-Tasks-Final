using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    [Binding]
    public class ChangePassword
    {
        
        [Given(@"I Changed Password")]
        public void GivenIChangedPassword()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Change Password");

                //defining driver wait
                //CommonMethods.Wait(2000);

                Thread.Sleep(5000);

                // To mouse hover username/Hi Sruthi link using Actions & click change password
                //Actions action2 = new Actions(Driver.driver);
               // action2.MoveToElement(Driver.driver.FindElement(By.XPath("//span[@tabindex='0']"))).MoveToElement(Driver.driver.FindElement(By.XPath("//a[contains(text(),'Change Password')]"))).Click().Build().Perform();

               // without actions Clicking change password link
                // Username.Click();
                Driver.driver.FindElement(By.XPath("//span[@tabindex='0']")).Click();

                // using for loop to click down arrow for 2 times
                for (int i = 0; i < 2; i++)
                {

                    Driver.driver.FindElement(By.XPath("//span[@tabindex='0']")).SendKeys(Keys.ArrowDown);
                } 

                // Click on Change Password
                Driver.driver.FindElement(By.XPath("//a[contains(text(),'Change Password')]")).Click(); 

                Thread.Sleep(5000);

                //Populate the excel data
                Helpers.ExcelLibHelper.PopulateInCollection(@"F:\Tasks\Mars\MarsQA-1\SpecflowTests\Data\TestData.xlsx", "SignUp");

                // Enter current password 
                Driver.driver.FindElement(By.XPath("//input[@name='oldPassword']")).SendKeys(Helpers.ExcelLibHelper.ReadData(2, "Password"));

                // Enter New password 
                Driver.driver.FindElement(By.XPath("//input[@name='newPassword']")).SendKeys(Helpers.ExcelLibHelper.ReadData(2, "Password"));

                //Enter Confirm Password
                Driver.driver.FindElement(By.XPath("//input[@name='confirmPassword']")).SendKeys(Helpers.ExcelLibHelper.ReadData(2, "ConfirmPswd"));

                // Click on Change password save button
                Driver.driver.FindElement(By.XPath("//button[@type='button'][contains(.,'Save')]")).Click();

                // Print in Console
                Console.WriteLine("Passed - user changed password successfully");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "user Changed Password");

                //Write Log reports 
                CommonMethods.test.Log(LogStatus.Info, "Test Passed, user changed password Successfully");
            }
            catch
            {
                // Print in Console
                Console.WriteLine("Passed - user unable to change password");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Changed Password");

                //Write Log reports 
                CommonMethods.test.Log(LogStatus.Info, "Test Failed, user unable to change password");
            }

           
        }

        [Then(@"User should be able to Login with new Password")]
        public void ThenUserShouldBeAbleToLoginWithNewPassword()
        {
            try
            {
                //Close the driver
                Driver.driver.Close();

                //launch the browser (Calling Initialize method in Driver Helpers -> Class)
                Driver D = new Driver();
                D.Initialize();

                //Populate Excel sheet 
                ExcelLibHelper.PopulateInCollection(@"F:\Tasks\Mars\MarsQA-1\SpecflowTests\Data\TestData.xlsx", "SignIn");

                //Call the Signinstep Method from Signin Class
                SignIn.SigninStep();

                // Print in Console
                Console.WriteLine("Passed - user able to login with new password");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "user able to login with new password");

                //Write Log reports 
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, User able to login withnew password Successfully");
            }
            catch(Exception e)
            {
                // Print in Console
                Console.WriteLine("Failed - user unable to login with new password");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "user unable to login with new password");

                //Write Log reports 
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed, unable to Logged in with new Password");
            }
            
        }
    }
}
