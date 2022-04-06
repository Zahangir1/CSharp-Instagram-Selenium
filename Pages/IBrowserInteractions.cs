using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace CSharp_Instagram_Selenium.Pages
{
    public interface IBrowserInteractions
    {
        string GetUrl();
        void GoToUrl(string url);
        IWebElement WaitAndReturnElement(By elementLocator);
        IEnumerable<IWebElement> WaitAndReturnElements(By elementLocator);
        //T? WaitUntil<T>(Func<T> getResult, Func<T, bool> isResultAccepted) where T : class;
    }
}