using System;
using TechTalk.SpecFlow;
using MarsQA_1.Helpers;
using OpenQA.Selenium;
using NUnit.Framework;
using static MarsQA_1.Helpers.CommonMethods;
using RelevantCodes.ExtentReports;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    [Binding]
    public class AddDescription_Profile
    {
        [Given(@"I Added Description")]
        public void GivenIAddedDescription() 
        {
            //defining driver wait
            Driver.TurnOnWait(2000);
            
            // Click on Description Icon 
            Driver.driver.FindElement(By.XPath("//h3[contains(.,'Description')]/span")).Click();

            // Clear & Enter Description
            Driver.driver.FindElement(By.XPath("//textarea[@maxlength='600']")).Clear();
            Driver.driver.FindElement(By.XPath("//textarea[@maxlength='600']")).Clear();
            Driver.driver.FindElement(By.XPath("//textarea[@maxlength='600']")).Clear();
            Driver.driver.FindElement(By.XPath("//textarea[@maxlength='600']")).SendKeys("Hi");

            //Click on Save button
            Driver.driver.FindElement(By.XPath("//button[@type='button']")).Click();
        }

        [Then(@"that desccription should appear in profile page")]
        public void ThenThatDesccriptionShouldAppearInProfilePage()
        {
            
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Description");

                // Validate if user added description successfully
                string ExpectedValue = "Description has been saved successfully";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

                // Assert Condition for adding description Confirmation message
                if (ExpectedValue == ActualValue)
                {
                    // Print in Console
                    Console.WriteLine("Passed - user added description successfully");
  
                }
                else
                {
                    // Print in Console
                    Console.WriteLine("user not added description");
                }
                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "user added description");

                //Write Log reports 
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Description Successfully");


            }
            catch
            {
   
                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "user not added description");

                //Write Log reports 
                CommonMethods.test.Log(LogStatus.Pass, "Test Failed, Unable to Add Description");


            }

        }
    }
}
