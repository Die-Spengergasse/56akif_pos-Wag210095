

namespace Blog
{
    public class ImagePost : Post //erben
    {
        public string? Url { get; set; }
        public ImagePost(string _title, string _html, string _url) : base(_title, _html)
        {
            Url = _url;
        }

        public ImagePost() : base()
        {
        }

        public override string Html
        {
            get
            {
                if (Url == null)
                {
                    throw new ArgumentNullException("Url war NULL!");
                }
                else
                {
                    return $"<h1>{Title}</h1><img src={Url} />";
                }
            }
        }

     


    }
}