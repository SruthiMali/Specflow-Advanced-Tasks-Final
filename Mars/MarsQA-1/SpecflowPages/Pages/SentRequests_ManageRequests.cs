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
    public class SentRequests_ManagrRequests
    {
        [Given(@"I have Clicked the Manage Requests tab")]
        public void GivenIHaveClickedTheManageRequestsTab()
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.Extent.StartTest("Sent Requests - Manage Requests");

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
                CommonMethods.test.Log(LogStatus.Info, "Test Failed ");
            }

            // Assertion on Manage Requests link current Url VS Expected Url
            Assert.That(CurrentUrl, Is.EqualTo("http://192.168.99.100:5000/Account/Profile"));

            //Write Log reports 
            test.Log(LogStatus.Info, "Clicked Manage Requests Link");

        }

        [Given(@"I have clicked Sent Requests link")]
        public void GivenIHaveClickedSentRequestsLink()
        {
            try
            {
                // To mouse hover Manage Requests link using Actions
                Actions action = new Actions(Driver.driver);

                //Click on Sent Requests
                action.MoveToElement(Driver.driver.FindElement(By.XPath("//div[@class='ui dropdown link item']"))).MoveToElement(Driver.driver.FindElement(By.XPath("//a[contains(.,'Sent Requests')]"))).Click().Perform();

                // Print in Console
                Console.WriteLine("clicked Sent Requests link");

                //Write Log reports 
                test.Log(LogStatus.Info, "Cliked Sent requests link");
            }
            catch(Exception e)
            {
                // Print in Console
                Console.WriteLine("Unable to click Sent Requests link");

                //Write Log reports 
                test.Log(LogStatus.Info, " Unable to Click Sent requests link");
            }
        }
        
        [Then(@"the user should be able to navigate to the Received Requests page")]
        public void ThenTheUserShouldBeAbleToNavigateToTheReceivedRequestsPage()
        {
            try
            {
                // Get current URL and store in a variable
                String SentRequestCurrentUrl = Driver.driver.Url;

                // Print in Console
                Console.WriteLine(SentRequestCurrentUrl);

                // Validate if user had navigated to Sent Requests page successfully
                if (SentRequestCurrentUrl == "http://192.168.99.100:5000/Home/SentRequest")

                {
                    // Print in Console
                    Console.WriteLine("Passed - Sent Requests link takes user to Sent Requests page succesfully");

                    //Write Log reports 
                    test.Log(LogStatus.Info, "Navigated to Sent Requests page ");
                }
                else
                {
                    // Print in Console
                    Console.WriteLine("Failed - Sent Requests link not taken user to Sent Requests page");

                    //take screen shot and save with given name
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Navigated to Sent Requests page");

                    //Write Log reports 
                    test.Log(LogStatus.Info, "Sent Requests Test Failed ");
                }

            }
            catch(Exception e)
            {
                // Catch block to handle errors
                test.Log(LogStatus.Info, "Sent Requests Test Failed ", e.Message);
            }

            // Assertion on Received Requests link current Url VS Expected Url
            //Assert.That(SentRequestCurrentUrl, Is.EqualTo("http://192.168.99.100:5000/Home/SentRequest"));

            //Write Log reports 
            test.Log(LogStatus.Info, "Clicked Sent Requests Link");

        }
    }
}
