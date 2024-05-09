using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumTest
{
    internal class Program
    {
        public class WeatherCheck
        {
            ChromeDriver driver;
            public void LaunchBrowser()
            {
                driver = new ChromeDriver();
                driver.Url = "https://idokep.hu";
                Thread.Sleep(2000);
                driver.FindElement(By.ClassName("css-1wjnr64")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.ClassName("more-link")).Click();
            } 

            public void Navigate()
            {
                Thread.Sleep(1000);
                driver.Navigate().GoToUrl("https://index.hu");
                Thread.Sleep(2000);
                driver.Navigate().Back();
                Thread.Sleep(1000);
            }
        }


        static void Main(string[] args)
        {
            WeatherCheck weatherCheck = new WeatherCheck();
            weatherCheck.LaunchBrowser();
            weatherCheck.Navigate();
        }
    }
}
