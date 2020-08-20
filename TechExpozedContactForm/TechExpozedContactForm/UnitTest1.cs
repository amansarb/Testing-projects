using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Collections.Generic;
using OfficeOpenXml;
using System.IO;

namespace TechExpozedContactForm
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HeaderBarHomePage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://techexpozed.co.nz/");
            driver.Manage().Window.Maximize();
            //Header Bar functionalty 
            driver.FindElement(By.LinkText("Home")).Click();                         // home page opened
           //driver.Navigate().Back();
            driver.FindElement(By.LinkText("Design")).Click();                         //  design opened
           driver.Navigate().Back();
            //driver.FindElement(By.LinkText("Our Services")).Click();                         // our services menu should be  opened
           // driver.Navigate().Back();
            driver.FindElement(By.XPath("//nav[@class='navigation-menu']//span[contains(text(),'About')]")).Click();                         // About page opened
           // driver.Navigate().Back();
            driver.FindElement(By.LinkText("Contact")).Click();                         // Contact page opened
           // driver.Navigate().Back();

            driver.Quit();

        }

        [TestMethod]
        public void TechExpoContactForm()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url=("https://techexpozed.co.nz/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Contact")).Click();                         // Contact page opened
            driver.FindElement(By.Id("name")).SendKeys("Aman");                             // Name
            driver.FindElement(By.Name("email")).SendKeys("aman.lotey1986@gmail.com");      //email
            IWebElement element = driver.FindElement(By.Name("subject"));                   // choose topic
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(4);
            driver.FindElement(By.Id("message")).SendKeys("Hi one of the intern, \n doing automatic testing");      // type message
            driver.FindElement(By.XPath("//*[@id='contact-form']/div/div[5]/button")).Click();                      // click send message
             Thread.Sleep(2000);
            driver.Quit();

        }
        [TestMethod]
        public void ValidityCheckContactFormNoName()              //Leave Name field empty
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://techexpozed.co.nz/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Contact")).Click();                         // Contact page opened
            driver.FindElement(By.Id("name")).SendKeys("");                             // Name
            driver.FindElement(By.Name("email")).SendKeys("aman.lotey1986@gmail.com");      //email
            IWebElement element = driver.FindElement(By.Name("subject"));                   // choose topic
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(4);
            driver.FindElement(By.Id("message")).SendKeys("Hi one of the intern, \n doing automatic testing");      // type message
            driver.FindElement(By.XPath("//*[@id='contact-form']/div/div[5]/button")).Click();                      // click send message
            Thread.Sleep(2000);
            driver.Quit();

        }
        [TestMethod]
        public void NoEmail()              //Validy check with no email entered 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://techexpozed.co.nz/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Contact")).Click();                         // Contact page opened
            driver.FindElement(By.Id("name")).SendKeys("Aman");                             // Name
            driver.FindElement(By.Name("email")).SendKeys("");      //email
            IWebElement element = driver.FindElement(By.Name("subject"));                   // choose topic
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(4);
            driver.FindElement(By.Id("message")).SendKeys("Hi one of the intern, \n doing automatic testing");      // type message
            driver.FindElement(By.XPath("//*[@id='contact-form']/div/div[5]/button")).Click();                      // click send message
            Thread.Sleep(2000);
            driver.Quit();

        }
        [TestMethod]
        public void Nomessage()                 //Validy check with no message
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://techexpozed.co.nz/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Contact")).Click();                         // Contact page opened
            driver.FindElement(By.Id("name")).SendKeys("Aman");                             // Name
            driver.FindElement(By.Name("email")).SendKeys("aman.lotey1986@gmail.com");      //email
            IWebElement element = driver.FindElement(By.Name("subject"));                   // choose topic
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(4);
            driver.FindElement(By.Id("message")).SendKeys("");      // type message
            driver.FindElement(By.XPath("//*[@id='contact-form']/div/div[5]/button")).Click();                      // click send message
            Thread.Sleep(2000);
            driver.Quit();

        }
        [TestMethod]
        [DataRow("aman","aman.lotey1986@gmail.com","m","One of the intern practicing Datadriven Testing")]
        public void DataRowContactFormDatatDriven(string name, string email, string subject, string message)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://techexpozed.co.nz/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Contact")).Click();                         // Contact page opened
            driver.FindElement(By.Id("name")).SendKeys(name);                             // Name
            driver.FindElement(By.Name("email")).SendKeys(email);      //email
            driver.FindElement(By.Name("subject")).SendKeys(subject);
           driver.FindElement(By.Id("message")).SendKeys(message);     // type message
            driver.FindElement(By.XPath("//*[@id='contact-form']/div/div[5]/button")).Click();                      // click send message
            Thread.Sleep(2000);
            driver.Quit();

        }
        [TestMethod]
        [DynamicData(nameof(ReadExcel),DynamicDataSourceType.Method)]
        public void ExcelDataRowContactFormDatatDrive(string name, string email, string subject, string message)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://techexpozed.co.nz/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("Contact")).Click();                         // Contact page opened
            driver.FindElement(By.Id("name")).SendKeys(name);                             // Name
            driver.FindElement(By.Name("email")).SendKeys(email);      //email
            driver.FindElement(By.Name("subject")).SendKeys(subject);
            driver.FindElement(By.Id("message")).SendKeys(message);     // type message
           // driver.FindElement(By.XPath("//*[@id='contact-form']/div/div[5]/button")).Click();                      // click send message
            Thread.Sleep(2000);
            driver.Quit();

        }
        public static IEnumerable<object[]> ReadExcel()

        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo("contact.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["sheet1"];
                int rowCount = worksheet.Dimension.End.Row;
                for (var i = 2; i <= rowCount; i++)
                {
                    yield return new object[]
                    {
                        worksheet.Cells[i,1].Value?.ToString().Trim(),
                         worksheet.Cells[i,2].Value?.ToString().Trim()
                    };

                }
            }

        }
    }
}
