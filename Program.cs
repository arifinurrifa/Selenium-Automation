using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Automation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com/");

            IWebElement Search = driver.FindElement(By.Name("q"));
            driver.Manage().Window.Maximize();

            Search.SendKeys("HIIIIIIIIIIIIIIII");

            driver.Quit();

        }
    }

}
        
    

