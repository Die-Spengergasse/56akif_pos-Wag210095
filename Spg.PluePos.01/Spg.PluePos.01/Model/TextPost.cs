using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{

    //• Sie soll von der Klasse „Post“ erben.
    public class TextPost : Post
    {
         //o string Content(Default Property) Achtung! Nullable-Feature: Wähle die richtige
        //initialisierung.
        public string? Content { get; set; }
        //o int Length (gibt die Länge des Properties Content zurück. Ist Content NULL soll 0 
        //zurückgegeben werden. Verwende den null-coalesce-operator)
        public int Length
        {
            get
            {
                return Content?.Length ?? 0;
            }
        }

        //o string Html(Überschreibt das Property der Basisklasse.Es gibt den Inhalt der
        //Properties Titel und Content in folgender Form zurück: 
        //„<h1>{ Title}</h1><p>{Content
        //    }</p>“. Ist Content NULL, soll eine
        //ArgumentNullException mit der Meldung "Content war NULL!" geworfen werden.)

        public override string Html
        {
            get
            {
                if (Content != null)
                {
                    return $"<h1>{Title}</h1><p>{Content}</p>";
                }
                else
                    throw new ArgumentNullException("Content war Null!");

            }
           
        }
        //• Die Klasse soll 2 Konstruktoren enthalten, die jeweils den entsprechenden Konstruktor der
        //Basisklasse mit denselben Parametern aufrufen.
        public TextPost(string _title, DateTime _created) : base(_title, _created)
        {
        }

        public TextPost(string _title) : base(_title)
        {
        }
    }
}
