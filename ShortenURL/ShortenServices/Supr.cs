using System;

namespace ShortenURL
{
    internal class Supr : IShortenService
    {
        private string _apiUrl;

        public Supr()
        {
            _apiUrl = "http://su.pr/api";
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
            String Output = String.Empty;
            Uri uri = new Uri(String.Format("{0}?url={1}", _apiUrl, LongURL));
            Output = WebRequestHelper.MakeShortenRequest(uri);

            return Output;
        }
    }
}
