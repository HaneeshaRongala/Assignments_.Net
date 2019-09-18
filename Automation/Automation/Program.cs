using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
namespace Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.gmail.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("identifierId")).SendKeys("haneesha112233@gmail.com");
            driver.FindElement(By.Id("identifierNext")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Name("password")).SendKeys("Abc@12345678");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//div[@id='passwordNext']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//div[@class='T-I J-J5-Ji T-I-KE L3']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Name("to")).SendKeys("reddy.bindu1997@gmail.com");
            driver.FindElement(By.Name("subjectbox")).SendKeys("Selenium notes");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//div[@class='Am Al editable LW-avf']")).SendKeys(" Hi, \n PFA selenium notes \n \n \n Thanks and regards, \n Haneesha.");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//div[text()='Send']")).Click();
            System.Threading.Thread.Sleep(3000);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}
          






      

