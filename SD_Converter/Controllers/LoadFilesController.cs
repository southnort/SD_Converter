using System;
using System.Collections.Generic;
using System.Net;


namespace SD_Converter
{
    public class LoadFilesController
    {

        public string GetTableText(string numbersText)
        {
            var urls = CreateURLs(numbersText);

            var htmlNodes = new List<string>();
            foreach (var url in urls)
            {
                htmlNodes.Add(GetRawHtml(url));
            }

            var constructor = new TableConstructor();
            var table = constructor.ConstructTable(htmlNodes);

            return table.ToString();
        }

        private List<string> CreateURLs(string rawText)
        {
            var separators = new char[]
                {' ',',','.',';',':' };

            var arr = rawText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<string>();
            foreach (var item in arr)
                list.Add(
                   $@"http://10.91.114.165:8080/WorkOrder.do?woMode=viewWO&amp;woID={item.Replace(" ", "")}&amp;&amp;fromListView=true"
                    );

            return list;
        }

        private string GetRawHtml(string url)
        {
            using (WebClient client = new WebClient())
            {
                var htmlCode = client.DownloadString(url);
                return htmlCode;
            }
        }



    }
}
