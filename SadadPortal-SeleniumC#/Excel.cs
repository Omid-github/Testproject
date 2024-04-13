using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Threading;
using System.Collections;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
//using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;

namespace Selenium
{
    public class Test_Data
    {
        //public IWebDriver driver;
        //static void ssss()
        //{

        //}
        public IWebDriver driver;
     
        //}
        // [Test, Order(2)]
        public class TestData
        {
            public string UserName { get; set; }
            public string Password { get; set; }

            public string Cardacqid { get; set; }
            public string TerminalID { get; set; }
         
        }
        public List<TestData> MainTest()
        {

            XSSFWorkbook wb;
            using (FileStream file = new FileStream(@"C:\Users\oostadhaji\test.xlsx", FileMode.Open, FileAccess.Read))
            {
                wb = new XSSFWorkbook(file);
            }
            ISheet sheet = wb.GetSheet("MySheet");

            var MyTestData = new List<TestData>();

            for (int i = 1; i <= sheet.LastRowNum; i++)
            {
                var currentRow = sheet.GetRow(i);
                MyTestData.Add(new TestData
                {
                    UserName = currentRow.GetCell(0).StringCellValue,
                    Password = currentRow.GetCell(1).StringCellValue,
                    Cardacqid = currentRow.GetCell(2).StringCellValue,
                });
            }

            return MyTestData;

        }
        ///////////Inheritance for other scripts
        /////---------------------------------------
        //var excelObject = new Test_Data();
        //var excel = excelObject.MainTest();
        //UserName.SendKeys(excel[0].UserName);
        //{ 
       // ----------------------------------------

        //DataTable dt = new DataTable();
        //dt.Columns.Add("City", typeof(string));
        //dt.Columns.Add("State", typeof(string));
        //dt.Columns.Add("Zip", typeof(string));

        //using (FileStream stream = new FileStream(@"C:\Working\FieldedAddresses.xlsx", FileMode.Open, FileAccess.Read))
        //{
        //    IWorkbook wb = new XSSFWorkbook(stream);
        //    ISheet sheet = wb.GetSheet("Sheet1");
        //    string holder;
        //    int i = 0;
        //    do
        //    {
        //        DataRow dr = dt.NewRow();
        //        IRow row = sheet.GetRow(i);
        //        try
        //        {
        //            holder = row.GetCell(0, MissingCellPolicy.CREATE_NULL_AS_BLANK).ToString();
        //        }
        //        catch (Exception)
        //        {
        //            break;
        //        }

        //        string city = holder.Substring(0, holder.IndexOf(','));
        //        string state = holder.Substring(holder.IndexOf(',') + 2, 2);
        //        string zip = holder.Substring(holder.IndexOf(',') + 5, 5);
        //        dr[0] = city;
        //        dr[1] = state;
        //        dr[2] = zip;
        //        dt.Rows.Add(dr);
        //        i++;
        //    } while (!String.IsNullOrEmpty(holder));
        //}

        //using (FileStream stream = new FileStream(@"C:\Working\FieldedAddresses.xlsx", FileMode.Create, FileAccess.Write))
        //{
        //    IWorkbook wb = new XSSFWorkbook();
        //    ISheet sheet = wb.CreateSheet("Sheet1");
        //    ICreationHelper cH = wb.GetCreationHelper();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        IRow row = sheet.CreateRow(i);
        //        for (int j = 0; j < 3; j++)
        //        {
        //            ICell cell = row.CreateCell(j);
        //            cell.SetCellValue(cH.CreateRichTextString(dt.Rows[i].ItemArray[j].ToString()));
        //        }
        //    }
        //    wb.Write(stream);
        //}













        //        string filepath = @"C:\Users\oostadhaji\test.xlsx";

        //        HSSFWorkbook hssfwb;

        //            using (FileStream file = new FileStream(filepath, FileMode.Open, FileAccess.Read))
        //            {
        //                hssfwb = new HSSFWorkbook(file);
        //    hssfwb.Write(file);
        //            }

        //ISheet sheet = hssfwb.GetSheetAt(0);
        //sheet

        //            for (int row = 0; row <= sheet.LastRowNum; row++)
        //            {
        //                if (sheet.GetRow(row) != null) //null is when the row only contains empty cells
        //                {
        //                    // Set new cell value
        //                    sheet.GetRow(row).GetCell(0).SetCellValue("omid");
        //Console.WriteLine("Row {0} = {1}", row, sheet.GetRow(row).GetCell(0).StringCellValue);
        //                }
        //            }

        //            // Save the file
        //            using (FileStream file = new FileStream(filepath, FileMode.Open, FileAccess.Write))
        //            {
        //                hssfwb.Write(file);
        //            }

        //            Console.ReadLine();


        //        }
        [TearDown, Order(3)]
        public void TearDown()
        {

            driver.Close();
            driver.Quit();

        }
    }

}





