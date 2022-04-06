using CSharp_Instagram_Selenium.Common;
using CSharp_Instagram_Selenium.Hooks;
using CSharp_Instagram_Selenium.Pages;
using CSharp_Instagram_Selenium.Utils;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp_Instagram_Selenium.Tests
{
    class AccountInfoTest : DriverSetup
    {
        [Test, Order(0)]
        public void AccountInfo_Profile_Test()
        {
            //Login Info
            LoginPage _loginPage = new LoginPage(driver);
            Thread.Sleep(utils.timeDelay);
            _loginPage.EnterUsername(Constants.Email);
            Thread.Sleep(utils.timeDelay);
            _loginPage.EnterPassword(Constants.PassWord);
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickOnLogin();

            //Profile Info
            Thread.Sleep(utils.timeDelay);
            AccountInfoPage _accountInfoPage = new AccountInfoPage(driver);
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.ClickOnProfileIcon();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.ClickOnProfile();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.CheckOnProfileAssert().Should().Be("sqa.qups");

        }

        [Test, Order(1)]
        public void AccountInfo_Saved_Test()
        { 
            //Login Info
            LoginPage _loginPage = new LoginPage(driver);
            Thread.Sleep(utils.timeDelay);
            _loginPage.EnterUsername(Constants.Email);
            Thread.Sleep(utils.timeDelay);
            _loginPage.EnterPassword(Constants.PassWord);
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickOnLogin();

            //Saved Info
            Thread.Sleep(utils.timeDelay);
            AccountInfoPage _accountInfoPage = new AccountInfoPage(driver);
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.ClickOnProfileIcon();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.ClickOnSaved();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.CheckOnProfileAssert().Should().Be("sqa.qups");

        }

        [Test, Order(2)]
        public void AccountInfo_Settings_Test()
        {
            //Login Info
            LoginPage _loginPage = new LoginPage(driver);
            Thread.Sleep(utils.timeDelay);
            _loginPage.EnterUsername(Constants.Email);
            Thread.Sleep(utils.timeDelay);
            _loginPage.EnterPassword(Constants.PassWord);
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickOnLogin();

            //Settings Info
            Thread.Sleep(utils.timeDelay);
            AccountInfoPage _accountInfoPage = new AccountInfoPage(driver);
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.ClickOnProfileIcon();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.ClickOnSettings();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.CheckSettingsAssertion().Should().Be("sqa.qups");


        }

        [Test, Order(3)]
        public void AccountInfo_SwitchAccounts_Test()
        {
            //Login Info
            LoginPage _loginPage = new LoginPage(driver);
            Thread.Sleep(utils.timeDelay);
            _loginPage.EnterUsername(Constants.Email);
            Thread.Sleep(utils.timeDelay);
            _loginPage.EnterPassword(Constants.PassWord);
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickOnLogin();

            //Switch Account Info
            Thread.Sleep(utils.timeDelay);
            AccountInfoPage _accountInfoPage = new AccountInfoPage(driver);
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.ClickOnProfileIcon();
            Thread.Sleep(utils.timeDelay);
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.ClickOnSwitchAccount();
            Thread.Sleep(utils.timeDelay);

        }
    }
}
