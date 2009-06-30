using System;

namespace ShortenURL
{
    public class IsGd : IShortenService
    {
        private string _apiUrl;

        public IsGd()
        {
            _apiUrl = "http://is.gd/api.php";
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

            Uri url = new Uri(String.Format("{0}?longurl={1}", _apiUrl, LongURL));
            Output = WebRequestHelper.MakeShortenRequest(url);

            return Output;
        }
    }
}