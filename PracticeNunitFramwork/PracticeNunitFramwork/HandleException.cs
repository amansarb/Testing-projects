using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PracticeNunitFramwork
{
   
    [TestFixture]
    class HandleException
    {
        IWebDriver driver = new ChromeDriver();
        [Test, Category("ExceptionHandling")]
        public void Test1()
        {
           
            try
            {
                driver.Url = "https://www.google.com/";
                driver.FindElement(By.Name("abc")).SendKeys(" Testing");
                Thread.Sleep(2000);

            }
            catch (Exception er)
            {
               
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile(@"C:\Users\Default.Default-Laptop\Desktop\Testing projects\PracticeNunitFramwork\PracticeNunitFramwork\Screenshots\ss1.png", ScreenshotImageFormat.Png);
                Console.WriteLine(er.StackTrace);
                throw;
            
            }
            finally
            {
                driver.Quit();
            }
           
        }
        [Test, Category("ExceptionHandling")]
        public void Test2()
        {

            try
            {
                driver.Url = "http://www.google.com/";
                driver.FindElement(By.Name("q")).SendKeys(" Testing");
                Thread.Sleep(2000);

            }
            catch (Exception er)
            {
               
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile(@"C:\Users\Default.Default-Laptop\Desktop\Testing projects\PracticeNunitFramwork\PracticeNunitFramwork\Screenshots\ss2.png", ScreenshotImageFormat.Png);
                Console.WriteLine(er.StackTrace);
                throw;
            }
            finally
            {
                driver.Quit();
            }

        }
    }

}
