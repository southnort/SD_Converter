using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Converter
{
    public class DataLoader
    {
        private WebClientEx webClient;

        public DataLoader(WebClientEx client)
        {
            webClient = client;
        }


        private string GetRawData(string requestString)
        {
            var response = webClient.DownloadString(requestString);

            return response;


        }

    }
}
