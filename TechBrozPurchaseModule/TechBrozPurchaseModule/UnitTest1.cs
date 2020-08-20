using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TechBrozPurchaseModule
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Purchase()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.techbroz.co.nz/";
            Thread.Sleep(6000);
            driver.FindElement(By.Name("s")).SendKeys("mouse" + Keys.Enter);
            Thread.Sleep(2000);
            IWebElement elem = driver.FindElement(By.LinkText("HP OMEN Hard Mouse Pad 20"));
            elem.Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//button[@name='add-to-cart']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//a[@class='button wc-forward']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.LinkText("Proceed to checkout")).Click();
            Thread.Sleep(3000);
            // Fill billing form
            Actions actions = new Actions(driver);
            Thread.Sleep(6000);
           // ((IJavaScriptExecutor)driver).ExecuteScript("window.ScrollBy(0,300);");
            driver.FindElement(By.Id("billing_first_name")).SendKeys("Aman");
            driver.FindElement(By.Id("billing_last_name")).SendKeys("lotey");
            driver.FindElement(By.Id("billing_company")).SendKeys("TechExpo");
            driver.FindElement(By.Id("billing_address_1")).SendKeys("2/36");
            driver.FindElement(By.Id("billing_address_2")).SendKeys("ulster street");
            driver.FindElement(By.Id("billing_city")).SendKeys("Hamilton");
             IWebElement element= driver.FindElement(By.Id("billing_state_field"));
            element.Click();
            SelectElement select = new SelectElement(element);
             select.SelectByIndex(1);
            //elem1.Click();
           // SelectElement selectElement = new SelectElement(elem1);
            //selectElement.SelectByIndex(1);
            //driver.FindElement(By.Id("billing_city")).SendKeys("Hamilton");
           // driver.FindElement(By.Id("billing_city")).SendKeys("Hamilton");
            //driver.FindElement(By.Id("billing_city")).SendKeys("Hamilton");
            //Thread.Sleep(4000);
            /*actions.Click(driver.FindElement(By.Id("billing_first_name")))
                .SendKeys("lotey" + Keys.Tab)
                .SendKeys("TechExo" + Keys.Tab)
                .SendKeys("2" + Keys.Tab)
                .SendKeys("willougbhy street" + Keys.Tab)
                .SendKeys("hamilton" + Keys.Tab)
                .SendKeys("Waikato" + Keys.Tab)
                .SendKeys("3200" + Keys.Tab)
                .SendKeys("5689663" + Keys.Tab)
                .SendKeys("aman.lotey@gmail.com" + Keys.Tab)
                .Click()
                .SendKeys("please send confirmation email once dipatched"); */

            Thread.Sleep(4000);
            driver.Quit();



        }
    }
}
