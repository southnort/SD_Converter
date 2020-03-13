using System;
using System.Collections.Generic;
using System.Net;
using System.Data;
using System.IO;
using System.Globalization;


namespace SD_Converter
{
    public class LoadFilesController
    {

        public string GetTableText(string numbersText)
        {
            var table = GetTable(numbersText);
            return table.TableToString();
        }

        public DataTable GetTable(string numbersText)
        {
            var htmlNodes = new List<string>();
#if DEBUG
            var files = new List<string>()
            {
                "33222111ManageEngine ServiceDesk Plus.html",
                "332123ManageEngine ServiceDesk Plus.html",
                "442131ManageEngine ServiceDesk Plus.html",
                "ManageEngine ServiceDesk Plus4.html",
                "2212ManageEngine ServiceDesk Plus.html",
                "55412ManageEngine ServiceDesk Plus.html",
                "ManageEngine ServiceDesk Plus1.html",
                "ManageEngine ServiceDesk Plus3.html",
                "33213ManageEngine ServiceDesk Plus.html",
                "221ManageEngine ServiceDesk Plus.html",
                "ManageEngine ServiceDesk Plus7.html",
                "ManageEngine ServiceDesk Plus2.html",
                "ManageEngine ServiceDesk Plus5.html",
                "ManageEngine ServiceDesk Plus6.html",

            };

            foreach (var file in files)
            {
                htmlNodes.Add(
                    System.IO.File.ReadAllText(
                        Environment.GetFolderPath(Environment.SpecialFolder
                        .DesktopDirectory) + "\\" + file
                        )
                    );

            }

#else


            var urls = CreateURLs(numbersText);
            
            foreach (var url in urls)
            {
                htmlNodes.Add(GetRawHtml(url));
            }

#endif


            var constructor = new TableConstructor();
            var table = constructor.ConstructTable(htmlNodes);

            return table;

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

                var path = string.Format("{0}\\{2}\\{1}.html",
                        Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                        Guid.NewGuid().ToString(),
                        "HtmlFiles"
                        );

                File.WriteAllText(path, htmlCode);
                return htmlCode;
            }
        }




    }
}
