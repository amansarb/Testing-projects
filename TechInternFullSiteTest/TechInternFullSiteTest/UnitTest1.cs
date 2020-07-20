using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;


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
            //*[@id="Plans"]/div/div[1]/div/div/div[2]/div/a                                    
            Thread.Sleep(2000);

            driver.Quit();
        }
        [TestMethod]
        public void CoursesSignUpForm()                                     // Functionalty of home page
        {
            IWebDriver driver = new ChromeDriver();

            //Header Section
            driver.Url = ("https://techintern.co.nz/");               // Navigate to TechIntern.co.nz
            driver.Manage().Window.Maximize();                       // Maximize the Window
            driver.FindElement(By.LinkText("Courses")).Click();            // Click on Our programs
            driver.FindElement(By.XPath("//*[@id='Plans']/div/div[1]/div/div/div[2]/div/a ")).Click();
            driver.FindElement(By.Name("firstName")).SendKeys("aman");
            driver.FindElement(By.Name("lastName")).SendKeys("deep");
            driver.FindElement(By.Name("internEmail")).SendKeys("aman.lotey@gmail.com");
            driver.FindElement(By.Name("phoneNumber")).SendKeys("2674155");
            driver.FindElement(By.Name("startDate")).SendKeys("20/07/2020");
              IWebElement elem= driver.FindElement(By.Id("months"));
            SelectElement select = new SelectElement(elem);
            select.SelectByValue("4");
            driver.FindElement(By.Name("qualification")).SendKeys("Masters in IT");
            driver.FindElement(By.Name("currentWork")).SendKeys("intern");
            driver.FindElement(By.Name("currentLocation")).SendKeys("Hamilton");
            IWebElement elem1 =driver.FindElement(By.Id("interestedIn"));
            SelectElement select1 = new SelectElement(elem1);
            select1.SelectByIndex(4);
            driver.FindElement(By.Name("comment")).SendKeys("one of he intern doing automatic testing");
            IWebElement uplaodFile = driver.FindElement(By.Name("attachment"));
            uplaodFile.SendKeys("C:\\Users\\Default.Default-Laptop\\Desktop\\Aman new CV intern (1).docx");
            driver.FindElement(By.Name("attachment2")).SendKeys("C:\\Users\\Default.Default-Laptop\\Desktop\\Aman new CV intern (1).docx");
            driver.FindElement(By.Name("submit")).Click();
            Thread.Sleep(2000);
            
          driver.Quit();
        }
    }
}
