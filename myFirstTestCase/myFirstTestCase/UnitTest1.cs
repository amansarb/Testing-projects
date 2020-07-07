using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace myFirstTestCase
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            // driver.Url = "http://google.com";
            driver.Url = "http://techexpozed.co.nz";
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
