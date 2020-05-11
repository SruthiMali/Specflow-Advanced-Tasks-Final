using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    [Binding]
    public class AllCatagoriesLink_SearchSkills
    {
        [Given(@"I Clicked Search Skills Icon")]
        public void GivenIClickedSearchSkillsIcon()
        {
            try
            {
                //Start the Reports
               CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Search Skills - All Catagories Link");

                //defining driver wait
                Driver.TurnOnWait(2000);

                // Click on Search Skill Icon
                Driver.driver.FindElement(By.XPath("//i[@class='search link icon']")).Click();

                // Get current URL and store in a variable
                String SearchSkillspageUrl = Driver.driver.Url;
                string expectedurl = "http://192.168.99.100:5000/Home/Search?searchString=";

                // Validate if user had navigated to Search skills page successfully (you can use any one of below 3 assertions)
                Assert.That(SearchSkillspageUrl, Is.EqualTo("http://192.168.99.100:5000/Home/Search?searchString="));

                //Assert.AreEqual(expectedurl, SearchSkillspageUrl);
                //Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//h3[contains(.,'Refine Results')]")).Text, "Refine Results");

                // Print in Console
                Console.WriteLine("Passed - Search Skills link takes user to Search Skills page succesfully");

                //Write Log reports 
                CommonMethods.test.Log(LogStatus.Info, "Navigated to Search Skills page ");
            }
            catch (Exception e)
            {
                // Code for Handling the exception
                Console.WriteLine("Failed - not taken user to Search Skills page");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Navigated to Search Skills page");

                //Write Log reports 
                test.Log(LogStatus.Info, "Not Navigated to Search Skills page ", e.Message);
            }
        
    }
        
        [Given(@"I Clicked All Catagories Link")]
        public void GivenIClickedAllCatagoriesLink()
        {
            try
            {

                // Click on All Categories Link
                Driver.driver.FindElement(By.XPath("//a[@role='listitem'][contains(.,'All Categories')]")).Click();

                // Print in Console
                Console.WriteLine("Passed - Clicked All Categories Link succesfully");

                //Write Log reports 
                test.Log(LogStatus.Info, "Clicked All Categories Link");

            }
            catch (Exception e)
            {
                // Code for Handling the exception
                Console.WriteLine("Failed - not Clicked All Categories Link");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Cliked All Categories Link");

                //Write Log reports 
                test.Log(LogStatus.Info, "Not Cliked All Categories Link", e.Message);
            }
        }
        
        [Then(@"user should be navigated to all catagories search results page")]
        public void ThenUserShouldBeNavigatedToAllCatagoriesSearchResultsPage()
        {
            try
            {
                // Get current URL and store in a variable
                String catagoryUrl = Driver.driver.Url;
                string expectedurl = "http://192.168.99.100:5000/Home/Search?";

                // Validate if user had navigated to All Categories page successfully (you can use any one of below 3 assertions)
                // Assert.That(catagoryUrl, Is.EqualTo("http://192.168.99.100:5000/Home/Search?"));

                Assert.AreEqual(expectedurl, catagoryUrl);
                //Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//h3[contains(.,'Refine Results')]")).Text, "Refine Results");

                // Print in Console
                Console.WriteLine("Passed - Navigated to All Categories page succesfully");

                //Write Log reports 
                test.Log(LogStatus.Info, "Navigated to All Categories page ");
            }
            catch (Exception e)
            {
                // Code for Handling the exception
                Console.WriteLine("Failed - not taken user to All Categories page");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Navigated to All Categories page");

                //Write Log reports 
                test.Log(LogStatus.Info, "Not Navigated to All Categories page ", e.Message);
            }
        }
    }
}
