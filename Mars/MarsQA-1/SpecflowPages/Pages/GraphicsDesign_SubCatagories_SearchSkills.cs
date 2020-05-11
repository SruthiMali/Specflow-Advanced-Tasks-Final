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
    public class GraphicsDesign_SubCatagories_SearchSkills
    {
        [Given(@"I have clicked on the Search Skills Icon")]
        public void GivenIHaveClickedOnTheSearchSkillsIcon()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Search Skills - Graphics & Design Link");

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
        
        [Given(@"I Clicked on Graphics & Design Catagory")]
        public void GivenIClickedOnGraphicsDesignCatagory()
        {
            try
            {
                // Click on Graphics & Design catagory
                Driver.driver.FindElement(By.XPath("//a[@role='listitem'][contains(.,'Graphics & Design')]")).Click();

                // Print in Console
                Console.WriteLine("Passed - Clicked Graphics & Design catagory succesfully");

                //Write Log reports 
                test.Log(LogStatus.Info, "Clicked Graphics & Design catagory");

            }
            catch (Exception e)
            {
                // Code for Handling the exception
                Console.WriteLine("Failed - not Clicked Graphics & Design catagory");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Cliked Graphics & Design Catagory");

                //Write Log reports 
                test.Log(LogStatus.Info, "Not Cliked Graphics & Design Catagory", e.Message);
            }
        }
        
        [Given(@"I Clicked on the GraphicsDesignSubCatagory (.*)")]
        public void GivenIClickedOnTheGraphicsDesignSubCatagory(string GraphicsDesignSubCatagory)
        {
            try
            {
                // Click on Sub catagory
                 Driver.driver.FindElement(By.XPath("//a[@role='listitem'][contains(.,'" + GraphicsDesignSubCatagory + "')]")).Click();

                Thread.Sleep(2000);

                // Print in Console
                Console.WriteLine("Passed - Clicked " + GraphicsDesignSubCatagory + " Subcatagory succesfully");

                //Write Log reports 
                test.Log(LogStatus.Info, "Clicked " + GraphicsDesignSubCatagory + " Subcatagory");

            }
            catch (Exception e)
            {
                // Code for Handling the exception
                Console.WriteLine("Failed - not Clicked " + GraphicsDesignSubCatagory + " Subcatagory");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Cliked " + GraphicsDesignSubCatagory + " SubCatagory");

                //Write Log reports 
                test.Log(LogStatus.Info, "Not Cliked " + GraphicsDesignSubCatagory + " SubCatagory", e.Message);
            }
        }
        
        [Then(@"user should be navigated to GraphicsDesignSubcatagory page (.*) (.*)")]
        public void ThenUserShouldBeNavigatedToGraphicsDesignSubcatagoryPage(string GraphicsDesignSubCatagory, int GraphicsDesignSubCatagoryUrl)
        {

            try
            {
                // Get current URL and store in a variable
                String catagoryUrl = Driver.driver.Url;
                string expectedurl = "http://192.168.99.100:5000/Home/Search?cat=GraphicsDesign&subcat=" + GraphicsDesignSubCatagoryUrl;

                // Validate if user had navigated to SubCatagories of Programming & Tech Catagory page successfully (you can use any one of below 3 assertions)
                // Assert.That(catagoryUrl, Is.EqualTo("http://192.168.99.100:5000/Home/Search?cat=GraphicsDesign&subcat="+GraphicsDesignSubCatagoryUrl));

                Assert.AreEqual(expectedurl, catagoryUrl);
                //Assert.AreEqual(GlobalDefinitions.driver.FindElement(By.XPath("//h3[contains(.,'Refine Results')]")).Text, "Refine Results");

                // Print in Console
                Console.WriteLine("Passed - Navigated to " + GraphicsDesignSubCatagoryUrl + " Subcatagory page succesfully");

                //Write Log reports 
                test.Log(LogStatus.Info, "Navigated to " + GraphicsDesignSubCatagoryUrl + " SubCatagory page ");
            }
            catch (Exception e)
            {
                // Code for Handling the exception
                Console.WriteLine("Failed - not taken user to " + GraphicsDesignSubCatagoryUrl + " SubCatagory page");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not Navigated to " + GraphicsDesignSubCatagoryUrl + " SubCatagory page");

                //Write Log reports 
                test.Log(LogStatus.Info, "Not Navigated to " + GraphicsDesignSubCatagoryUrl + " SubCatagory page ", e.Message);
            }
        }
    }
}
