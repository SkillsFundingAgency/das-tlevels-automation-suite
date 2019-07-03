﻿using System;
using TechTalk.SpecFlow;
using SFA.Tl.Matching.Automation.Tests.Project.Tests.Pages;
using OpenQA.Selenium;
using SFA.Tl.Matching.Automation.Tests.Project.Tests.TestSupport;
using SFA.Tl.Matching.Automation.Tests.Project.Framework.Helpers;

namespace SFA.Tl.Matching.Automation.Tests
{
    [Binding]
    public class LoginErrorMessagesSteps : BaseTest
    {
        [Given(@"I have navigated to the IDAMS login page")]
        public void GivenIHaveNavigatedToTheIDAMSLoginPage()
        {
            LoginHelpPage LoginHelpPage = new LoginHelpPage(webDriver);
            LoginHelpPage.ClickLogin();            
        }
        
        [Given(@"I only enter the username on the IDAMS login page")]
        public void GivenIOnlyEnterTheUsernameOnTheIDAMSLoginPage()
        {
            IDAMSLoginPage IDAMSLoginPage = new IDAMSLoginPage(webDriver);
            IDAMSLoginPage.IDAMSLoginUsernameOnly();
        }

        [Given(@"I only enter the password on the IDAMS login page")]
        public void GivenIOnlyEnterThePasswordOnTheIDAMSLoginPage()
        {
            IDAMSLoginPage IDAMSLoginPage = new IDAMSLoginPage(webDriver);
            IDAMSLoginPage.IDAMSLoginPasswordOnly();
        }
                  
        [Given(@"I enter an invalid username and password on the IDAMS login page")]
        public void GivenIEnterAnInvalidUsernameAndPasswordOnTheIDAMSLoginPage()
        {
            IDAMSLoginPage IDAMSLoginPage = new IDAMSLoginPage(webDriver);
            IDAMSLoginPage.IDAMSLogin(Constants.InvalidUser,Constants.InvalidPass);
        }
        
        [When(@"I press Login")]
        public void WhenIPressLogin()
        {
            IDAMSLoginPage IDAMSLoginPage = new IDAMSLoginPage(webDriver);
            IDAMSLoginPage.ClickLoginButton();
        }
        
        [Then(@"a warning will be displayed stating ""(.*)""")]
        public void ThenAWarningWillBeDisplayedStating(string WarningMessage)
        {
            IDAMSLoginPage IDAMSLoginPage = new IDAMSLoginPage(webDriver);
            IDAMSLoginPage.VerifyLoginErrorMessage(WarningMessage);
        }       
    }
}