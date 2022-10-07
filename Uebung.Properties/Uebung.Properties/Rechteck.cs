using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung.Properties
{
    public class Rechteck
    {
        private int _laenge;
        private int _breite;
        
       
        public int Laenge
        {
            get { return _laenge; }

            set
            {
                if (_laenge < 0)
                {
                    throw new ArgumentException("ungültige Länge!");
                }
            }
        }
        public int Breite {  get { return _breite; }

            set
            {
                if (_breite < 0)
                {
                    throw new ArgumentException("ungültige Länge!");
                }
            }
        }
        public int Flaeche {

         

            get { return _laenge*_breite; }


        }

    }

}
