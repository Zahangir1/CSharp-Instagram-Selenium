using CSharp_Instagram_Selenium.Common;
using CSharp_Instagram_Selenium.Pages;
using CSharp_Instagram_Selenium.Utils;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp_Instagram_Selenium.Tests
{
    public class LoginTest : DriverSetup
    {
       
        [Test]
        public void Login_Test() 
        {
            LoginPage _loginPage = new LoginPage(driver);
            Thread.Sleep(utils.timeDelay);
            _loginPage.EnterUsername(Constants.Email);
            Thread.Sleep(utils.timeDelay);
            _loginPage.EnterPassword(Constants.PassWord);
            Thread.Sleep(utils.timeDelay);
            _loginPage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);
            //_loginPage.ClickOnAssertTitle().Should().Be("Instagram");

        }

    }
}
