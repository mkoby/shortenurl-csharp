using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ShortenURL
{
    internal class trim : IShortenService
    {
        private string _apiUrl;

        public trim()
        {
            _apiUrl = "http://api.tr.im/api/trim_url.xml";
        }

        /// <summary>
        /// The API Url for the shortening service
        /// </summary>
        public string APIUrl
        {
            get { return _apiUrl; }
        }

        /// <summary>
        /// Shorten a URL
        /// </summary>
        /// <param name="LongURL">The long URL to shorten</param>
        /// <returns></returns>
        public string ShortenURL(string LongURL)
        {
            string Output = String.Empty;
            Uri uri = new Uri(String.Format("{0}?url={1}", _apiUrl, LongURL));
            Output = ParseXmlResponse(WebRequestHelper.MakeShortenRequest(uri));

            return Output;
        }

        private string ParseXmlResponse(string xmlResponse)
        {
            if (String.IsNullOrEmpty(xmlResponse))
                return String.Empty;

            string Output = String.Empty;
            XElement trimElement = XElement.Parse(xmlResponse);
            var elements = from e in trimElement.AncestorsAndSelf()
                           select e;

            foreach (var element in elements)
            {
                Output = (string)element.Element("url");
            }

            return Output;
        }
    }
}