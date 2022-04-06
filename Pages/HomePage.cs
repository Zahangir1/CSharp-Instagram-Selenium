using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Instagram_Selenium.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        private By UsernameXpath => By.XPath("//input[@name='username']");
        private By PasswordXpath => By.XPath("//input[@name='password']");
        private By LoginXpath => By.XPath("//div[contains(text(),'Log In')]");
        private By EmailOrPhoneXpath => By.XPath("//input[@name='emailOrPhone']");
        private By FullNameXpath => By.XPath("//input[@name='fullName']");
        private By SignUpXpath => By.XPath("//button[contains(text(),'Sign up')]");
        private By SearchXpath => By.XPath("//input[@placeholder='Search']");


        public HomePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        private IWebElement Username => _driver.FindElement(UsernameXpath);
        private IWebElement Password => _driver.FindElement(PasswordXpath);
        private IWebElement Login => _driver.FindElement(LoginXpath);
        private IWebElement EmailOrPhone => _driver.FindElement(EmailOrPhoneXpath);
        private IWebElement FullName => _driver.FindElement(FullNameXpath);
        private IWebElement SignUp => _driver.FindElement(SignUpXpath);
        private IWebElement Search => _driver.FindElement(SearchXpath);



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

        public void EnterEmailOrPhone(string emailphone)
        {
            EmailOrPhone.SendKeys(emailphone);
        }

        public void EnterFullName(string fullname) 
        {
            FullName.SendKeys(fullname);
        }

        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterSearch(string search)
        {
            //Search.Click();
            Search.SendKeys(search);
            Search.SendKeys(Keys.Enter);
        }
    }
}
