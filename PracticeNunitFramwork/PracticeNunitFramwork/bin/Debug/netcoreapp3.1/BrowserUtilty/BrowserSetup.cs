using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PracticeNunitFramwork.BrowserUtilty
{
    public class BrowserSetup
    {

        public IWebDriver BrowserOpen(IWebDriver driver)
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            return driver;
        }
    }
}
