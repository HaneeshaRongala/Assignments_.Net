using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDropdown
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://newtours.demoaut.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("REGISTER")).Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement webElement = driver.FindElement(By.Name("country"));
            SelectElement element = new SelectElement(webElement);
            IList<IWebElement> w = element.Options;
            Console.WriteLine("Total no of countries =" + w.Count);
            Int64 countries = w.Count;
            for(int i=0; i<countries; i++)
            {
                string s = w.ElementAt(i).Text;
                Console.WriteLine("List of countries : " + s);
            }
            System.Threading.Thread.Sleep(2000);
            driver.Close();
        }
    }
}









































