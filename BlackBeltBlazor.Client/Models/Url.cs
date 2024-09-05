namespace BlackBeltBlazor.Client.Models
{
    public class Url
    {
        //public Url() { } // parameterless constructor is missing - cannot be serialized

        public Url(string url)
        {
            Uri uri = new Uri(url);
            Host = uri.Host;
        }

        public string Host { get; set; }
    }

}
