using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.OleDb;
using ClosedXML.Excel;

namespace ProjectStatus
{
    public class FileHanding
    {
        public MemoryStream TransferDataTableToExcel(DataTable dt)
        {
            var wb = new XLWorkbook();
            wb.Worksheets.Add(dt);
            MemoryStream ms = new MemoryStream();
            wb.SaveAs(ms);
            return ms;
        }

        public DataTable TransferExcelToDataTable(byte[] file)
        {
            Stream fileStream = new MemoryStream(file);
            var workbook = new XLWorkbook(fileStream);
            var xlWorksheet = workbook.Worksheet(1);
            return TransferExcelToDataTable(xlWorksheet);
        }

        public DataTable TransferExcelToDataTable(byte[] file, string sheetName)
        {
            Stream fileStream = new MemoryStream(file);
            var workbook = new XLWorkbook(fileStream);
            var xlWorksheet = workbook.Worksheet(sheetName);
            return TransferExcelToDataTable(xlWorksheet);
        }

        public DataTable TransferExcelToDataTable(string filePath)
        {
            var workbook = new XLWorkbook(filePath);
            var xlWorksheet = workbook.Worksheet(1);
            return TransferExcelToDataTable(xlWorksheet);
        }

        public DataTable TransferExcelToDataTable(string filePath, string sheetName)
        {
            var workbook = new XLWorkbook(filePath);
            var xlWorksheet = workbook.Worksheet(sheetName);
            return TransferExcelToDataTable(xlWorksheet);
        }

        private DataTable TransferExcelToDataTable(IXLWorksheet xlWorksheet)
        {
            var datatable = new DataTable();
            var range = xlWorksheet.Range(xlWorksheet.FirstCellUsed(), xlWorksheet.LastCellUsed());

            int col = range.ColumnCount();
            int row = range.RowCount();

            // add columns hedars
            datatable.Clear();

            for (int i = 1; i <= col; i++)
            {
                IXLCell column = xlWorksheet.Cell(1, i);
                datatable.Columns.Add(column.Value.ToString());
            }

            // add rows data
            int firstHeadRow = 0;
            foreach (var item in range.Rows())
            {
                if (firstHeadRow != 0)
                {
                    var array = new object[col];
                    for (int y = 1; y <= col; y++)
                    {
                        array[y - 1] = item.Cell(y).Value;
                    }
                    datatable.Rows.Add(array);
                }
                firstHeadRow++;
            }
            return datatable;
        }

        public IDataReader TransferExcelToIDataReader(byte[] file)
        {
            Stream fileStream = new MemoryStream(file);
            var workbook = new XLWorkbook(fileStream);
            var xlWorksheet = workbook.Worksheet(1);
            return TransferExcelToIDataReader(xlWorksheet);
        }

        public IDataReader TransferExcelToIDataReader(byte[] file, string sheetName)
        {
            Stream fileStream = new MemoryStream(file);
            var workbook = new XLWorkbook(fileStream);
            var xlWorksheet = workbook.Worksheet(sheetName);
            return TransferExcelToIDataReader(xlWorksheet);
        }

        public IDataReader TransferExcelToIDataReader(string filePath)
        {
            var workbook = new XLWorkbook(filePath);
            var xlWorksheet = workbook.Worksheet(1);
            return TransferExcelToIDataReader(xlWorksheet);
        }

        public IDataReader TransferExcelToIDataReader(string filePath, string sheetName)
        {
            var workbook = new XLWorkbook(filePath);
            var xlWorksheet = workbook.Worksheet(sheetName);
            return TransferExcelToIDataReader(xlWorksheet);
        }

        private IDataReader TransferExcelToIDataReader(IXLWorksheet xlWorksheet)
        {
            var datatable = new DataTable();
            var range = xlWorksheet.Range(xlWorksheet.FirstCellUsed(), xlWorksheet.LastCellUsed());

            int col = range.ColumnCount();
            int row = range.RowCount();

            // add columns hedars
            datatable.Clear();

            for (int i = 1; i <= col; i++)
            {
                IXLCell column = xlWorksheet.Cell(1, i);
                datatable.Columns.Add(column.Value.ToString());
            }

            // add rows data
            int firstHeadRow = 0;
            foreach (var item in range.Rows())
            {
                if (firstHeadRow != 0)
                {
                    var array = new object[col];
                    for (int y = 1; y <= col; y++)
                    {
                        array[y - 1] = item.Cell(y).Value;
                    }
                    datatable.Rows.Add(array);
                }
                firstHeadRow++;
            }
            return datatable.CreateDataReader();
        }

        public MemoryStream TransferDataTableToCsv(DataTable dt)
        {
            MemoryStream ms = new MemoryStream();
            StreamWriter result = new StreamWriter(ms, Encoding.UTF8);

            //Header
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                result.Write(dt.Columns[i].ColumnName);
                result.Write(i == dt.Columns.Count - 1 ? "\n" : ",");
            }

            //Content
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    result.Write(row[i].ToString());
                    result.Write(i == dt.Columns.Count - 1 ? "\n" : ",");
                }
            }

            return ms;
        }

        public DataTable TransferCsvToDataTable(string strFilePath)
        {
            string strFileName = Path.GetFileName(strFilePath);
            string strFileDirectory = Path.GetDirectoryName(strFilePath);
            string strConn = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}\;Extended Properties='Text;HDR=Yes;'", strFileDirectory);
            string strSQL = string.Format("SELECT * FROM [{0}]", strFileName);
            OleDbDataAdapter adapter = new OleDbDataAdapter(strSQL, strConn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}