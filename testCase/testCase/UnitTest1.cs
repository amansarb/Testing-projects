using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace testCase
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://techintern.co.nz/contact.html";
            Thread.Sleep(3000);

            driver.FindElement(By.Name("name")).SendKeys("aman");
            driver.FindElement(By.Name("email")).SendKeys("aman.lotey1986@gmail.com");
            driver.FindElement(By.Name("subject")).SendKeys("Automatic testing");
            driver.FindElement(By.Name("message")).SendKeys("Hi i am one of the intern /r/n doing automatic testing");
            driver.FindElement(By.Name("submit")).Click();
            
        }
        [Fact]
        public void Test2()
        {
           IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";           // facebook
            Thread.Sleep(3000);
          //  driver.FindElement(By.Name("name")).SendKeys("aman");
            driver.FindElement(By.Name("firstname")).SendKeys("Pavit");
            driver.FindElement(By.Name("lastname")).SendKeys("Sadhal");
            driver.FindElement(By.Id("u_0_r")).SendKeys("amalotey@gmail.com");
            driver.FindElement(By.Id("password_step_input")).SendKeys("sdcnkhn");


            IWebElement elem = driver.FindElement(By.Id("day"));  // Day
            SelectElement oselect = new SelectElement(elem);
            oselect.SelectByValue("16");

            IWebElement elem2 = driver.FindElement(By.Id("month"));                // Month
            SelectElement oselect1 = new SelectElement(elem2);
            oselect1.SelectByIndex(6);

            IWebElement elem3 = driver.FindElement(By.Id("year"));                // Year
            SelectElement oselect2 = new SelectElement(elem3);
            oselect2.SelectByValue("1999");

          driver.FindElement(By.Id("u_0_6")).Click();

           // driver.FindElement(By.Name("submit")).Click();

        }
        [Fact]
        public void Test3()
        {
            IWebDriver driver = new ChromeDriver();
           driver.Url = "https://www.google.com/";
            Thread.Sleep(2000);

            driver.FindElement(By.Id("gb_70")).Click();
            driver.FindElement(By.Name("identifier")).SendKeys("aman.lotey1986@gmail.com");

            driver.FindElement(By.XPath("//*[@id='identifierNext']/div/span/span")).Click();
          //  driver.FindElement(By.Name("message")).SendKeys("Hi i am one of the intern /r/n doing automatic testing");
          //  driver.FindElement(By.Name("submit")).Click();

        }
    }
}
