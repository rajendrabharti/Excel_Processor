using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel;
using System.Data;
using System.IO;

namespace Excel_DataProcessor
{
    public class Excel_DataReader
    {
        public DataTable ReadExcelFile(string FilePath)
        {
            DataTable dt = null;
            if (!string.IsNullOrEmpty(FilePath))
            {
                FileStream stream = File.Open(FilePath, FileMode.Open, FileAccess.Read);

                //Choose one of either 1 or 2
                //1. Reading from a binary Excel file ('97-2003 format; *.xls)
                IExcelDataReader excelReader = null;
                if (FilePath.Contains(".xlsx"))
                    excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                else
                    if (FilePath.Contains(".xls"))
                {
                    excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                
                //DataSet - Create column names from first row
                excelReader.IsFirstRowAsColumnNames = true;
                DataSet result = excelReader.AsDataSet();
                if (result != null && result.Tables != null && result.Tables.Count > 0)
                {
                    dt = new DataTable();
                    dt = result.Tables[0];
                }
                excelReader.Close();
            }
            return dt;
        }
    }
}
