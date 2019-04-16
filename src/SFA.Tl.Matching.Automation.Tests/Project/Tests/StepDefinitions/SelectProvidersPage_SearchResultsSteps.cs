﻿using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using SFA.Tl.Matching.Automation.Tests.Project.Framework.Helpers;
using SFA.Tl.Matching.Automation.Tests.Project.Tests.Pages;
using SFA.Tl.Matching.Automation.Tests.Project.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace SFA.Tl.Matching.Automation.Tests
{
    [Binding]
    public class SelectProvidersPage_SearchResultsSteps : BaseTest
    {
        [Given(@"I have entered new Skill Area as ""(.*)""")]
        public void GivenIHaveEnteredNewSkillAreaAs(string skillArea)
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.SelectSkillArea(skillArea);
        }
        
        [Given(@"Employer postcode as ""(.*)""")]
        public void GivenEmployerPostcodeAs(string postcode)
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.EnterPostcode(postcode);
        }
        
        [Given(@"Providers within as ""(.*)""")]
        public void GivenProvidersWithinAs(string postcodeRadius)
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.SelectPostcodeRadius(postcodeRadius);
        }
        
        [Then(@"the Select Providers page will display the postcode and skill area selected on the Find Providers page")]
        public void ThenTheSelectProvidersPageWillDisplayThePostcodeAndSkillAreaSelectedOnTheFindProvidersPage()
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.VerifyPostcodeDisplayed();
            selectProvidersPage.VerifySkillsetDisplayed();
            selectProvidersPage.VerifySearchRadius();
        }
        
        [Then(@"the Select Providers page will display (.*) results, skill area, postcode and radius in the H(.*) heading")]
        public void ThenTheSelectProvidersPageWillDisplayResultsSkillAreaPostcodeAndRadiusInTheHHeading(int p0, int p1)
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.VerifyPostcodeDisplayed();
            selectProvidersPage.VerifySkillsetDisplayed();
            selectProvidersPage.VerifyZeroResultsCount();
            selectProvidersPage.VerifySearchRadius();
        }

        [Then(@"the Select Providers page will display the count, skill area, postcode and radius in the H(.*) heading")]
        public void ThenTheSelectProvidersPageWillDisplayTheCountSkillAreaPostcodeAndRadiusInTheHHeading(int p0)
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.VerifyPostcodeDisplayed();
            selectProvidersPage.VerifySkillsetDisplayed();
            selectProvidersPage.VerifyResultsCount();
            selectProvidersPage.VerifySearchRadius();
        }

        [Then(@"the provider results returned will match the expected values")]
        public void ThenTheProviderResultsReturnedWillMatchTheExpectedValues()
        {
            //checks the providers returned by the SQL match the providers displayed on screen
            PageInteractionHelper.ValidateProvidersDisplayed();
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.VerifyResultsCount();           
        }

        [Given(@"I select some providers")]
        public void GivenISelectSomeProviders()
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.SelectProviders();
            Thread.Sleep(5000);
        }

        [When(@"I press the Continue button")]
        public void WhenIPressTheContinueButton()
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.ClickContinue();
        }

        [Given(@"I clear the postcode field on the Select providers page")]
        public void GivenIClearThePostcodeFieldOnTheSelectProvidersPage()
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.ClearPostcode();
        }

        [Then(@"I am shown an error for blank postcode stating ""(.*)""")]
        public void Iamshownanerrorforblankpostcodestating(string expectedErrorMessage)
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.VerifyPostcodeError(expectedErrorMessage);
        }

        [Then(@"I am shown an error for no provider selected stating ""(.*)""")]
        public void ThenIAmShownAnErrorForNoProviderSelectedStating(string expectedErrorMessage)
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
        }

        [Given(@"I enter an invalid postcode on the Select providers page")]
        public void GivenIEnterAnInvalidPostcodeOnTheSelectProvidersPage()
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.EnterPostcode("B98");
        }

        [Then(@"I am shown an error for invalid postcode stating ""(.*)""")]
        public void ThenIAmShownAnErrorForInvalidPostcodeStating(string expectedErrorMessage)
        {
            SelectProvidersPage selectProvidersPage = new SelectProvidersPage(webDriver);
            selectProvidersPage.VerifyInvalidPostcodeError(expectedErrorMessage); 
        }
    }
}
