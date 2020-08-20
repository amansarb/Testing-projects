using NUnit.Framework;
using OpenQA.Selenium;
using PracticeNunitFramwork.BrowserUtilty;
using System.Threading;

namespace PracticeNunitFramwork
{
    class parallelClass : BrowserSetup
    {
        public IWebDriver driver;
        [Parallelizable()]
        [Test, Category("smoke Testing"), Category("parallel1")]
        public void Test1()
        {
            var webDriver = new BrowserSetup().BrowserOpen(driver);
            webDriver.FindElement(By.Name("q")).SendKeys("Regression Testing");
            Thread.Sleep(2000);
            webDriver.Navigate().Refresh();
            webDriver.Close();

        }
        [Parallelizable()]
        [Test, Category("smoke Testing"), Category("parallel1")]
        public void Test2()
        {
            var webDriver = new BrowserSetup().BrowserOpen(driver);
            webDriver.FindElement(By.Name("q")).SendKeys("Regression Testing");
            Thread.Sleep(2000);
            webDriver.Navigate().Refresh();
            webDriver.Close();

        }
        [Parallelizable()]
        [Test, Category("smoke Testing"), Category("parallel1")]
        public void Test3()
        {
            var webDriver = new BrowserSetup().BrowserOpen(driver);
            webDriver.FindElement(By.Name("q")).SendKeys("Regression Testing");
            Thread.Sleep(2000);
            webDriver.Navigate().Refresh();
            webDriver.Close();

        }
        [Parallelizable()]
        [Test, Category("smoke Testing"), Category("parallel1")]
        public void Test4()
        {
            var webDriver = new BrowserSetup().BrowserOpen(driver);
            webDriver.FindElement(By.Name("q")).SendKeys("Regression Testing");
            Thread.Sleep(2000);
            webDriver.Navigate().Refresh();
            webDriver.Close();

        }

    }
}
