using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Threading;
using System;
using System.Drawing;
using System.Drawing.Imaging;

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
            driver.Manage().Window.Maximize();
            ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementsByName('firstname')[0].value='aman'");
            ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementsByName('lastname')[0].value='Lotey'");

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
            ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementByName('email').value='Lotey'");
             ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementByName('subject').value='testing'");
             ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementByName('message').value='one of the intern doing testing'");
          

           



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
        [TestMethod]
        public void HandleModelWindow()
        {
            driver.Url = "http://www.techintern.co.nz/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//div[@class='row']//div[1]//div[1]//div[1]//div[2]//div[1]//a[1]")).Click();
    
            var title = driver.FindElement(By.XPath("//h4[@id='exampleModalLabel']")).Text;
          
            Console.WriteLine(title);
         //driver.FindElement(By.XPath("//button[@class='btn btn-default']")).Click();
            // driver.FindElement(By.XPath("//button[@class='btn btn-default']")).Click();
            Thread.Sleep(2000);
            driver.Quit();
        }
    [TestMethod]
    public void HandleMultipleWindows()
        {
            driver.Url = "https://techexpozed.co.nz/index.php";
            driver.Manage().Window.Maximize();
            Console.WriteLine("status before click ");
           
            Console.WriteLine("opened Windows count  " + driver.WindowHandles.Count);
            foreach (var windowId in driver.WindowHandles)
            {
                Console.WriteLine("  " + windowId);
            }
            Console.WriteLine(" Current window Id: " + driver.CurrentWindowHandle);
            
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,document.body.scrollHeight);");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//li[2]//a[1]//img[1]")).Click();
            Console.WriteLine("status After  click ");

            Console.WriteLine("opened Windows count after click " + driver.WindowHandles.Count);
            foreach (var windowId in driver.WindowHandles)
            {
                Console.WriteLine("  " + windowId);
            }
            Console.WriteLine("Current window Id: " + driver.CurrentWindowHandle);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//a[contains(text(),'Support Service')]")).Click();
            driver.FindElement(By.XPath("//p[contains(text(),'Metlink offers 25% discounted travel on buses, tra')]//a//img")).Click();

            Console.WriteLine("status After  third click ");

            Console.WriteLine("opened Windows count after click " + driver.WindowHandles.Count);
            foreach (var windowId in driver.WindowHandles)
            {
                Console.WriteLine("  " + windowId);
            }
            Console.WriteLine("Current window Id: " + driver.CurrentWindowHandle);

            driver.Close();
            Console.WriteLine("opened Windows count after click " + driver.WindowHandles.Count);
            foreach (var windowId in driver.WindowHandles)
            {
                Console.WriteLine("  " + windowId);
            }
            Console.WriteLine("Current window Id: " + driver.CurrentWindowHandle);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);

            Thread.Sleep(2000);
            driver.Quit();

        }
        [TestMethod]
        public void ScreenshotAPage()
        {
            driver.Url = "https://techintern.co.nz/";
            driver.Manage().Window.Maximize();
            ITakesScreenshot screenshot = driver as ITakesScreenshot;
            //screenshot.GetScreenshot().SaveAsFile("techintern.jpg");                  // default path for file   ..... bin folder in the 
            screenshot.GetScreenshot().SaveAsFile("C:\\Users\\Default.Default-Laptop\\Desktop\\Testing projects\\SeleniumJavascriptDemo\\SeleniumJavascriptDemo\\ScreenShot\\techintern.png", ScreenshotImageFormat.Png );

            Thread.Sleep(2000);
            driver.Quit();
        }
        [TestMethod]
        public void SpecificElementScreenShot()
        {
            
            
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize();
            IWebElement element = driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div[1]/div/img"));
            ScreenShot(driver, element);
            ScreenShot(driver, driver.FindElement(By.XPath("//*[@id='blueBarDOMInspector']/div/div/div")));
            driver.Quit();

        }
        public void ScreenShot(IWebDriver driver, IWebElement element)
        {
            var filename = @"C:\Users\Default.Default-Laptop\Desktop\Testing projects\SeleniumJavascriptDemo\SeleniumJavascriptDemo\ScreenShot\Screenshot2.png";
            ITakesScreenshot screenshot = driver as ITakesScreenshot;
            var byteArray = screenshot.GetScreenshot().AsByteArray;
            Bitmap bitmap = new Bitmap(new System.IO.MemoryStream(byteArray));
            Rectangle rectangle = new Rectangle(element.Location.X,element.Location.Y,element.Size.Width,element.Size.Height);
            bitmap = bitmap.Clone(rectangle, bitmap.PixelFormat);
            bitmap.Save(String.Format(filename, ImageFormat.Jpeg));

      
        }


    }

}
