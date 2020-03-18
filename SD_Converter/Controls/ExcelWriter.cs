using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ClosedXML.Excel;

namespace SD_Converter
{
    public class ExcelWriter
    {
        public void SaveTableToExcel(DataTable table, string filePath)
        {
            var dataSet = ConvertDataTableToDataSet(table);
            ExportToFile(dataSet, filePath);
        }

        private void ExportToFile(DataSet dataSet, string filePath)
        {
            var wb = new XLWorkbook();
            wb.Worksheets.Add(dataSet);

            wb.SaveAs(filePath);


        }

        private DataSet ConvertDataTableToDataSet(DataTable table)
        {
            DataTable resultTable = new DataTable();
            CreateHeaders(table, resultTable);

            foreach (DataRow row in table.Rows)
            {
                DataRow newRow = resultTable.NewRow();
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    DataColumn column = table.Columns[i];
                    newRow[i] = row[i].ToString();
                }
                resultTable.Rows.Add(newRow);
            }


            DataSet resultDataSet = new DataSet();
            resultDataSet.Tables.Add(resultTable);
            return resultTable.DataSet;
        }


        private void CreateHeaders(DataTable inputTable, DataTable resultTable)
        {
            List<string> names = new List<string>();
            foreach (DataColumn column in inputTable.Columns)
            {
                resultTable.Columns.Add(column.ColumnName, typeof(string));
                names.Add(column.ColumnName);
            }
            DataRow headerRow = resultTable.NewRow();
            headerRow.ItemArray = names.ToArray();
            resultTable.Rows.InsertAt(headerRow, 0);
        }

    }
}
