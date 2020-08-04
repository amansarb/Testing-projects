using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Threading;
using System;

namespace SeleniumJavascriptDemo
{
    [TestClass]
    public class UnitTest1
    {
      IWebDriver driver = new ChromeDriver();

        [TestMethod]
        public void JavaScriptAlertPopUp()
        {
            driver.Url = "https://www.techexpozed.co.nz/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
          
            //IJavaScriptExecutor jsExecutor = driver as IJavaScriptExecutor;
            ((IJavaScriptExecutor)driver).ExecuteScript("alert('hello world')");
            // jsExecutor.ExecuteScript("alert('hello world')");
            //driver.SwitchTo().Alert().Accept();
            var var1=driver.SwitchTo().Alert().Text;
            Console.WriteLine(var1);
            Thread.Sleep(2000);
            driver.Quit();
            
        }
        [TestMethod]
        public void JavaScriptRefresh()
        {
            driver.Url = "https://www.techexpozed.co.nz/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Contact")).Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor jsExecutor = driver as IJavaScriptExecutor;
            jsExecutor.ExecuteScript("history.go(0)");
        }

        [TestMethod]
        public void JavaScriptCheckboxDemo()
        {
            driver.Url = "http://uitestpractice.com/Students/Form";
            driver.Manage().Window.Maximize();
           
            Thread.Sleep(2000);
            IJavaScriptExecutor jsExecutor = driver as IJavaScriptExecutor;
            jsExecutor.ExecuteScript("document.querySelectorAll('input[value=read]')[0].click()");
            Thread.Sleep(2000);
            jsExecutor.ExecuteScript("document.querySelectorAll('input[value=read]')[0].click()");
            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void JavaScriptPageTitle()
        {
            driver.Url = "https://techexpozed.co.nz/genuine-kiwi.php";
            driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //Thread.Sleep(2000);
            var var1 =js.ExecuteScript("return document.title;").ToString();
            //var var1 = ((IJavaScriptExecutor)driver).ExecuteScript("document.title;").ToString();
           Console.WriteLine(var1);

            //getting domain
            var domain = ((IJavaScriptExecutor)driver).ExecuteScript("return document.domain;").ToString();
            Console.WriteLine(domain);
            // getting Url 
           // var url = ((IJavaScriptExecutor)driver).ExecuteScript(" return window.location.href").ToString();
            var url = ((IJavaScriptExecutor)driver).ExecuteScript(" return document.URL;").ToString();
            Console.WriteLine(url);
            // getting inner width
            var inner = ((IJavaScriptExecutor)driver).ExecuteScript(" return window.innerWidth;").ToString();
            Console.WriteLine(inner);


            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void Scroll()
        {
            driver.Url = "https://facebook.com";


            // ((IJavaScriptExecutor)driver).ExecuteScript("window.location = 'https://facebook.com'; ");
            driver.Manage().Window.Maximize();
            ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementByName('firstname').value='aman'");
            ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementByName('lastname').value='Lotey'");

            // ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,300)");



            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void ChromeHeadless()
        {
            //ChromeOptions opt = new ChromeOptions();
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");
            IWebDriver driver1 = new ChromeDriver(chromeOptions);
            driver1.Url = "https://techexpozed.co.nz/contact-us.php";
           // driver1.Manage().Window.Maximize();
            var header= driver1.FindElement(By.XPath("//h3[@class='heading']")).Text;
            Console.WriteLine(header);
            driver1.Quit();
        }
        [TestMethod]
        public void FireFoxHeadless()
        {
            FirefoxOptions firefoxOptions = new FirefoxOptions();
           
           firefoxOptions.AddArgument("--headless");
            IWebDriver driver = new FirefoxDriver(firefoxOptions);
            driver.Url = "https://techexpozed.co.nz/contact-us.php";
           
            var header = driver.FindElement(By.XPath("//h3[@class='heading']")).Text;
            Console.WriteLine(header);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.location = 'https://google.com'; ");
            // driver1.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.Quit();
        }
        [TestMethod]
        public void GetelementTechIntern()
        {
           
            driver.Url = "https://techintern.co.nz/contact.html";

          
            driver.Manage().Window.Maximize();
            ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementByName('name').value='aman';");
            //((IJavaScriptExecutor)driver).ExecuteScript("document.getElementByName('email').value='Lotey'");
           // ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementByName('subject').value='testing'");
           //((IJavaScriptExecutor)driver).ExecuteScript("document.getElementByName('message').value='one of the intern doing testing'");
          

           



            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void FrameExercise()
        {
            driver.Url = "http://uitestpractice.com/Students/Switchto";
            driver.Manage().Window.Maximize();
            driver.SwitchTo().Frame("iframe_a");

            driver.FindElement(By.Id("name")).SendKeys("Pavit");
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.LinkText("Opens in a new window")).Click();
            Thread.Sleep(2000);
            driver.Quit();
        }

    }
}
