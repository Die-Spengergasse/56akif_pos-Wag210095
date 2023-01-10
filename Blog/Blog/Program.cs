using Blog;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Blog {
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Post> posts = new Dictionary<string, Post>();
            posts.Add("1", new Post() { Title = "abc", Html = "xy" });
            posts.Add("2", new Post() { Title = "abc", Html = "xy" });
            posts.Add("3", new Post() { Title = "abc", Html = "xy" });
            posts["1"].AddTextPost(new TextPost() { Content = "abc", Title = "efarg"});
            posts["1"].AddTextPost(new TextPost() { Content = "ac", Title = "erg"});
            posts["1"].AddTextPost(new TextPost() { Content = "abc", Title = "efarg"});
            
            TextPost t = posts["1"].texts[0];
            Console.WriteLine($" content: {t.Content}, Titel: {t.Title}.");
            
        }

    }
}