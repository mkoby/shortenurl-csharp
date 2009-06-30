using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace ShortenURL
{
    class TinyURL : IShortenService
    {
        private string _apiUrl;

        public TinyURL()
        {
            _apiUrl = "http://tinyurl.com/api-create.php";
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

            Output = WebRequestHelper.MakeShortenRequest(
                new Uri(String.Format("{0}?url={1}", _apiUrl, LongURL)));

            return Output;
        }
    }
}
