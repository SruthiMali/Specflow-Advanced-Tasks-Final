﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MarsQA_1.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SearchSkillsFeature")]
    public partial class SearchSkillsFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SearchSkillsFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SearchSkillsFeature", "\tIn order to Search Skills\r\n\tI want to search by catagories and subcatagories", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if the user is able to click All Catagories link")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void CheckIfTheUserIsAbleToClickAllCatagoriesLink()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if the user is able to click All Catagories link", new string[] {
                        "mytag"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I Clicked Search Skills Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I Clicked All Catagories Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.Then("user should be navigated to all catagories search results page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if the user is able to Search Skills by Catagories")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("Digital Marketing", "DigitalMarketing", null)]
        [NUnit.Framework.TestCaseAttribute("Graphics & Design", "GraphicsDesign", null)]
        [NUnit.Framework.TestCaseAttribute("Programming & Tech", "ProgrammingTech", null)]
        [NUnit.Framework.TestCaseAttribute("Writing & Translation", "WritingTranslation", null)]
        [NUnit.Framework.TestCaseAttribute("Video & Animation", "VideoAnimation", null)]
        [NUnit.Framework.TestCaseAttribute("Music & Audio", "MusicAudio", null)]
        [NUnit.Framework.TestCaseAttribute("Fun & Lifestyle", "FunLifestyle", null)]
        [NUnit.Framework.TestCaseAttribute("Business", "Business", null)]
        public virtual void CheckIfTheUserIsAbleToSearchSkillsByCatagories(string selectCatagory, string catagoryUrl, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if the user is able to Search Skills by Catagories", @__tags);
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("I have clicked Search Skills Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.And(string.Format("I have Clicked on Catagory named  {0}", selectCatagory), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then(string.Format("the user should be able to navigated to the {0} {1}", selectCatagory, catagoryUrl), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if the user is able to Seach Programming & Tech SubCatagories")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("WordPress", "subcat=1", null)]
        [NUnit.Framework.TestCaseAttribute("Web & Mobile App", "subcat=2", null)]
        [NUnit.Framework.TestCaseAttribute("Data Analysis & Reports", "subcat=3", null)]
        [NUnit.Framework.TestCaseAttribute("QA", "subcat=4", null)]
        public virtual void CheckIfTheUserIsAbleToSeachProgrammingTechSubCatagories(string selectSubCatagory, string subCatagoryURL, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if the user is able to Seach Programming & Tech SubCatagories", @__tags);
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("I have clicked the Search Skills Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.And("I Clicked on Programming & Tech Catagory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And(string.Format("I Clicked on SubCatagory {0}", selectSubCatagory), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.Then(string.Format("user should be navigated to Subcatagory page {0} {1}", selectSubCatagory, subCatagoryURL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if the user is able to Search all Graphics & Design SubCatagories")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("Logo Design", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Book & Album covers", "2", null)]
        [NUnit.Framework.TestCaseAttribute("Flyers & Brochures", "3", null)]
        [NUnit.Framework.TestCaseAttribute("Web & Mobile Design", "4", null)]
        [NUnit.Framework.TestCaseAttribute("Search & Display Marketing", "5", null)]
        public virtual void CheckIfTheUserIsAbleToSearchAllGraphicsDesignSubCatagories(string graphicsDesignSubCatagory, string graphicsDesignSubCatagoryUrl, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if the user is able to Search all Graphics & Design SubCatagories", @__tags);
#line 46
this.ScenarioSetup(scenarioInfo);
#line 47
 testRunner.Given("I have clicked on the Search Skills Icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.And("I Clicked on Graphics & Design Catagory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And(string.Format("I Clicked on the GraphicsDesignSubCatagory {0}", graphicsDesignSubCatagory), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.Then(string.Format("user should be navigated to GraphicsDesignSubcatagory page {0} {1}", graphicsDesignSubCatagory, graphicsDesignSubCatagoryUrl), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

