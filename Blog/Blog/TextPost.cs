
using Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blog
{

    public class TextPost : Post //erben
    {
        public string? Content { get; set; } //default props

        public int Length
        {
            get { return Content?.Length ?? 0; } // Content?. !=null -> length Content == null -> ?? -> schreibe 0;

        }
        [JsonIgnore]
        public Post PostNavigation { get; set; } = new();


        public TextPost(string _title, string _html, string _content) : base(_title, _html) // :base (x,y) übernimmt die Parameter aus der Basisklasse
        {
            Content = _content;
        }

        public TextPost() : base()
        {

        }

        public override string Html// override string Methode in der Basisklasse
        {
            get
            {
                if (Content != null)
                {
                    return $"<h1>{Title}</h1><p>{Content}</p>";
                }
                else
                    throw new ArgumentNullException("Content war Null!");
                //if (Content == null)
                //{
                //    throw new ArgumentNullException("Content war NULL!");
                //}
                //else
                //{
                //    return $"<h1>{Title}</h1><p>{Content}</p>";
                //}
            }
        }



    }
}