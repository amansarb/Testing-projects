using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace TechInternFullSiteTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HomePageHeader()                                     // Functionalty of home page
        {
            IWebDriver driver = new ChromeDriver();

            //Header Section
            driver.Url=("https://techintern.co.nz/");               // Navigate to TechIntern.co.nz
            driver.Manage().Window.Maximize();                       // Maximize the Window
            driver.FindElement(By.LinkText("Home")).Click();        // click on home link
            driver.FindElement(By.LinkText("About")).Click();       // click on About link
            driver.FindElement(By.LinkText("Courses")).Click();         // Click on Courses link
            driver.FindElement(By.LinkText("Support Service")).Click();     // click on Support Service
            driver.FindElement(By.LinkText("Contact")).Click();             // Click on Contact
            Thread.Sleep(2000);
            // Content Section
            driver.FindElement(By.LinkText("Home")).Click();
            driver.FindElement(By.LinkText("Our Programs")).Click();            // Click on Our programs
            driver.FindElement(By.LinkText("Home")).Click();
            driver.FindElement(By.XPath("//*[@id='home']/div[2]/div/div/div/a[2]")).Click();
            Thread.Sleep(2000);

            driver.Quit();





        }
        [TestMethod]
        public void HomePageContent()                                     // Functionalty of home page
        {
            IWebDriver driver = new ChromeDriver();

            //Header Section
            driver.Url = ("https://techintern.co.nz/");               // Navigate to TechIntern.co.nz
            driver.Manage().Window.Maximize();                       // Maximize the Window
            
            // Content Section
            driver.FindElement(By.LinkText("Our Programs")).Click();            // Click on Our programs
            driver.FindElement(By.LinkText("Home")).Click();
            driver.FindElement(By.XPath("//*[@id='home']/div[2]/div/div/div/a[2]")).Click();
            Thread.Sleep(2000);

            driver.Quit();





        }
    }
}
