using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System;
using OpenQA.Selenium.Interactions;

namespace IWebElementPropertiesMethods
{
    [TestClass]
    public class UnitTest1
    {
       IWebDriver driver = new ChromeDriver();


        [TestMethod]
        public void WebElementDisplayed()
        {
            driver.Url = "https://techexpozed.co.nz/";
            driver.Manage().Window.Maximize();
            var result = driver.FindElement(By.ClassName("abcd")).Displayed;
            Console.WriteLine(result);
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void WebElementEnabled()
        {
            driver.Url = "https://techexpozed.co.nz/";
            driver.Manage().Window.Maximize();
            var result = driver.FindElement(By.ClassName("header__logo")).Enabled;
            Console.WriteLine(result);
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void WebElementLocatio()
        {
            driver.Url = "https://techexpozed.co.nz/";
            driver.Manage().Window.Maximize();
            var result = driver.FindElement(By.ClassName("header__logo")).Location;
            Console.WriteLine(result);
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void WebElementSelected()
        {
            driver.Url = " http://facebook.com/";
            driver.Manage().Window.Maximize();
            Actions actions = new Actions(driver);
            actions.Click(driver.FindElement(By.Id("u_0_6")))
                            .Perform();
            var selected = driver.FindElement(By.Id("u_0_6")).Selected;
            Console.WriteLine(selected);
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void WebElementSize()
        {
            driver.Url = "https://techexpozed.co.nz/";
            driver.Manage().Window.Maximize();
            var result = driver.FindElement(By.ClassName("header__logo")).Size;
            Console.WriteLine(result);
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void WebElementSelected1()
        {
            //IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";

            Actions actions = new Actions(driver);

            actions.Click(driver.FindElement(By.Id("u_0_m")))
                .Perform();
            var selected = driver.FindElement(By.Id("u_0_m")).Selected;

            Console.WriteLine(selected);

            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void WebElementTagName()
        {
            driver.Url = "https://techexpozed.co.nz/";
            driver.Manage().Window.Maximize();
            var result = driver.FindElement(By.ClassName("header__logo")).TagName;
            Console.WriteLine(result);
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void WebElementText()
        {
            driver.Url = "https://techexpozed.co.nz/";
            driver.Manage().Window.Maximize();
            var result = driver.FindElement(By.LinkText("Home")).Text;
            Console.WriteLine(result);
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void WebElementClear()
        {
            driver.Url = "https://techexpozed.co.nz/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Contact")).Click();
            driver.FindElement(By.Id("name")).SendKeys("aman");
            driver.FindElement(By.Id("name")).Clear();
            Thread.Sleep(3000);
            driver.Quit();
        }
        [TestMethod]
        public void WebElementgetAttribute()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("__headless");
            IWebDriver driver = new ChromeDriver(chromeOptions);
            driver.Url = "https://techexpozed.co.nz/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Contact")).Click();
            var attribute = driver.FindElement(By.Id("name")).GetAttribute("Id");
            Console.WriteLine(attribute);
            Thread.Sleep(3000);
            driver.Quit();
        }
        [TestMethod]
        public void WebElementgetCssValue()
        {
            
            driver.Url = "https://techexpozed.co.nz/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Contact")).Click();
            var CssValue = driver.FindElement(By.Id("name")).GetCssValue("color");
            Console.WriteLine(CssValue);
            Thread.Sleep(3000);
            driver.Quit();
        }
        [TestMethod]
        public void Scroll()
        {
            driver.Url = "https://facebook.com";
            driver.Manage().Window.Maximize();
            ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementsByName('firstname')[0].value='aman'");
            ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementsByName('lastname')[0].value='Lotey'");

            // ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,300)");

             Thread.Sleep(2000);
            driver.Quit();
        }

    }
}