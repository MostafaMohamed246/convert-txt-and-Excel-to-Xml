using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Project_File
{
    class Excel
    {
        string path="";
        _Application excal = new _Excel.Application ();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int sheet) {
            this.path = path;
            wb = excal.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public List<List<string>> readAll()
        {
            int countRows = ws.UsedRange.Rows.Count;//عدد الصفوف اللي استخدمت في ايكسل
            int countColumns = ws.UsedRange.Columns.Count;
            Range range = (Range)ws.Range[ws.Cells[1, 1], ws.Cells[countRows, countColumns]];
            object[,] holder = range.Value2;//عامل زي ال var
            List<List<string>> data = new List<List<string>>();

            for (int i = 1; i <= countRows; i++)
            {
                data.Add(new List<string>());
                for (int j = 1; j <= countColumns; j++)
                {
                    if (holder[i, j] == null)
                    {
                        data[i - 1].Add("");
                    }
                    else
                    {
                        data[i - 1].Add(holder[i, j].ToString());
                    }
                }
            }

            return data;
        }
    }
}
