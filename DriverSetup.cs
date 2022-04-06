using CSharp_Instagram_Selenium.Common;
using CSharp_Instagram_Selenium.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace CSharp_Instagram_Selenium
{
    public class DriverSetup
    {
        
        public static  IWebDriver driver;
        public readonly Constants _constants;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Constants.HomePageUrl);
            driver.Manage().Window.Maximize();
            Thread.Sleep(utils.timeDelay);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}