using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System;

namespace JavaScriptMethods
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();
        [TestMethod]
        public void JavaScriptAlertMethod()
        {
            driver.Url = "http://uitestpractice.com/Students/Switchto";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("alert")).Click();
            Thread.Sleep(2000);
            var var1 = driver.SwitchTo().Alert().Text;
            Console.WriteLine(var1);
            driver.SwitchTo().Alert().Accept();


            driver.Quit();
        }
        [TestMethod]
        public void ConfirmPerformActionOnAlert()
        {
            driver.Url = "http://uitestpractice.com/Students/Switchto";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("alert")).Click();
            Thread.Sleep(2000);
            var var1 = driver.SwitchTo().Alert().Text;
            Console.WriteLine(var1);
            driver.SwitchTo().Alert().Dismiss();

            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void PromptAlert()
        {
            driver.Url = "http://uitestpractice.com/Students/Switchto";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("prompt")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().SendKeys("aman");
          
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
