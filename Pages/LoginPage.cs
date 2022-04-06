using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Instagram_Selenium.Pages
{
    public class LoginPage
    {
        public static IWebDriver driver = null;
        private readonly IWebDriver _driver;

        private By UsernameXpath => By.XPath("//input[@name='username']");
        private By PasswordXpath => By.XPath("//input[@name='password']");
        private By LoginXpath => By.XPath("//div[contains(text(),'Log In')]");
        private By AssertTitleXpath => By.XPath("//title[contains(text(),'Instagram')]");

       
        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        private IWebElement Username => _driver.FindElement(UsernameXpath);
        private IWebElement Password => _driver.FindElement(PasswordXpath);
        private IWebElement Login => _driver.FindElement(LoginXpath);
        private IWebElement AssertTitle => _driver.FindElement(AssertTitleXpath);

        public void EnterUsername(string email)
        {
            Username.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }

        public void ClickOnLogin()
        {
            Login.Click();
        }

        public string ClickOnAssertTitle()
        {
            return AssertTitle.Text;
        }
    }
}
