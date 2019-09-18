using OpenQA.Selenium;

namespace FirstSeleniumExample
{
    internal interface IWebdriver
    {
        void Navigate();
        IWebElement FindElement(By by);
        void close();
    }
}