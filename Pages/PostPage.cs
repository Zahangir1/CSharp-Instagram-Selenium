using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Instagram_Selenium.Pages
{
    public class PostPage
    {
        public static IWebDriver driver = null;
        private readonly IWebDriver _driver;

        private By PostImageXpath => By.XPath("//*[@id='react-root']/section/main/div/div[2]/article/div/div/div/div[1]/a/div/div[2]");
        private By PostAssertionXpath => By.XPath("//span[contains(text(),'Beautyofswizerland')]");

        public PostPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        private IWebElement PostImage => _driver.FindElement(PostImageXpath);
        private IWebElement PostAssertion => _driver.FindElement(PostAssertionXpath);

        public void ClickOnPostImage()
        {
            PostImage.Click();
        }

        public string CheckOnPostAssertion()
        {
            return PostAssertion.Text;
        }

    }
}
