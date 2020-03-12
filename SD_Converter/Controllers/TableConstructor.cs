using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HtmlAgilityPack;
using System.Globalization;
using System.Text.RegularExpressions;


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
                row["Email"] = GetEmail(node);
                row["BFTFIO"] = GetBFTFIO(node);
                row["Comment"] = GetComment(node);

                table.Rows.Add(row);
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

            column = new DataColumn("Email", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("BFTFIO", typeof(string));
            table.Columns.Add(column);

            column = new DataColumn("Comment", typeof(string));
            table.Columns.Add(column);

            return table;
        }




        private string GetNumber(string node)
        {
            return "";
        }

        private string GetFormNumber(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);

            var theme = document.GetElementbyId("requestSubject_ID").InnerText;

            var descriptionArr = document.GetElementbyId("WORKORDERDESC_FRAME").InnerText
                .Split('\n');

            string pattern1 = @"[ф]?[.]?[ ]?[0-9]{3}";
            string pattern2 = @"0503[0-9]{3,3}[\S]*";

            Regex regex = new Regex();




            return "СводСмарт";
        }

        private string GetDescription(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);

            var theme = document.GetElementbyId("requestSubject_ID").InnerText;

            var descriptionArr = document.GetElementbyId("WORKORDERDESC_FRAME").InnerText
                .Split('\n');

            return "";
        }

        private string GetSDNumber(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);
            return
                document.GetElementbyId("requestId").InnerText;
        }

        private string GetStatus(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);
            var value = document.GetElementbyId("status_PH").InnerText;

            if (value.Contains("Выполнена")) return "Выполнено";
            else return "Зарегистрировано";
        }

        private string GetCreationDate(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);
            var value = document.GetElementbyId("CREATEDTIME_CUR").InnerText;

            try
            {
                return DateTime.Parse(value, CultureInfo.InvariantCulture).ToString("dd.MM.yyyy");
            }
            catch
            {
                return DateTime.Today.ToString("dd.MM.yyyy");
            }
        }

        private string GetCompleteDate(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);
            var n = document.GetElementbyId("Spot_COMPLETEDTIME");
            if (n != null)
                return DateTime.Parse(n.InnerText, CultureInfo.InvariantCulture)
                    .ToString("dd.MM.yyyy");

            else return "";
        }

        private string GetParent(string node)
        {
            return "";
        }

        private string GetOrganisationName(string node)
        {
            return "";
        }

        private string GetClientFIO(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);
            var n = document.GetElementbyId("requesterName_PanelId");

            var value = n.Attributes["value"].Value;

            return value;
        }

        private string GetEmail(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);
            var n = document.GetElementbyId("EMAILID_RCUR");
            if (n == null)
            {
                var a = document.DocumentNode
                    .SelectNodes("//td[contains(@class, 'rved-values')]");
                n = a[58];
            }

            var value = n.InnerText
                .Replace(" ", "")
                .Replace("\n","");
            return value;
        }

        private string GetBFTFIO(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);
            var value = document.GetElementbyId("OWNERID_CUR").InnerText;
            if (value.Contains("Специалист ")) return "support";
            else
            {
                //Из полного ФИО собираем краткое ФИО
                StringBuilder sb = new StringBuilder();
                var arr = value.Split(' ');
                sb.Append(arr[0]);
                sb.Append(" ");
                sb.Append(arr[1][0]);
                sb.Append(". ");
                sb.Append(arr[2][0]);
                sb.Append(".");

                return sb.ToString();
            }
        }

        private string GetComment(string node)
        {
            return "";
        }

    }
}
