using System;
using TechTalk.SpecFlow;
using MarsQA_1.Helpers; // in code we can directly use classes in helpers ex: instead of helpers.excellibhelper we use direct excellibhelper.readdata
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using AutoItX3Lib;
using static MarsQA_1.Helpers.CommonMethods; // so for log reports we can directly call test.log instead of commonmethods.test.log

namespace MarsQA_1.SpecflowPages.Pages
{
    [Binding]
    public class Add_ShareSkill
    {
        [Given(@"I Clicked on Shareskills button")]
        public void GivenIClickedOnShareskillsButton()
        {

            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.Extent.StartTest("ShareSkill");

            //Click on ShareSkill Button
            Driver.driver.FindElement(By.XPath("//a[@class='ui basic green button']")).Click();

            //Write log reports
            CommonMethods.test.Log(LogStatus.Info, "Clicked ShareSkill Button");
        }

        [Given(@"I have entered all the details")]
        public void GivenIHaveEnteredAllTheDetails()
        {
            try
            {
                //populate Excel Sheet
                Helpers.ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Share_Skill");

                //Define driver wait 
                Driver.TurnOnWait(2000);

                // Enter Title Field
                Driver.driver.FindElement(By.XPath("//input[@name='title']")).SendKeys(Helpers.ExcelLibHelper.ReadData(2, "Title"));

                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Entered Title");

                // Enter the Description in textbox
                Driver.driver.FindElement(By.XPath("//textarea[@name='description']")).SendKeys(Helpers.ExcelLibHelper.ReadData(2, "Description"));

                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Entered Description");

                /* Click on Category Dropdown
            CategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Graphics & Design")); */

                /* create select element object & select Catagory dropdown
                SelectElement SelectACatagory = new SelectElement(CategoryDropDown);
                SelectACatagory.SelectByText("Graphics & Design"); */

                // create select element object & select Catagory dropdown 
                SelectElement SelectACatagory = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name='categoryId']")));
                foreach (IWebElement element in SelectACatagory.Options)
                {
                    if (element.Text == Helpers.ExcelLibHelper.ReadData(2, "Category"))
                    {
                        element.Click();
                    }
                }

                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Selected Catagory Dropdown");

                /* create select element object & select sub Category Dropdown
           SelectElement SelectASubCatagory = new SelectElement(SubCategoryDropDown);
           SelectASubCatagory.SelectByText("Flyers & Brochures"); */


                //create select element object & select sub Category Dropdown
                SelectElement SelectASubCatagory = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name='subcategoryId']")));
                foreach (IWebElement element in SelectASubCatagory.Options)
                {
                    if (element.Text == Helpers.ExcelLibHelper.ReadData(2, "SubCategory"))
                    {
                        element.Click();
                    }
                }

                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Entered Sub Catagory Dropdown");

                //Using for loop to enter multiple tags - from excel file
                for (int i = 2; i < 10; i++)
                {
                    Actions action = new Actions(Driver.driver);
                    action.MoveToElement(Driver.driver.FindElement(By.XPath("//input[@aria-label='Add new tag'][1]"))).Click().Perform();
                    string TagsDataFromExcel = Helpers.ExcelLibHelper.ReadData(i, "Tags");
                    if (TagsDataFromExcel != null)
                    {
                        Driver.driver.FindElement(By.XPath("//input[@aria-label='Add new tag'][1]")).SendKeys(Helpers.ExcelLibHelper.ReadData(i, "Tags"));
                        Driver.driver.FindElement(By.XPath("//input[@aria-label='Add new tag'][1]")).SendKeys(Keys.Enter);

                    }

                }

                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Entered All the tags");

                //Select the Service type
                //Using if condition to take service type data from excel file
                if (Driver.driver.FindElement(By.XPath("//input[@name='locationType' and @value='0']")).Text.Equals(Helpers.ExcelLibHelper.ReadData(2, "Service Type")))
                {
                    //Select Hourly service
                    Driver.driver.FindElement(By.XPath("//input[@name='serviceType' and @value='0']")).Click();
                }
                else
                {
                    //Select one off service
                    Driver.driver.FindElement(By.XPath(" //input[@name='serviceType' and @value='1']")).Click();
 
                }

                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Selected Service Type");

                ////Select the Location type
                Driver.driver.FindElement(By.XPath("//input[@name='locationType' and @value='0']")).Click();
               
                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Selected LOcation Type");

                //Find the date time picker control and Fill date as dd/mm/yyyy as 30/03/2020
                Driver.driver.FindElement(By.XPath("//input[@name='startDate']")).SendKeys("30032030");
               
                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Entered Startdate");

                //Find the date time picker control and Fill date as dd/mm/yyyy as 30/03/2050
                Driver.driver.FindElement(By.XPath("//input[@name='endDate']")).SendKeys(Helpers.ExcelLibHelper.ReadData(2, "End date"));
               
                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Entered Enddate");

                //Click On available days
                Driver.driver.FindElement(By.XPath("//div[@class='ui checkbox'] /input[@index='1']")).Click();
                
                //Write log reports
                 CommonMethods.test.Log(LogStatus.Info, "Selected Available days");

                //Click on StartTime dropdown
                Driver.driver.FindElement(By.XPath("//input[@name='StartTime' and @index='1']")).SendKeys(Helpers.ExcelLibHelper.ReadData(2, "StartTime"));
               
                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Entered StartTime");

                // Click On EndTime Dropdown
                Driver.driver.FindElement(By.XPath("//input[@name='EndTime' and @index='1']")).SendKeys(Helpers.ExcelLibHelper.ReadData(2, "EndTime"));
                
                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Entered EndTime");

                //Click on Skill Trade option
                Driver.driver.FindElement(By.XPath("//input[@name='skillTrades' and  @value='true']")).Click();
                
                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Selected SkillTrade Option");

                // To mouse hover Skill Exchange Option using Actions
                Actions action1 = new Actions(Driver.driver);
                action1.MoveToElement(Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper'] //input[@aria-label='Add new tag']"))).Click().Perform();

                //Read Skill exchange data from excel file
                Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper'] //input[@aria-label='Add new tag']")).SendKeys(Helpers.ExcelLibHelper.ReadData(2, "Skill-Exchange"));
               
                //Pressing the enter key 
                Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper'] //input[@aria-label='Add new tag']")).SendKeys(Keys.Enter);
                
                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Selected Skill Exchange Option");

                //Click on Active/Hidden option
                Driver.driver.FindElement(By.XPath("//input[@name='isActive' and @value='true']")).Click();
                
                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Checked Active Option");

                //Upload Work Samples 2 ways 
                //Approach1 driver.fE(By.Xpath("Worksample upload button xpath").sendkeys("Path of file");
                //Approach2 AutoIT - download autoIT and add it in references ->Add reference in solution explorer

                // Click on Work Sample file upload button
                Driver.driver.FindElement(By.XPath("//i[@class='huge plus circle icon padding-25']")).Click();
                
                // AutoIt - Handles windows that do not belongs to browser
                AutoItX3 autoIt = new AutoItX3();

                ////To activate the window("open" is the window name for chrome. if u click upload file button from mozilla or IE, the window name is different
                autoIt.WinActivate("Open");  // https://www.youtube.com/watch?v=vmWmCw_8WsE

                //defining driver wait
                Driver.TurnOnWait(2000);
                Thread.Sleep(2000);

                // To Select file from a window 
                autoIt.Send(@"F:\Tasks\fileuploadsample.txt");

                //defining driver wait
                Driver.TurnOnWait(4000);
                Thread.Sleep(2000);


                // To press open button -- so the file will get uploaded
                autoIt.Send("{ENTER}");


                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "WorkSample File Uploaded");

                // Print in Console
                Console.WriteLine("user unable to enter all the Shareskill Details");

                //Write log reports
                CommonMethods.test.Log(LogStatus.Info, "Entered all the ShareSkill details");

            }
            catch
            {
                // Print in Console
                Console.WriteLine("Failed - unable to Enter all the ShareSkill details");

                //take screen shot and save with given name
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Not entered all details in shareSkill page ");

                //Write Log reports 
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed, unable to Enter all the ShareSkill details");
            }
        }

        [When(@"I press Save button")]
        public void WhenIPressSaveButton()
        {

            // Click On Save Button
            Driver.driver.FindElement(By.XPath("//input[@value='Save']")).Click();

            //Write log reports
            CommonMethods.test.Log(LogStatus.Info, "Clicked Save");
        }

        [Then(@"User should be navigated to Manage Requests Page")]
        public void ThenUserShouldBeNavigatedToManageRequestsPage()
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
                    Console.WriteLine("Passed - shareskill save  button takes user to manage listings page succesfully");

                    //Write Log reports 
                    test.Log(LogStatus.Info, "Navigated to  Manage listings page ");
                }
                else
                {
                    // Print in Console
                    Console.WriteLine("Failed - shareskill save button not taken user to manage listings page");


                    //take screen shot and save with given name
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "shareskill save button");

                    //Write Log reports 
                    test.Log(LogStatus.Info, "Navigating to manage listings page - Failed ");
                }

            }
            catch(Exception e)
            {
                // Catch block 
                test.Log(LogStatus.Info, "shareskill - Test Failed ", e.Message);

            }
        }
    }
}
