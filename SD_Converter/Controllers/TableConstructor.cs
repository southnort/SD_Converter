using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HtmlAgilityPack;


namespace SD_Converter
{
    public class TableConstructor
    {
        public DataTable ConstructTable(List<string> htmlNodes)
        {
            var table = CreateTable();
            foreach (var node in htmlNodes)
            {
                var row = table.NewRow();
                row["Number"] = GetNumber(node);
                row["FormNumber"] = GetFormNumber(node);
                row["Description"] = GetDescription(node);
                row["SDNumber"] = GetSDNumber(node);
                row["Status"] = GetStatus(node);
                row["CreationDate"] = GetCreationDate(node);
                row["CompleteDate"] = GetCompleteDate(node);
                row["Parent"] = GetParent(node);
                row["Organisation"] = GetOrganisationName(node);
                row["ClientFIO"] = GetClientFIO(node);
                row["BFTFIO"] = GetBFTFIO(node);
                row["Comment"] = GetComment(node);
            }

            return table;
        }

        private DataTable CreateTable()
        {
            // Create new DataColumn, set DataType, 
            // ColumnName and add to DataTable.    
            DataTable table = new DataTable();
            DataColumn column;            
                        
            column = new DataColumn("Number", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("FormNumber", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("Description", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("SDNumber", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("Status", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("CreationDate", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("CompleteDate", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("Parent", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("Organisation", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("ClientFIO", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("BFTFIO", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("Comment", typeof(string));
            table.Columns.Add(column);

            return table;
        }

        private string GetNumber(string node)
        {
        }

        private string GetFormNumber(string node)
        {
        }

        private string GetDescription(string node)
        {
        }

        private string GetSDNumber(string node)
        {
        }

        private string GetStatus(string node)
        {
        }

        private string GetCreationDate(string node)
        {
        }

        private string GetCompleteDate(string node)
        {
        }

        private string GetParent(string node)
        {

        }

        private string GetOrganisationName(string node)
        {
        }

        private string GetClientFIO(string node)
        {
        }

        private string GetBFTFIO(string node)
        {
        }

        private string GetComment(string node)
        {
        }

    }
}
