using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Data;
using HtmlAgilityPack;


namespace SD_Converter
{
    public class LoadFilesController
    {
        private WebClientEx client;





        public string SetAuthorization(string login, string password)
        {
            using (var _client = new WebClientEx())
            {
                var data = new NameValueCollection
                {
                    {"j_username",login },
                    {"j_password",password },

                };

                string address = "http://10.91.114.165:8080/j_security_check";
                var response = _client.UploadValues(address, data);
                client = _client;
                client.Encoding = Encoding.UTF8;

                return "OK";
            }
        }

        private string GetRawHtml(string url)
        {
            var htmlText = client.DownloadString(url);
            var document = new HtmlDocument();

            document.LoadHtml(htmlText);
            var descriptionPath = document.GetElementbyId("WORKORDERDESC_FRAME")
                .Attributes["src"].Value;
            if (descriptionPath != null || descriptionPath != string.Empty)
            {
                var description = client.DownloadString
                    (string.Format("{0}/{1}",
                    "http://10.91.114.165:8080", descriptionPath));

                string identifier = "<div id='descriptioninframe'>";

                htmlText += string.Format("{0}\n{1}\n{2}",
                    identifier,
                    description,
                    "</div>");
            }
            return htmlText;

        }



        public string GetTableText(string numbersText)
        {
            var table = GetTable(numbersText);
            return table.TableToString();
        }

        public DataTable GetTable(string numbersText)
        {
            var htmlNodes = new List<string>();
           

            var urls = CreateURLs(numbersText);

            var constructor = new TableConstructor();
            var table = constructor.CreateTable();

            foreach (var url in urls)
            {
                string html = GetRawHtml(url);
                var row = table.NewRow();
                var form = new EditNodeForm(html, table);

                form.ShowDialog();
                table.Rows.Add(form.Row);
            }
            
            return table;

        }


        private List<string> CreateURLs(string rawText)
        {
            var separators = new char[]
                {' ',',','.',';',':','\n','\t' };

            var arr = rawText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<string>();
            foreach (var item in arr)
                list.Add(
                   $@"http://10.91.114.165:8080/WorkOrder.do?woMode=viewWO&woID={item.Replace(" ", "")}&&fromListView=true"
                    );

            return list;
        }

    }
}
