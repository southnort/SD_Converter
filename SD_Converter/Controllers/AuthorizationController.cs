using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace SD_Converter
{
    public class AuthorizationController
    {       
        public CookieContainer CreateCookieContainer(string login, string password)
        {
            var cookieContainer = new CookieContainer();

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://wttv.click-tt.de/");
            request.CookieContainer = cookieContainer;
            //set the user agent and accept header values, to simulate a real web browser
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";


            //SET AUTOMATIC DECOMPRESSION
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                        
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }

            request = (HttpWebRequest)HttpWebRequest.Create("http://10.91.114.165:8080/j_security_check");
            //set the cookie container object
            request.CookieContainer = cookieContainer;
            request.Host = "10.91.114.165:8080";
            request.Connection = "keep-alive";
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

            Console.WriteLine("LOGIN RESPONSE");
            Console.WriteLine();
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }

            return request.CookieContainer;
        }

    }
}
