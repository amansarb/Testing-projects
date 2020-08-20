using NUnit.Framework;
using OpenQA.Selenium;
using PracticeNunitFramwork.BasicClass;
using System.Threading;

namespace PracticeNunitFramwork
{
    public class Tests : BaseTestSetup
    {
        //[TearDown]

        [Test, Category("Integration Testing")]
        public void Test1()
        {

            driver.FindElement(By.Name("q")).SendKeys("testing");
            Thread.Sleep(2000);
        }
        [Test, Category("Smoke testing"), Order(2), Author("AMan"), Description(" testing google search")]
        public void Test2()
        {

            driver.FindElement(By.Name("q")).SendKeys("number 2");
            Thread.Sleep(2000);
        }

        [Test, Category("Smoke testing"), Order(0)]
        public void Test3()
        {
            Assert.Ignore(" Defect TS123");

            driver.FindElement(By.Name("q")).SendKeys("number 1");
            Thread.Sleep(2000);
            driver.Close();

        }
        [Parallelizable()]
        [Test, Category("Smoke testing"), Order(1)]
        public void Test4()
        {

            driver.FindElement(By.Name("q")).SendKeys("number3");
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
            driver.Close();


        }
        [Parallelizable()]
        [Test, Category("unit Testing")]
        public void Test5()
        {

            driver.FindElement(By.Name("q")).SendKeys("Regression Testing" + Keys.Enter); ;
            Thread.Sleep(2000);
            driver.Navigate().Back();
            driver.Close();

        }
        [Parallelizable()]
        [Test, Category("Regression"), Category("parallel")]
        public void Test6()
        {

            driver.FindElement(By.Name("q")).SendKeys("Regression Testing");
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
            driver.Close();

        }
    }
}
