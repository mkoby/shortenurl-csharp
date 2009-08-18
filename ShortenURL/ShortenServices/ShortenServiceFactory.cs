namespace ShortenURL
{
    public class ShortenServiceFactory
    {
        static public IShortenService GetShortenService(string selectedItemText)
        {
            IShortenService Output = null;

            switch (selectedItemText)
            {
                case "bit.ly":
                    Output = new bitly();
                    break;
                case "is.gd":
                    Output = new isgd();
                    break;
                case "Su.pr":
                    Output = new Supr();
                    break;
                case "TinyURL":
                    Output = new TinyURL();
                    break;
                case "tr.im":
                    Output = new trim();
                    break;
                default:
                    break;
            }

            return Output;
        }
    }
}
