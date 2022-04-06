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
    public class SettingsTest : DriverSetup
    {   
        [Test, Order(0)]
        public void Change_Password_Test()
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
            _accountInfoPage.ClickOnSettings();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.CheckSettingsAssertion().Should().Be("sqa.qups");
           
           //Change Password Info
            Thread.Sleep(utils.timeDelay);
            SettingsPage _settingsPage = new SettingsPage(driver);
            _settingsPage.ClickOnChangePassword();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.EnterOldPassword("Xyz1234");
            Thread.Sleep(utils.timeDelay);
            _settingsPage.EnterNewPassword("Abcd1234");
            Thread.Sleep(utils.timeDelay);
            _settingsPage.EnterCnfrmNewPassword("Abcd1234");
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnChangePasswordButton();
            Thread.Sleep(utils.timeDelay);
        }

        [Test, Order(1)]
        public void Apps_Website_Test()
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
            _accountInfoPage.ClickOnSettings();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.CheckSettingsAssertion().Should().Be("sqa.qups");

            //Apps and Website Info
            SettingsPage _settingsPage = new SettingsPage(driver);
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnAppsAndWebsite();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnActive();
            Thread.Sleep(utils.timeDelay);
            driver.Navigate().Forward();
            _settingsPage.ClickOnExpired();
            Thread.Sleep(utils.timeDelay);
            driver.Navigate().Forward();
            _settingsPage.ClickOnRemoved();
            Thread.Sleep(utils.timeDelay);

        }

        [Test, Order(2)]
        public void EmailAndSms_Test()
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
            _accountInfoPage.ClickOnSettings();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.CheckSettingsAssertion().Should().Be("sqa.qups");

            //Email and SMS Info
            SettingsPage _settingsPage = new SettingsPage(driver);
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnEmailAndSms();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnFeedBackEmail();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnReminderEmail();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnProductEmail();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnNewsEmail();
            Thread.Sleep(utils.timeDelay);

        }

        [Test, Order(3)]
        public void Push_Notification_Test()
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
            _accountInfoPage.ClickOnSettings();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.CheckSettingsAssertion().Should().Be("sqa.qups");

            //Push Notification Info
            SettingsPage _settingsPage = new SettingsPage(driver);
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnPushNotification();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnLikes();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnComments();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnCommentLike();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnLikeAndCommentOnPhoto();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnAcceptedFollowRequest();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnInstagramDirectRequest();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnInstagramDirect();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnReminders();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnFirstPostAndStories();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnVideoViewCount();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnSupportRequest();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnLiveVideos();
            Thread.Sleep(utils.timeDelay);

        }

        [Test, Order(4)]
        public void Manage_Contacts_Test()
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
            _accountInfoPage.ClickOnSettings();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.CheckSettingsAssertion().Should().Be("sqa.qups");

            //Manage Contacts Info
            SettingsPage _settingsPage = new SettingsPage(driver);
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnManageContacts();
            Thread.Sleep(utils.timeDelay);

        }

        [Test, Order(5)]
        public void PrivacyAndSecurity_Test()
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
            _accountInfoPage.ClickOnSettings();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.CheckSettingsAssertion().Should().Be("sqa.qups");

            //Privacy and Security Info
            SettingsPage _settingsPage = new SettingsPage(driver);
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnPrivacyAndSecurity();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnAccountPrivacy();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnPrivateAccount();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnActivityStatus();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnStorySharing();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnPhotosOfYou();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnSupport();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnMentions();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnPosts();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnAllowTags();
            Thread.Sleep(utils.timeDelay);

        }

        [Test, Order(6)]
        public void PrivacyAndSecurity_Comments_Test()
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
            _accountInfoPage.ClickOnSettings();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.CheckSettingsAssertion().Should().Be("sqa.qups");

            //Privacy and Security Info
            SettingsPage _settingsPage = new SettingsPage(driver);
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnPrivacyAndSecurity();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnPrivacyAndSecurity_Comments();
            Thread.Sleep(utils.timeDelay);
            _settingsPage.EnterPrivacyAndSecurity_CmntTextArea("Lorem Ipsum is simply dummy text of the printing and typesetting industry.");
            Thread.Sleep(utils.timeDelay);
            _settingsPage.ClickOnPrivacyAndSecurity_submitBtn();
            Thread.Sleep(utils.timeDelay);

        }

    }
}
