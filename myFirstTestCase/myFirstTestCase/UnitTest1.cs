using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Internal;

namespace myFirstTestCase
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://google.com";
            //driver.Url = "http://techexpozed.co.nz";
            IWebElement web = driver.FindElement(By.Name("q"));
            web.SendKeys("God is one, God helps everyone");
            web.Submit();
            Console.WriteLine(driver.Title);
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
