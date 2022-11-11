using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Spg.PluePos._01.Model
{
    //• Erstelle eine abstrakte Klasse „Post“ mit folgenden Properties:
    public abstract class Post
    {
        public int _rating;
        //o string Title(Default Property, Read Only)
        public virtual string Title { get; } = string.Empty;
        //o DateTime Created (Default Property, Read Only)
        public DateTime Created { get; }
        //o int Rating(Es darf nur ein Wert zwischen 1 und 5 gesetzt werden. Andernfalls soll
        //eine ArgumentOutOfRangeException mit der Meldung “Range muss zwischen 1 und 5 
        //liegen!" geworfen werden.)
        public int Rating
        {
            get
            { return _rating; }

            set

            {
                if (value >= 1 && value <= 5)
                {
                    _rating = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Range muss zwischen 1 und 5 liegen!");

            }

        }
        //o abstract string Html(Default Property, abstract, Read Only)
        public abstract string Html { get; }
        //o SmartPhoneApp SmartPhone (Default Property, Es soll eine Referenz auf die Liste
        //beinhalten) Achtung! Nullable - Feature: Wähle die richtige initialisierung.
        public List<SmartPhoneApp> Smartphone { get; set; } = new();
        public SmartPhoneApp PostNavigation { get; internal set; }

        //• Erstelle einen Konstruktor der die Parameter „title“ und „created“ entgegennimmt und damit 
        //die Properties befüllt. Titel darf nicht NULL sein. Ist das der Fall soll eine 
        //ArgumentNullException mit der Meldung „Titel war NULL!" geworfen werden.        
        public Post(string _title, DateTime _created)
        {
            if (_title == null)
                throw new ArgumentNullException("Titel war NULL");
            Title = _title;
            Created = _created;
        }
        //• Erstelle einen Konstruktor der den Parameter „title“ entgegennimmt und den vorherigen 
        //Konstruktor aufruft, um die Werte zu setzen. Für den Parameter „created“, verwende 
        //DateTime.Now.
        public Post(string _title) : this(_title, DateTime.Now)
        {
            Title = _title;

        }
        //• Überschreibe die ToString-Methode sodass der Inhalt des Properties HTML ausgegeben wird.
        public override string ToString()
        {
            return $"{Html}";
        }



    }

}
