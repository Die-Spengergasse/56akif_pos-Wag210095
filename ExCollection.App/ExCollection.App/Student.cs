using Newtonsoft.Json;

namespace ExCollection.App
{
    class Student : Person

    {
        

        // TODO: Erstelle ein Proeprty KlasseNavigation vom Typ Klasse, welches auf
        //       die Klasse des Schülers zeigt.
        // Füge dann über das Proeprty die Zeile
        // [JsonIgnore]
        // ein, damit der JSON Serializer das Objekt ausgeben kann.
        public int Id { get; set; }
        public int _maxStudiendauer;
        
        public int MinStudiendauer{
            get
            {
                return _maxStudiendauer;}

            set
            {//muss mind 1 -7 sein
                if (value >= 1 && value <= 7)
                {
                    _maxStudiendauer = value;
                }
                else
                    throw new ArgumentException("ungültige Dauer!");
            }
             }
        [JsonIgnore]
        public SchoolClass KlasseNavigation { get; set; } = new();
        
        public override string GetArrivalType()
        {
            return "reist mit dem Fahrrad";
        }

        /// <summary>
        /// Ändert die Klassenzugehörigkeit, indem der Schüler
        /// aus der alten Klasse, die in KlasseNavigation gespeichert ist, entfernt wird.
        /// Danach wird der Schüler in die neue Klasse mit der korrekten Navigation eingefügt.
        /// </summary>
        /// <param name="k"></param>
        public void ChangeKlasse(SchoolClass k)
        {
            // HIER DEN CODE EINFÜGEN
            KlasseNavigation.Schuelers.Remove(this);
            k.AddSchueler(this);// k.Schuelers.Add(this);
            //KlasseNavigation = k; das ist jetzt die neue Klasse
            
        }
    }

  
}