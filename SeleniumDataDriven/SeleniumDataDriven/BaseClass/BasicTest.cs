using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDataDriven.BaseClass
{
    public class BasicTest
    {
        public IWebDriver driver;
        [TestInitialize]
        public void openBrowser()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize();
         }
        [TestCleanup]
        public void CloseBrowser()
        {
            driver.Quit();

        }

    }
}
