using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Instagram_Selenium.Pages
{
    public class AccountInfoPage
    {
        private readonly IWebDriver _driver;


        private By ProfileIconXpath => By.XPath("//*[@id='react-root']/section/nav/div[2]/div/div/div[3]/div/div[6]/span/img");
        private By ProfileXpath => By.XPath("//div[contains(text(),'Profile')]");
        private By ProfileAssertXpath => By.XPath("//h2[contains(text(),'sqa.qups')]");
        private By SavedXpath => By.XPath("//div[contains(text(),'Saved')]");
        private By SettingsXpath => By.XPath("//div[contains(text(),'Settings')]");
        private By SettingsAssertionXpath => By.XPath("//h1[contains(text(),'sqa.qups')]");
        private By SwitchAccountXpath => By.XPath("//div[contains(text(),'Switch Accounts')]");
 
        public AccountInfoPage(IWebDriver driver)
        {
            this._driver = driver;
        }
        
        private IWebElement ProfileIcon => _driver.FindElement(ProfileIconXpath);
        private IWebElement Profile => _driver.FindElement(ProfileXpath);
        private IWebElement ProfileAssert => _driver.FindElement(ProfileAssertXpath);
        private IWebElement Saved => _driver.FindElement(SavedXpath);
        private IWebElement Settings => _driver.FindElement(SettingsXpath);
        private IWebElement SwitchAccount => _driver.FindElement(SwitchAccountXpath);
        private IWebElement SettingsAssertion => _driver.FindElement(SettingsAssertionXpath);


        public void ClickOnProfileIcon()
        {
            ProfileIcon.Click();
        }

        public void ClickOnProfile()
        {
            Profile.Click();
        }

        public string CheckOnProfileAssert()
        {
            return ProfileAssert.Text;
        }

        public void ClickOnSaved()
        {
            Saved.Click();
        }

        public void ClickOnSettings()
        {
            Settings.Click();
        }

        public void ClickOnSwitchAccount()
        {
            SwitchAccount.Click();
        }

        public string CheckSettingsAssertion()
        {
            return SettingsAssertion.Text;
        }
    }
}
