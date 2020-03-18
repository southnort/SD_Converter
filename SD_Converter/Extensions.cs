using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace SD_Converter
{
    public static class Extensions
    {
        public static string TableToString(this DataTable table)
        {
            var sb = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                foreach (var col in row.ItemArray)
                {
                    sb.Append((string)col);
                    sb.Append("\t");
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }

        public static string ToCsv(this DataTable dataTable)
        {
            var sb = new StringBuilder();
            if (dataTable.Columns.Count < 1) return null;

            foreach (var col in dataTable.Columns)
            {
                if (col == null)
                    sb.Append(",");
                else
                    sb.Append("\"" + col.ToString().Replace("\"", "\"\"") + "\",");
            }
            sb.Replace(",", Environment.NewLine, sb.Length - 1, 1);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var col in row.ItemArray)
                {
                    if (col == null)
                        sb.Append(",");
                    else
                        sb.Append("\"" + col.ToString().Replace("\"", "\"\"") + "\",");
                }
                sb.Replace(",", Environment.NewLine, sb.Length - 1, 1);
            }


            return sb.ToString();
        }

        

        //public static string ToCsv(this DataTable dataTable)
        //{
        //    using (DataGridView dataGrid = new DataGridView())
        //    {
        //        IDataObject objectSave = Clipboard.GetDataObject();
        //        dataGrid.DataSource = dataTable.Rows;
        //        //dataGrid.ClipboardCopyMode = 
        //        //    DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
        //        dataGrid.RowHeadersVisible = false;
        //        dataGrid.SelectAll();

        //        var data = dataGrid.GetClipboardContent();

        //        //var result = dataGrid.GetClipboardContent();
        //        //Clipboard.SetDataObject(result);

        //        return data.GetData("Csv") as string;
        //    }
        //}

    }


}
