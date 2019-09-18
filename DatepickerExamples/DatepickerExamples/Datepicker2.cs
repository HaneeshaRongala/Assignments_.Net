using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DatepickerExamples
{ 
    [TestCategory("General")]
    [TestClass]
    public class Datepicker2
    {

        protected static IWebDriver driver;

        [ClassInitialize]

        public static void Opening_Homepage(TestContext tc)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.goibibo.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [TestMethod]
        public void Select_From_Destination_cities()
        {
            driver.FindElement(By.XPath("//*[@placeholder='From']")).SendKeys("Hyderabad");
            driver.FindElement(By.XPath("//*[text()='Hyderabad, India']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            driver.FindElement(By.XPath("//*[@placeholder='Destination']")).SendKeys("Chennai");
            driver.FindElement(By.XPath("//*[text()='Chennai, India']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
           
        }
       [TestMethod]
        public void Pick_the_Date()
        {
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//*[@id='departureCalendar']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//*[text()='20']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            driver.FindElement(By.XPath("//*[@id='returnCalendar']")).Click();
            driver.FindElement(By.XPath("//*[text()='25']")).Click();
       }

        [TestMethod]
        public void Select_Travel_Economy()
        {
            driver.FindElement(By.XPath("//*[@id='pax_link_common']")).Click();
            driver.FindElement(By.XPath("//*[@id='adultPaxBox']")).Click();
            driver.FindElement(By.XPath("//*[@id='adultPaxPlus']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//*[@id='childPaxBox']")).Click();
            driver.FindElement(By.XPath("//*[@id='childPaxPlus']")).Click();

        }
        [TestMethod]
        public void Search_Avalability()
        {
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        //[TestMethod]
        //public void Close_browser()
        //{
        //    driver.Close();
        //    driver.Dispose();
        //}
       
    }
}

