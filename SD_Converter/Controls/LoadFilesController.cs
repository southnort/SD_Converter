using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Data;


namespace SD_Converter
{
    public class LoadFilesController
    {
        private CookieContainer cookieContainer;


        public string SetAuthorization(string login, string password)
        {
            try
            {
                cookieContainer = new CookieContainer();

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://10.91.114.165:8080/j_security_check");
                //set the cookie container object
                request.CookieContainer = cookieContainer;
                request.Host = "10.91.114.165:8080";
              //  request.Connection = "keep-alive";
                request.ContentType = "application/x-www-form-urlencoded";
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.132 Safari/537.36";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                request.Referer = "http://10.91.114.165:8080/HomePage.do?logout=true&logoutSkipNV2Filter=true";

                //set method POST and content type application/x-www-form-urlencoded
                request.Method = "POST";

                //SET AUTOMATIC DECOMPRESSION
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

                //insert your username and password
                string data = string.Format("j_username={0}&j_password={1}"
                    + "&domain=Local+Authentication&LDAPEnable=false&hidden=%D0%92%D1%8B%D0%B1%D0%B5%D1%80%D0%B8%D1%82%D0%B5+%D0%B4%D0%BE%D0%BC%D0%B5%D0%BD&hidden=%D0%94%D0%BB%D1%8F+%D0%B4%D0%BE%D0%BC%D0%B5%D0%BD%D0%B0&AdEnable=true&DomainCount=0&LocalAuth=No&LocalAuthWithDomain=No&dynamicUserAddition_status=true&localAuthEnable=true&logonDomainName=Local+Authentication&loginButton=%D0%92%D1%85%D0%BE%D0%B4&checkbox=checkbox"
                                                   , login, password);
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);

                request.ContentLength = bytes.Length;

                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(bytes, 0, bytes.Length);
                    dataStream.Close();
                }


                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        return sr.ReadToEnd();
                    }
                }               
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        private string GetRawHtml(string url)
        {
            HttpWebRequest request =
                (HttpWebRequest)HttpWebRequest.Create(url);
            request.CookieContainer = cookieContainer;
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(url);

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(bytes, 0, bytes.Length);
                dataStream.Close();
            }

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    return sr.ReadToEnd();
                }
            }



        }



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

    }
}
