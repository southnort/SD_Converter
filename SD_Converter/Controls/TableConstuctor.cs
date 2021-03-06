﻿using System;
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
        //public DataTable ConstructTable(List<string> htmlNodes)
        //{
        //    var table = CreateTable();
        //    foreach (var node in htmlNodes)
        //    {
        //        var row = table.NewRow();
        //        row["Number"] = GetNumber(node);
        //        row["FormNumber"] = GetFormNumber(node);
        //        row["SDNumber"] = GetSDNumber(node);
        //        row["Status"] = GetStatus(node);
        //        row["CreationDate"] = GetCreationDate(node);
        //        row["CompleteDate"] = GetCompleteDate(node);
        //        row["ClientFIO"] = GetClientFIO(node);
        //        row["Email"] = GetEmail(node);
        //        row["BFTFIO"] = GetBFTFIO(node);
        //        row["Comment"] = GetComment(node);

        //        row["Description"] = GetDescription(node);
        //      //  row["Organisation"] = GetOrganisationName(node);
        //        row["Parent"] = GetParent(node);

        //        table.Rows.Add(row);
        //    }

        //    return table;
        //}

        public DataTable CreateTable()
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




        public string GetNumber(string node)
        {
            return "";
        }

        public string GetFormNumber(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);

            var theme = document.GetElementbyId("requestSubject_ID").InnerText;
            var description = document.GetElementbyId("WORKORDERDESC_FRAME").InnerText;

            var inputString = string.Format("{0} {1}", theme, description);

            List<string> patterns = new List<string>
            {
                @"0503[0-9]{3,3}[\S]*",
                @"[ф]?[.]?[ ]?[0-9]{3}",
                @"Аренда[ -_]?[УБП]?[НУБП]*",
            };


            foreach (var pattern in patterns)
            {
                Regex regex = new Regex(pattern);
                string result;
                foreach (var str in inputString)
                {
                    if (regex.IsMatch(inputString))
                    {
                        result = regex.Match(inputString).Value.ToLower()
                            .Replace("ф", "")
                            .Replace(" ", "")
                            .Replace(".", "");

                        if (result.Length == 3)
                            result = "0503" + result;

                        return result;
                    }
                }
            }

            return "СводСмарт";
        }

        public string GetTheme(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);

            var theme = document
                .GetElementbyId("requestSubject_ID")
                .InnerText.Replace("&quot;", "\"");

            return theme;
        }


        public string GetDescription(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);

            var descriptionNode = document
                .GetElementbyId("descriptioninframe");

            var descriptionText = descriptionNode
                .InnerText.Replace("&quot;", "\"");

            return descriptionText;
        }

        //public string[] GetDescriptionNodes(string node)
        //{
        //    var document = new HtmlDocument();
        //    document.LoadHtml(node);

        //    var theme = document.GetElementbyId("requestSubject_ID").InnerText;
        //    var descriptionNode = document.GetElementbyId("descriptioninframe");

        //    var descriptionText = descriptionNode
        //        .InnerText;

        //    return (descriptionText + theme)
        //        .Split(new char[] { '\n', },
        //        StringSplitOptions.RemoveEmptyEntries);
        //}

        public string GetSDNumber(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);
            return
                document.GetElementbyId("requestId").InnerText;
        }

        public int GetStatus(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);
            var value = document.GetElementbyId("status_PH").InnerText;

            if (value.Contains("Выполнена")) return 0;
            else return 1;
        }

        public string GetCreationDate(string node)
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

        public string GetCompleteDate(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);
            var n = document.GetElementbyId("Spot_COMPLETEDTIME");
            if (n != null)
                return DateTime.Parse(n.InnerText, CultureInfo.InvariantCulture)
                    .ToString("dd.MM.yyyy");

            else return "";
        }

        public string GetParent(string node)
        {
            return "";
        }

        //public string GetOrganisationName(string node)
        //{
        //    var descriptionNodes = GetDescriptionNodes(node);
        //    foreach (var st in descriptionNodes)
        //    {
        //        if (
        //            st.ToLower().Contains("организация") ||
        //            st.ToLower().Contains("бухгалтер")
        //            )
        //            return st;
        //    }
        //    return "";
        //}

        public string GetClientFIO(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);
            var n = document.GetElementbyId("requesterName_PanelId");

            var value = n.Attributes["value"].Value;

            return value;
        }

        public string GetEmail(string node)
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
                .Replace("\n", "");
            return value;
        }

        public string GetBFTFIO(string node)
        {
            var document = new HtmlDocument();
            document.LoadHtml(node);
            var value = document.GetElementbyId("OWNERID_CUR").InnerText;
            if (value.Contains("Специалист ")) return "support";
            else if (value.Contains("Чубарых")) return "Чубарых О.В.";
            else
            {
                //Из полного ФИО собираем краткое ФИО
                StringBuilder sb = new StringBuilder();
                var separators = new char[] { ' ', '.' };
                var arr = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
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
