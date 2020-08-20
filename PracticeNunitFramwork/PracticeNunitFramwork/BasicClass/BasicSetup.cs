using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace PracticeNunitFramwork.BasicClass
{

    public class BasicSetup
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void openBrowser()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

        }
        [OneTimeTearDown]
        public void closeBrowser()
        {
            driver.Quit();

        }


    }

    public class BaseTestSetup
    {
        public IWebDriver driver;
        [SetUp]
        public void openBrowser()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();

        }
    }

}

