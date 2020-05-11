using MarsQA_1.Helpers;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    [Binding]
    public class Delete_Yes_ManageListings
    {
        [Given(@"I have clicked the manage listings Delete button")]
        public void GivenIHaveClickedTheManageListingsDeleteButton()
        {
            //Start the Reports
            CommonMethods.ExtentReports();

            CommonMethods.test = CommonMethods.Extent.StartTest("Manage Listings");

            //Click on Managelistings link
            Driver.driver.FindElement(By.LinkText("Manage Listings")).Click();

            //Click on delete button 
            Driver.driver.FindElement(By.XPath("(//i[@class='remove icon'])[1]")).Click();

            //write in console
            Console.WriteLine("Clicked delete button");

            //Write Log reports 
            CommonMethods.test.Log(LogStatus.Pass, "Clicked delete button Successfully");
        }
        
        [When(@"I press Yes button")]
        public void WhenIPressYesButton()
        {
            //Click on Yes button 
            Driver.driver.FindElement(By.XPath("//button[contains(.,'Yes')]")).Click();

            //write in console
            Console.WriteLine("Clicked Yes button");

            //Write Log reports 
            CommonMethods.test.Log(LogStatus.Pass, "Clicked Yes button Successfully");
        }
        
        [Then(@"the user should be able to delete the Service list")]
        public void ThenTheUserShouldBeAbleToDeleteTheServiceList()
        {
            try
            {
                //define driver wait
                Driver.TurnOnWait(5000);
                Thread.Sleep(2000);

                // Get current URL and store in a variable
                String ActualConfirmationmessage = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner'][contains(.,'first has been deleted')]")).Text;

                string ExpectedConfirmationmessage = "first has been deleted";

                // Validate if user had navigated to Manage Listings page successfully
                if (ExpectedConfirmationmessage == ActualConfirmationmessage)

                {
                    // Print in Console
                    Console.WriteLine("Passed - Deleted manage listings record successfully");

                    //Write Log reports 
                    test.Log(LogStatus.Info, "Deleted manage listings record successfully ");
                }
                else
                {
                    // Print in Console
                    Console.WriteLine("Failed - unable to Delete manage listings record ");


                    //take screen shot and save with given name
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "shareskill YES button");

                    //Write Log reports 
                    test.Log(LogStatus.Info, "Failed - unable to Delete manage listings record ");
                }

            }
            catch (Exception e)
            {
                // Catch block 
                test.Log(LogStatus.Info, "ManageListings Delete Yes - Test Failed ", e.Message);

            }
        }
    }
}
