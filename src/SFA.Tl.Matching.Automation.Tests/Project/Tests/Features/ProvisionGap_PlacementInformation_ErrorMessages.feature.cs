﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SFA.Tl.Matching.Automation.Tests.Project.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Report a provision gap - Error messages on the Placement Information page")]
    public partial class ReportAProvisionGap_ErrorMessagesOnThePlacementInformationPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ProvisionGap_PlacementInformation_ErrorMessages.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Report a provision gap - Error messages on the Placement Information page", "\tThis feature is used to confirm the error messages on the Placement information " +
                    "web page. ", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line 6
 testRunner.Given("I have navigated to the IDAMS login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.And("I have logged in as an Admin user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.And("I navigate to the Provision Gap Placement Information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Placement Information - Press continue without entering any data")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void PlacementInformation_PressContinueWithoutEnteringAnyData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Placement Information - Press continue without entering any data", null, new string[] {
                        "regression"});
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 12
 testRunner.Given("I clear the job field on the Placement Information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.And("I press Continue on the Placement Information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then("the Placement Information page will show an error stating \"You must tell us what " +
                    "specific job the placement student would do\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.And("the Placement Information page will display a no placement selected error stating" +
                    " \"You must tell us whether the employer knows how many placements they want at t" +
                    "his location\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Placement Information - Number of Placements field is shown only if Yes is select" +
            "ed")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void PlacementInformation_NumberOfPlacementsFieldIsShownOnlyIfYesIsSelected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Placement Information - Number of Placements field is shown only if Yes is select" +
                    "ed", null, new string[] {
                        "regression"});
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 19
 testRunner.Given("I select the No radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.Then("Number of Placements field is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Given("I select the Yes radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.Then("Number of Placements field is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Placement Information - Job type must be between 2 and 99 characters")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void PlacementInformation_JobTypeMustBeBetween2And99Characters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Placement Information - Job type must be between 2 and 99 characters", null, new string[] {
                        "regression"});
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 27
 testRunner.Given("I enter a job title 1 character long", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.And("I press Continue on the Placement Information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.Then("the Place Information page will show an error for job type not long enough statin" +
                    "g \"You must enter a job role using 2 or more characters\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.Given("I enter a job title longer than 99 characters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.And("I press Continue on the Placement Information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("the Place Information page will show an error for job type too long stating \"You " +
                    "must enter a job role using 99 characters or less\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Placement Information - Number of placements entered must be greater than 0")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void PlacementInformation_NumberOfPlacementsEnteredMustBeGreaterThan0()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Placement Information - Number of placements entered must be greater than 0", null, new string[] {
                        "regression"});
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 36
 testRunner.Given("I select the Yes radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.And("I enter 0 for the number of placements", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("I press Continue on the Placement Information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("the Place Information page will show an error for number of placements being too " +
                    "small stating \"The number of placements must be 1 or more\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Placement Information - Number of placements entered must be less than 1000")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void PlacementInformation_NumberOfPlacementsEnteredMustBeLessThan1000()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Placement Information - Number of placements entered must be less than 1000", null, new string[] {
                        "regression"});
#line 42
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 43
 testRunner.Given("I select the Yes radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
 testRunner.And("I enter 1000 for the number of placements", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("I press Continue on the Placement Information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.Then("the Place Information page will show an error for number of placements being too " +
                    "big stating \"The number of placements must be 999 or less\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Placement Information - Number of placements must be entered if the number of pla" +
            "cements field is visbile")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public virtual void PlacementInformation_NumberOfPlacementsMustBeEnteredIfTheNumberOfPlacementsFieldIsVisbile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Placement Information - Number of placements must be entered if the number of pla" +
                    "cements field is visbile", null, new string[] {
                        "regression"});
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 50
 testRunner.Given("I select the Yes radio button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.And("I press Continue on the Placement Information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.Then("the Place Information page will show an error for Placement number cannot be null" +
                    " stating \"You must estimate how many placements the employer wants at this locat" +
                    "ion\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
