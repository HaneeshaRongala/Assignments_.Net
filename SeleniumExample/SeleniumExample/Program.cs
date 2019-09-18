using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumExample
{
    class Program 
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            // NAVIGATING TO CRM-PRO WEBSITE
            driver.Navigate().GoToUrl("https://www.crmpro.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@name='username']")).SendKeys("hanee5432");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//*[@type='password']")).SendKeys("hanee@12345");
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
            driver.SwitchTo().Frame("mainpanel");
            string Logoutaction = driver.FindElement(By.XPath("//*[@class='topnavlink' and contains(@href,'logout')]")).Text.Trim();
            Logoutaction.ShouldBe("Logout");
            Console.WriteLine("display the function:" + Logoutaction.Trim());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("(//div[@id='homebox_CALDAY']//table//td)[2]")).Click();

            // EDIT EVENT
            driver.FindElement(By.XPath("//*[@value='Edit']")).Click();
            driver.FindElement(By.XPath("//*[@name='title']")).SendKeys("R Haneesha");
           
          //DATE PICKER
          driver.FindElement(By.XPath("//*[@id='f_trigger_c_start']")).Click();

            IList<IWebElement> ele1 = driver.FindElements(By.XPath("//*[@class='headrow']/td"));

            for (int i = 0; i < ele1.Count; i++)
            {
                String aa = ele1[i].Text;

                if (aa.Equals("›"))
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        ele1[i].Click();
                    }
                    
                }
            }
           
         IList<IWebElement> ele = driver.FindElements(By.XPath("//*[@class='daysrow']/td"));
               for (int i=0;i<ele.Count;i++)
            {
                String aa = ele[i].Text;

                if(aa.Equals("24"))
                {
                    ele[i].Click();
                    break;
                }
            }
            driver.FindElement(By.XPath("//*[@name='all_day_event']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

           //USING DROPDOWNS
            SelectElement selectcategory = new SelectElement(driver.FindElement(By.Name("category")));
            IList<IWebElement> listcount = selectcategory.Options;
            int categories = listcount.Count();
            Console.WriteLine("Display the count of categories:" + categories);
            listcount.ElementAt(2).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//*[@value ='<=REMOVE=']")).Click();       
            driver.FindElement(By.XPath("//*[text()='Rongala Haneesha']")).Click();
            driver.FindElement(By.XPath("//*[@value='==ADD==>']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //USING RADIO BUTTONS
            driver.FindElement(By.XPath("(//*[@type='radio'])[1]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //USING CHECKBOXES
            driver.FindElement(By.XPath("//*[@name='email_alert']")).Click();
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@name='email_alert_contact']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Dropdown
            SelectElement remainder = new SelectElement(driver.FindElement(By.XPath("//*[@name='reminder_minutes']")));
            IList<IWebElement> Listcount = remainder.Options;
            int remainders = Listcount.Count();
            Console.WriteLine("Display the list of remainders:" + remainder);
            Listcount.ElementAt(1).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//*[@name='reminder_note']")).SendKeys("Gentle remainder for meeting");
            driver.FindElement(By.XPath("//*[@name='internal_reminder']")).Click();

            // WINDOW HANDLING(Switching to MainWindow)
            driver.FindElement(By.XPath("//*[@name='contact_lookup']")).SendKeys("9010459436");
            driver.FindElement(By.XPath("(//*[@value='Lookup'])[1]")).Click();
            IList<string> Mainwindow = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(Mainwindow[1]);
            driver.Close();
            driver.SwitchTo().Window(Mainwindow[0]);
            driver.SwitchTo().Frame("mainpanel");
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@name='client_lookup']")).SendKeys("TCS");
            driver.FindElement(By.XPath("(//*[@value='Lookup'])[2]")).Click();
            IList<string> Mainwindow1 = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(Mainwindow1[1]);
            driver.Close();
            driver.SwitchTo().Window(Mainwindow1[0]);
            driver.SwitchTo().Frame("mainpanel");
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@name='prospect_lookup']")).SendKeys("To understand and sell the customers products");
            driver.FindElement(By.XPath("(//*[@value='Lookup'])[3]")).Click();
            IList<string> Mainwindow2 = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(Mainwindow2[1]);
            driver.Close();
            driver.SwitchTo().Window(Mainwindow2[0]);
            driver.SwitchTo().Frame("mainpanel");
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@name='task_lookup']")).SendKeys("Selling products and making customer satisfy");
            driver.FindElement(By.XPath("(//*[@value='Lookup'])[4]")).Click();
            IList<string> Mainwindow3 = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(Mainwindow3[1]);
            driver.Close();
            driver.SwitchTo().Window(Mainwindow3[0]);
            driver.SwitchTo().Frame("mainpanel");
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@name='case_lookup']")).SendKeys("Important");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//*[@value='Lookup'])[5]")).Click();
            IList<string> Mainwindow4 = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(Mainwindow4[1]);
            driver.Close();
            driver.SwitchTo().Window(Mainwindow4[0]);
            driver.SwitchTo().Frame("mainpanel");
            driver.FindElement(By.XPath("//*[@name='tags']")).SendKeys("Important");
            driver.FindElement(By.XPath("//*[@name='location']")).SendKeys("Lancohills , Manikonda /n Hyderabad ");
            driver.FindElement(By.XPath("//*[@name='notes']")).SendKeys("This meeting will ensures the customer relationship management and customer satisfaction");
            driver.FindElement(By.XPath("//*[@name='meeting_notes']")).SendKeys("NO MINUTES");

            //// SAVE BUTTON
            IList<IWebElement> savebutton = driver.FindElements(By.XPath("//*[@value='Save']"));
            savebutton[1].Click();
            Console.WriteLine("count is" + savebutton.Count);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            // LOG OUT BUTTON
            driver.FindElement(By.XPath("(//*[@class='topnavlink'])[3]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Close();

        }
    }
}

































