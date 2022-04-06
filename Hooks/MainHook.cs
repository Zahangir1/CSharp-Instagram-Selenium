using CSharp_Instagram_Selenium.Common;
using CSharp_Instagram_Selenium.Pages;
using CSharp_Instagram_Selenium.Tests;
using CSharp_Instagram_Selenium.Utils;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp_Instagram_Selenium.Hooks
{
    public class MainHook
    {
        /*public static IWebDriver driver = null;
        public readonly IWebDriver _driver;

        public MainHook(IWebDriver driver)
        {
            this._driver = driver;
        }*/

      /*  [Test, Order(0)]
        public void MainHoook_Test()
        {
            HomePage _homePage = new HomePage(driver);
            Thread.Sleep(utils.timeDelay);
            _homePage.EnterUsername(Constants.Email);
            Thread.Sleep(utils.timeDelay);
            _homePage.EnterPassword(Constants.PassWord);
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);

        }*/

        /*  [Test, Order(1)]
          public void CommonSettings_Test()
          {
              HomePage _homePage = new HomePage(driver);
              Thread.Sleep(utils.timeDelay);
              _homePage.EnterUsername(Constants.Email);
              Thread.Sleep(utils.timeDelay);
              _homePage.EnterPassword(Constants.PassWord);
              Thread.Sleep(utils.timeDelay);
              _homePage.ClickOnLogin();
              Thread.Sleep(utils.timeDelay);
              AccountInfoPage _accountInfoPage = new AccountInfoPage(driver);
              Thread.Sleep(utils.timeDelay);
              _accountInfoPage.ClickOnProfileIcon();
              Thread.Sleep(utils.timeDelay);
              _accountInfoPage.ClickOnSettings();
              Thread.Sleep(utils.timeDelay);
              _accountInfoPage.CheckSettingsAssertion().Should().Be("sqa.qups");

          }*/



    }
}
