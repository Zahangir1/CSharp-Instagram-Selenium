using CSharp_Instagram_Selenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Instagram_Selenium.Utils
{
    public class utils
    {
        private readonly IWebDriver _driver;

        public static int timeDelay = 2000;

        public utils(IWebDriver driver)
        {
            this._driver = driver;
        }

        public static string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff ");
        }

        /*public string GetRandomEmailAddress()
        {
            string timestamp = GetTimestamp(DateTime.Now);
            return "test" + timestamp + "@mailinator.com";
        }
*/
        public void scrollToElement(IWebElement element)
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public void switchTab(int tabNum) 
        {
            _driver.SwitchTo().Window(_driver.WindowHandles[tabNum]);
        }
    }
}
