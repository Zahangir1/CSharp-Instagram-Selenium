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
    public class PostTest : DriverSetup
    {
        [Test]
        public void Post_Test()
        {
            //Login Info
            Thread.Sleep(utils.timeDelay);
            HomePage _homePage = new HomePage(driver);
            _homePage.EnterUsername(Constants.Email);
            Thread.Sleep(utils.timeDelay);
            _homePage.EnterPassword(Constants.PassWord);
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnLogin();

            //Profile Info
            Thread.Sleep(utils.timeDelay);
            AccountInfoPage _accountInfoPage = new AccountInfoPage(driver);
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.ClickOnProfileIcon();
            Thread.Sleep(utils.timeDelay);
            _accountInfoPage.ClickOnProfile();
            Thread.Sleep(utils.timeDelay);

            //Post Info
            PostPage _postPage = new PostPage(driver);
            Thread.Sleep(utils.timeDelay);
            _postPage.ClickOnPostImage();
            Thread.Sleep(utils.timeDelay);
            _postPage.CheckOnPostAssertion().Should().Be("Beautyofswizerland");
            Thread.Sleep(utils.timeDelay);



        }
    }
}
