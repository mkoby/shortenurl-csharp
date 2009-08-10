using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ShortenURL
{
    class bitly : IShortenService
    {
        private string _apiUrl;
        private readonly string _apiKey = "R_3e9485fcdc00c97bba7f7e6ab146d452";
        private readonly string _returnFormat = "xml";
        private readonly string _bitlyLogin = "shortenurlcsharp";
        private readonly string _bitlyApiVersion = "2.0.1";

        public bitly()
        {
            _apiUrl = "http://api.bit.ly/";
        }

        public string APIUrl
        {
            get { return _apiUrl; }
        }

        public string ShortenURL(string LongURL)
        {
            string Output = String.Empty;
            Uri uri = new Uri(String.Format("{0}?apiKey={3}&login={4}&version={1}&format={2}&longUrl={5}", 
                "http://api.bit.ly/shorten", _bitlyApiVersion, _returnFormat, _apiKey, _bitlyLogin, LongURL));
            string requestOutput = WebRequestHelper.MakeShortenRequest(uri);
            Output = ParseBitlyXML(requestOutput);

            return Output;
        }

        private string ParseBitlyXML(string requestOutput)
        {
            //shortUrl
            if (String.IsNullOrEmpty(requestOutput))
                throw new Exception("Request to Bit.Ly returned an empty or null response");

            string Output = String.Empty;
            XElement element = XElement.Parse(requestOutput);
            var resultQuery = from c in element.DescendantsAndSelf("shortUrl")
                              select c;

            foreach (var result in resultQuery)
            {
                    Output = result.Value;
            }

            return Output;
        }
    }
}
