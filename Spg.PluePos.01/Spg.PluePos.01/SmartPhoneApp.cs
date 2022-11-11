using System;
using System.Collections.Generic;
using Spg.PluePos._01.Model;

namespace Spg.PluePos._01
{
    //• Diese Klasse soll selbst zu einer Liste werden. Leite daher von der Klasse List ab.Achtung,
    //typisiere die Klasse List<>, auf den richtigen Datentyp!
    public class SmartPhoneApp : List<Post>
    {
        // Erstelle ein Default Property string SmartPhoneId.
        public string? SmartPhoneId { get; set; }
        public List<Post> posts { get; set; } = new();

        //• Erstelle einen Konstruktor, der den Parameter SmartPhoneId entgegennimmt.
        public SmartPhoneApp(string _smartPhoneId)
        {
            SmartPhoneId = _smartPhoneId;
            
        }
        //• Überschreibe die Add-Methode.Verwende dafür in der Methodensignatur das Keyword 
        //„new“ (public void new Add(…)). Sie soll nur Post in die Liste aufnehmen können, wenn der
        //Post nicht NULL ist.Es soll auch eine Referenz von SmartPhoneApp auf die Klasse Post gesetzt
        //werden.
        public new void Add(Post p)
        {
            
            if (p != null)
            {
                posts.Add(p);
                p.PostNavigation = this;
            }
           
            
        }

        
        //• Erstelle eine Methode ProcessPosts.Sie durchläuft alle Posts in der Liste und fügt alle HTMLAusgaben der einzelnen Posts zu einem kompletten String zusammen (mittels simplem
        //Concatenate) Der resultierende String soll anschließend zurückgegeben werden. (return…)
        public int CalcRating()
        {
            int rating = 0;
            foreach(Post p in this)
            {
                if(p != null)
                {
                    rating = p.Rating;
                        ;
                }
            }
            return rating;

        }
        //• Erstelle eine Methode CalcRating.Sie durchläuft alle Posts in der Liste und summiert alle
        //Ratings der einzelnen Posts auf. Das Ergebnis soll anschließend zurückgegeben werden.

        //• Erstelle einen Iterator, der anhand des Title einen Post zurückliefern kann. Der Aufruf würde
        //folgendermaßen aussehen: “posts["TextPost 6"]?.Html“. Kann der Post nicht in der
        //Liste gefunden werden, soll null zurückgegeben werden.

    }
}