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
    public class ProgrammingTech_SubCatagories_SearchSkills
    {
        [Given(@"I have clicked the Search Skills Icon")]
        public void GivenIHaveClickedTheSearchSkillsIcon()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Search Skills - SubCatagories");

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
            catch(Exception e)
            {
                // Code for Handling the exception
                Console.WriteLine("Failed - not taken user to Search Skills page");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Navigated to Search Skills page");

                //Write Log reports 
                test.Log(LogStatus.Info, "Not Navigated to Search Skills page ", e.Message);
            }
        }
        
        [Given(@"I Clicked on Programming & Tech Catagory")]
        public void GivenIClickedOnProgrammingTechCatagory()
        {
            try
            {
                Thread.Sleep(2000);

                // Click on Programming & Tech catagory
                Driver.driver.FindElement(By.XPath("//a[@role='listitem'][contains(.,'Programming & Tech')]")).Click();

                Thread.Sleep(2000);

                // Print in Console
                Console.WriteLine("Passed - Clicked Programming & Tech catagory succesfully");

                //Write Log reports 
                test.Log(LogStatus.Info, "Clicked Programming & Tech catagory");

            }
            catch (Exception e)
            {
                // Code for Handling the exception
                Console.WriteLine("Failed - not Clicked Programming & Tech catagory");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Cliked Programming & Tech Catagory");

                //Write Log reports 
                test.Log(LogStatus.Info, "Not Cliked Programming & Tech Catagory", e.Message);
            }
        }
        
        [Given(@"I Clicked on SubCatagory (.*)")]
        public void GivenIClickedOnSubCatagory(string SelectSubCatagory)
        {
            try
            {
                // Click on Sub catagory
                //Driver.driver.FindElement(By.XPath("(//a[@role='listitem'])["+SelectSubCatagory+"]")).Click();

                Driver.driver.FindElement(By.XPath("//a[@role='listitem'][contains(.,'" + SelectSubCatagory + "')]")).Click();

                Thread.Sleep(2000);

                // Print in Console
                Console.WriteLine("Passed - Clicked "+ SelectSubCatagory + " Subcatagory succesfully");

                //Write Log reports 
                test.Log(LogStatus.Info, "Clicked "+ SelectSubCatagory + " Subcatagory");

            }
            catch (Exception e)
            {
                // Code for Handling the exception
                Console.WriteLine("Failed - not Clicked "+ SelectSubCatagory + " Subcatagory");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Cliked "+ SelectSubCatagory + " SubCatagory");

                //Write Log reports 
                test.Log(LogStatus.Info, "Not Cliked "+ SelectSubCatagory + " SubCatagory", e.Message);
            }
        }
        
        [Then(@"user should be navigated to Subcatagory page (.*) (.*)")]
        public void ThenUserShouldBeNavigatedToSubcatagoryPageWordPress(string SubCatagory, string SubCatagoryURL)
        {
            try
            {
                // Get current URL and store in a variable
                String catagoryUrl = Driver.driver.Url;
                string expectedurl = "http://192.168.99.100:5000/Home/Search?cat=ProgrammingTech&" + SubCatagoryURL;

                // Validate if user had navigated to SubCatagories of Programming & Tech Catagory page successfully (you can use any one of below 3 assertions)
                // Assert.That(catagoryUrl, Is.EqualTo("http://192.168.99.100:5000/Home/Search?cat=ProgrammingTech&"+SubCatagoryURL));

                Assert.AreEqual(expectedurl, catagoryUrl);
                //Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//h3[contains(.,'Refine Results')]")).Text, "Refine Results");

                // Print in Console
                Console.WriteLine("Passed - Navigated to " + SubCatagory + " Subcatagory page succesfully");

                //Write Log reports 
                test.Log(LogStatus.Info, "Navigated to " + SubCatagory + " SubCatagory page ");
            }
            catch (Exception e)
            {
                // Code for Handling the exception
                Console.WriteLine("Failed - not taken user to " + SubCatagory + " SubCatagory page");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Navigated to " + SubCatagory + " SubCatagory page");

                //Write Log reports 
                test.Log(LogStatus.Info, "Not Navigated to " + SubCatagory + " SubCatagory page ", e.Message);
            }
        }
    }
}
