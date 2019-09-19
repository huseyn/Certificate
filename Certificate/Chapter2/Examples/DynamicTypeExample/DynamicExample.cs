﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificate.Chapter2.Examples.DynamicTypeExample
{
    public class DynamicExample
    {
        static void DisplayInExcel(IEnumerable<dynamic> entities)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = true
            };
            excelApp.Workbooks.Add();
            dynamic workSheet = excelApp.ActiveSheet;
            workSheet.Cells[1, "A"] = "Header A";
            workSheet.Cells[1, "B"] = "Header B";
            var row = 1;
            foreach (var entity in entities)
            {
                row++;
                workSheet.Cells[row, "A"] = entity.ColumnA;
                workSheet.Cells[row, "B"] = entity.ColumnB;
            }
            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
        }

        static void Execute()
        {
            var entities = new List<dynamic> {
                            new
                            {
                            ColumnA = 1,
                            ColumnB = "Foo"
                            },
                            new
                            {
                            ColumnA= 2,
                            ColumnB= "Bar"
                            }
                            };
            DisplayInExcel(entities);
        }
    }
}