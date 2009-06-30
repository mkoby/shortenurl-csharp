using System;
using System.IO;
using System.Net;
using System.Text;

namespace ShortenURL
{
    public class WebRequestHelper
    {
        public static string MakeShortenRequest(Uri Url)
        {
            StringBuilder Output = new StringBuilder();

            WebRequest shortenRequest = WebRequest.Create(Url);
            shortenRequest.Method = "GET";
            WebResponse shortenResponse = null;
            StreamReader responseReader = null;

            try
            {
                shortenResponse = shortenRequest.GetResponse();
            }
            catch (WebException webex)
            {
                throw webex;
            }

            if (shortenResponse != null)
                responseReader = new StreamReader(shortenResponse.GetResponseStream(), Encoding.UTF8);

            if (responseReader != null)
            {
                Output.Append(responseReader.ReadToEnd());
            }

            return Output.ToString();
        }
    }
}