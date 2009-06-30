namespace ShortenURL
{
    public interface IShortenService
    {
        /// <summary>
        /// The API Url for the shortening service
        /// </summary>
        string APIUrl { get; }

        /// <summary>
        /// Shorten a URL
        /// </summary>
        /// <param name="LongURL">The long URL to shorten</param>
        /// <returns></returns>
        string ShortenURL(string LongURL);
    }
}