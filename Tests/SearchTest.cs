using CSharp_Instagram_Selenium.Common;
using CSharp_Instagram_Selenium.Pages;
using CSharp_Instagram_Selenium.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp_Instagram_Selenium.Tests
{
    class SearchTest : DriverSetup
    {
        [Test]
        public void Search_Test()
        {
            Thread.Sleep(utils.timeDelay);
            HomePage _homePage = new HomePage(driver);
            _homePage.EnterUsername(Constants.Email);
            Thread.Sleep(utils.timeDelay);
            _homePage.EnterPassword(Constants.PassWord);
            Thread.Sleep(utils.timeDelay);
            _homePage.ClickOnLogin();
            Thread.Sleep(utils.timeDelay);
            _homePage.EnterSearch("nature");
            Thread.Sleep(utils.timeDelay);

        }
    }
}
