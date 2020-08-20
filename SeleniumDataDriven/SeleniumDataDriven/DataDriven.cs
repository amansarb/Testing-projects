using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;
using SeleniumDataDriven.BaseClass;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OfficeOpenXml;
using System.IO;

namespace SeleniumDataDriven
{ 
 [TestClass]
    public class UnitTest1 : BasicTest
    {
        [TestMethod]
        public void TypicalFaceBookLogin()
        {
            driver.FindElement(By.Id("email")).SendKeys("john@test.com");
            driver.FindElement(By.Id("pass")).SendKeys("123456");
            Thread.Sleep(2000);
        }
        [TestMethod]
        public void TypicalFaceBookLogin2()
        {
            driver.FindElement(By.Id("email")).SendKeys(" mike@test.com");
            driver.FindElement(By.Id("pass")).SendKeys("123456");
            Thread.Sleep(2000);
        }
        [TestMethod]
        public void TypicalFaceBookLogin3()
        {
            driver.FindElement(By.Id("email")).SendKeys(" Paul@test.com");
            driver.FindElement(By.Id("pass")).SendKeys("123456");
            Thread.Sleep(2000);

        }
        [TestMethod]
        [DataRow("john@test.com", "123456")]
        [DataRow("Mike@test.com", "123456")]
        [DataRow("Richard@test.com", "123456")]
        public void DataRowMethod(string email, string password)
        {
            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("pass")).SendKeys(password);
            Thread.Sleep(3000);
        }
        [TestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void DataDrivenTestingUsingDayanmicData(string email, string password)
        {
            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("pass")).SendKeys(password);
            Thread.Sleep(3000);
        }
        public static IEnumerable<object[]> GetData()
        {
            // return (IEnumerable<object[]>)(new object[] { "aman.lotey@gmail.com", "gdgd" });
            yield return new object[] { "aman.lotey@gmail.com","68666" };
            yield return new object[] { "aman.lotey@gmail.com","123456" };
            yield return new object[] { "aman.lotey@gmail.com","123456" };
            yield return new object[] { "aman.lotey@gmail.com","123456" };
         }

        // DataDriven Testing Using Excel Sheets
       [TestMethod]
        [DynamicData(nameof(ReadExcel), DynamicDataSourceType.Method)]
        public void DataDrivenUsingExcelSheet(string email, string password)
        {
            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("pass")).SendKeys(password);
            Thread.Sleep(3000);

        }
        public static IEnumerable<object[]> ReadExcel()
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo("Sheet.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int rowCount = worksheet.Dimension.End.Row;
                for (var i=2;i<=rowCount; i++)
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
