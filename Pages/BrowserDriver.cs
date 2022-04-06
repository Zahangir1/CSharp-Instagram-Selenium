using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace CSharp_Instagram_Selenium.Pages
{
    public interface BrowserDriver 
    //public class BrowserDriver : IDisposable 
    {
        IWebDriver Current { get; }

        /*protected readonly Lazy<IWebDriver> _currentWebDriverLazy;
protected bool _isDisposed;
public BrowserDriver(ISeleniumConfiguration seleniumConfiguration, IObjectContainer objectContainer);
public IWebDriver Current { get; }
public void Dispose();*/

        string GetUrl();
        void GoToUrl(string url);
        IWebElement WaitAndReturnElement(By elementLocator);
        IEnumerable<IWebElement> WaitAndReturnElements(By elementLocator);

    }
}