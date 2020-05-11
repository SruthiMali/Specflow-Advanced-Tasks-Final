using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    [Binding]
    public class ReceivedRequests_ManagrRequests
    {
        [Given(@"I have Clicked Manage Requests tab")]
        public void GivenIHaveClickedManageRequestsTab()
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.Extent.StartTest("Manage Requests");

            //defining driver wait
            Driver.TurnOnWait(2000);

            // Click on Manage Requests link
            Driver.driver.FindElement(By.XPath("//div[@class='ui dropdown link item']")).Click();

            // Get current URL and store in a variable
            String CurrentUrl = Driver.driver.Url;

            // Print the Current Url in console
            Console.WriteLine(CurrentUrl);

            //defining driver wait
            Driver.TurnOnWait(2000);

            // Validate if user had navigated to Manage Requests page successfully
            if (CurrentUrl == "http://192.168.99.100:5000/Account/Profile")

            {
                Console.WriteLine("Passed - Manage Requests link takes user to Manage Requests page succesfully");
            }

            else
            {
                Console.WriteLine("Failed - Manage Requests link not taken user to Manage Requests page");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Navigated to Manage Requests page");

                //Write Log reports 
                test.Log(LogStatus.Info, "Test Failed ");
            }

            // Assertion on Manage Requests link current Url VS Expected Url
            Assert.That(CurrentUrl, Is.EqualTo("http://192.168.99.100:5000/Account/Profile"));

            //Write Log reports 
            test.Log(LogStatus.Info, "Clicked Manage Requests Link");

        }

        [Given(@"I have clicked Received Requests")]
        public void GivenIHaveClickedReceivedRequests()
        {
            try
            {
                // To mouse hover Manage Requests link using Actions
                Actions action1 = new Actions(Driver.driver);

                //Click on Received Requests
                action1.MoveToElement(Driver.driver.FindElement(By.XPath("//div[@class='ui dropdown link item']"))).MoveToElement(Driver.driver.FindElement(By.XPath("//a[@href='/Home/ReceivedRequest']"))).Click().Perform();

                // Print in Console
                Console.WriteLine("clicked Received Requests link");

                //Write Log reports 
                test.Log(LogStatus.Info, "Cliked Received requests link");
            }
            catch(Exception e)
            {
                // Print in Console
                Console.WriteLine("Unable to click Received Requests link");

                //Write Log reports 
                test.Log(LogStatus.Info, " Unable to Click Received requests link");
            }
        }
        
        
        [Then(@"the user should be able to navigate to Received Requests page")]
        public void ThenTheUserShouldBeAbleToNavigateToReceivedRequestsPage()
        {
            try
            {
                // Get current URL and store in a variable
                String ReceivedRequestCurrentUrl = Driver.driver.Url;

                // Validate if user had navigated to Received Requests page successfully
                if (ReceivedRequestCurrentUrl == "http://192.168.99.100:5000/Home/ReceivedRequest")

                {
                    // Print in Console
                    Console.WriteLine("Passed - Received Requests link takes user to Received Requests page succesfully");

                    //Write Log reports 
                    test.Log(LogStatus.Info, "Passed - Navigated to Received Requests page ");
                }
                else
                {
                    // Print in Console
                    Console.WriteLine("Failed - Received Requests link not taken user to Received Requests page");

                    //take screen shot and save with given name
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Navigated to Received Requests page");

                    //Write Log reports 
                    test.Log(LogStatus.Info, "Navigating to Received requests page - Failed ");
                }

            }
            catch (Exception e)
            {
                // Catch block 
                test.Log(LogStatus.Info, "Received Requests Test Failed ", e.Message);
            }
           
            // Assertion on Received Requests link current Url VS Expected Url
            //Assert.That(SentRequestCurrentUrl, Is.EqualTo("http://192.168.99.100:5000/Home/ReceivedRequest"));

            //Write Log reports 
            test.Log(LogStatus.Info, "Clicked Received Requests Link");
        }
    }
}
