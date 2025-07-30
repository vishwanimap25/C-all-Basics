using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;


namespace PracticeQuestions
{
    internal class Program1
    {
        public static void Main1()
        {
            var filePath = @"C:\Users\Nimap\Downloads\Stock.xlsx";

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);  // First worksheet (1-based index)
                int rowCount = worksheet.LastRowUsed().RowNumber();
                int columnCount = worksheet.LastColumnUsed().ColumnNumber();

                for (int row = 2; row <= rowCount; row++)
                {
                    string empNo = worksheet.Cell(row, 2).GetString(); //Column B
                    string name = worksheet.Cell(row, 3).GetString(); //Column C
                    Console.WriteLine($"Emp#: {empNo}, Name: {name}");
                }
            }
        }
    }
}
