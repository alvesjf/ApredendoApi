using System;
using System.IO;
using System.Net;
using System.Text;

namespace TesteSpotify
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://swapi.co/api/planets/3/";
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            System.IO.StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            Console.WriteLine(result);

            Console.ReadKey();
        }
            

    }
}
