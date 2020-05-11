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
    public class SearchSkillsFeatureSteps
    {
        [Given(@"I have clicked Search Skills Icon")]
        public void GivenIHaveClickedSearchSkillsIcon()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Search Skills - Catagories");

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
        
        [Given(@"I have Clicked on Catagory named  (.*)")]
        public void GivenIHaveClickedOnCatagoryNamedDigitalMarketing(string SelectCatagory)
        {
            try
            {
                Thread.Sleep(2000);

                // Click on catagory
                Driver.driver.FindElement(By.XPath("//a[@role='listitem'][contains(.,'" + SelectCatagory + "')]")).Click();

                Thread.Sleep(2000);

                // Print in Console
                Console.WriteLine("Passed - Clicked "+ SelectCatagory +" catagory succesfully");

                //Write Log reports 
                test.Log(LogStatus.Info, "Clicked "+ SelectCatagory +" catagory");

            }
            catch (Exception e)
            {
                // Code for Handling the exception
                Console.WriteLine("Failed - not Clicked "+ SelectCatagory +" catagory");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Cliked "+ SelectCatagory +" Catagory");

                //Write Log reports 
                test.Log(LogStatus.Info, "Not Cliked "+ SelectCatagory +" Catagory", e.Message);
            }
        }
        
        [Then(@"the user should be able to navigated to the (.*) (.*)")]
        public void ThenTheUserShouldBeAbleToNavigatedToThe(string SelectCatagory, string CatagoryUrl)
        {
            try
            {
                // Get current URL and store in a variable
                String catagoryUrl = Driver.driver.Url;
                string expectedurl = "http://192.168.99.100:5000/Home/Search?cat="+CatagoryUrl;

                // Validate if user had navigated to Prog & Tech Catagory page successfully (you can use any one of below 3 assertions)
                // Assert.That(catagoryUrl, Is.EqualTo("http://192.168.99.100:5000/Home/Search?cat="+CatagoryUrl));

                Assert.AreEqual(expectedurl, catagoryUrl);
                //Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//h3[contains(.,'Refine Results')]")).Text, "Refine Results");

                // Print in Console
                Console.WriteLine("Passed - Navigated to "+ SelectCatagory +" catagory page succesfully");

                //Write Log reports 
                test.Log(LogStatus.Info, "Navigated to "+SelectCatagory +" Catagory page ");
            }
            catch(Exception e)
            {
                // Code for Handling the exception
                Console.WriteLine("Failed - not taken user to "+ SelectCatagory +" Catagory page");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Navigated to "+SelectCatagory +" Catagory page");

                //Write Log reports 
                test.Log(LogStatus.Info, "Not Navigated to "+ SelectCatagory +" Catagory page ", e.Message);
            }
        }
    }
}
