using System;

namespace Blog
{
    public /*abstract*/ class Post
    {
        public string Title { get; set; } = string.Empty;
        public virtual string Html { get; set; } = string.Empty;
        public List<TextPost> texts { get; set; } = new();


        public Post(string _title, string _html)
        {
            Title = _title;
            //_title = title
            Html = _html;
        }


        public Post()
        {
            Title = string.Empty;
            Html = string.Empty;
            // Kann man auch leer lassen.
        }
        public void AddTextPost(TextPost t)
        {
            if (texts.Contains(t))
            {
                throw new ArgumentException("TextPost gibt es schon!");

            }
            else
                texts.Add(t);

        }

    }
}