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
    public class Delete_NO_ManageListings
    {
        [Given(@"I have clicked manage listings Delete button")]
        public void GivenIHaveClickedManageListingsDeleteButton()
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
        
        [When(@"I press No button")]
        public void WhenIPressNoButton()
        {
            //Click on NO button 
            Driver.driver.FindElement(By.XPath("//button[contains(.,'No')]")).Click();

            //write in console
            Console.WriteLine("Clicked NO button");

            //Write Log reports 
            CommonMethods.test.Log(LogStatus.Pass, "Clicked NO button Successfully");

        }
        
        [Then(@"the user should be navigated to the Manage listings page without deleting")]
        public void ThenTheUserShouldBeNavigatedToTheManageListingsPageWithoutDeleting()
        {
            try
            {
                //define driver wait
                Driver.TurnOnWait(5000);
                Thread.Sleep(2000);

                // Get current URL and store in a variable
                String ShareSkillCurrentUrl = Driver.driver.Url;

                // Print in Console
                Console.WriteLine(ShareSkillCurrentUrl);


                string ExpectedUrl = "http://192.168.99.100:5000/Home/ListingManagement";

                // Validate if user had navigated to Manage Listings page successfully
                if (ExpectedUrl == ShareSkillCurrentUrl)

                {
                    // Print in Console
                    Console.WriteLine("Passed - Managelistings No button takes user to manage listings page succesfully");

                    //Write Log reports 
                    test.Log(LogStatus.Info, "Navigated to  Manage listings page ");
                }
                else
                {
                    // Print in Console
                    Console.WriteLine("Failed -  Managelistings No button not taken user to manage listings page");


                    //take screen shot and save with given name
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, " Managelistings No button");

                    //Write Log reports 
                    test.Log(LogStatus.Info, "Navigating to manage listings page - Failed ");
                }

            }
            catch (Exception e)
            {
                // Catch block 
                test.Log(LogStatus.Info, "ManageListings DElete NO - Test Failed ", e.Message);

            }
        }
    }
}
