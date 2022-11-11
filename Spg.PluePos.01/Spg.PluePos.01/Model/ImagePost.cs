using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    //• Sie soll von der Klasse „Post“ erben.
    public class ImagePost : Post
    {

        //o string Url(Default Property) Achtung! Nullable-Feature: Wähle die richtige Initialisierung.
        public string? Url { get; set; }
        //o string Html (Überschreibt das Property der Basisklasse. Es gibt den Inhalt der
        //Properties Titel und Url in folgender Form zurück: 
        //„<h1>{ Title}</h1><img src = { Url } />“. Ist Url NULL, soll eine ArgumentNullException
        //mit der Meldung "Url war NULL!" geworfen werden.)
        public string? _url;
        public override string Html
        {
            get
            {
                if (_url != null)
                { 
                    return $"<h1>{Title}</h1><img src ={Url} />";
                }
                else
                    throw new ArgumentNullException("URL war Null!");

            }

        }
        //• Die Klasse soll 2 Konstruktoren enthalten, die jeweils den entsprechenden Konstruktor der
        //Basisklasse mit denselben Parametern aufrufen.
        public ImagePost(string _title, DateTime _created) : base(_title, _created)
        {
        }
        public ImagePost(string _title) : base(_title)
        {
        }
    }
}
