using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GNN4PortfolioOptimizationClass
{
   public  class ExcelHelper
    {
         Microsoft.Office.Interop.Excel.Application xlApp;
  Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
  Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
         Microsoft.Office.Interop.Excel.Range chartRange;

  object misValue = System.Reflection.Missing.Value;
         
       public  bool CreateExcel (List<Po> pos)
       {
             xlApp = new Microsoft.Office.Interop.Excel.Application();
              xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            foreach (Po po in pos)
            {
                xlWorkSheet.Cells[po.Row, po.Column] = po.Value; 
            }
           

         xlWorkBook.SaveAs("C:\\newcat2", Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbookMacroEnabled);

         xlWorkBook.Close(true, misValue, misValue);
         xlApp.Quit();

         System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
         GC.Collect();
         GC.WaitForPendingFinalizers();
              return true;
       }
       

    }
}
