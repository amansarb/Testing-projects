using NUnit.Framework;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace PracticeNunitFramwork
{
    [TestFixture]
    class DataDriven
    {
        [Test, Category("DataDriven")]
        [TestCaseSource("Data")]
        public void DataDrivenArray(String urlText)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = urlText;
            Thread.Sleep(2000);
            driver.Quit();

        }

        static IList Data()
        {
            ArrayList List = new ArrayList();

            List.Add("https://www.facebook.com/");
            List.Add("https://www.gmail.com/");
            List.Add("https://www.google.com/");
            List.Add("https://www.youtube.com/");
            return List;
        }
        [Test, Category("DataDriven")]
        [TestCaseSource("ReadExcel")]
        public void DataDrivenExcel(String urlText)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = urlText;
            Thread.Sleep(2000);
            driver.Quit();

        }
        public static IEnumerable<object[]> ReadExcel()
        {
            using (ExcelPackage package = new ExcelPackage(new FileInfo("Sheet.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int rowCount = worksheet.Dimension.End.Row;
                for (var i = 2; i <= rowCount; i++)
                {
                    yield return new object[]
                        {worksheet.Cells[i,1].Value?.ToString().Trim(),
                        };
                }
            }
        }

    }
}
