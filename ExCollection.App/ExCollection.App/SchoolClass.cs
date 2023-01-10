namespace ExCollection.App
{
    class SchoolClass
    {
        // TODO: Erstelle ein Property Schuelers, welches alle Schüler der Klasse in einer
        //       Liste speichert.
        public string? Name { get; set; }
        public string? KV { get; set; }
        public List<Student> Schuelers { get; set; } = new();
      
    

    /// <summary>
    /// Fügt den Schüler zur Liste hinzu und setzt das Property KlasseNavigation
    /// des Schülers korrekt auf die aktuelle Instanz.
    /// </summary>
    /// <param name="s"></param>
    public void AddSchueler(Person s)
        {
            if (Schuelers.Contains(s))
            {
                throw new ArgumentException("Schüler war schon da!");
            }
            // HIER DEN CODE EINFÜGEN
            Student? student = s as Student;
            if (s != null)
            {
                Schuelers.Add(s);
                student.KlasseNavigation = this;
            }
            else
                throw new ArgumentNullException("Schüler war leer!");
        }
    }
}