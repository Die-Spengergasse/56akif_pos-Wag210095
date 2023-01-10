using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ExCollection.App;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, SchoolClass> schoolClasses = new Dictionary<string, SchoolClass>();
        schoolClasses.Add("3AHIF", new SchoolClass() { Name = "3AHIF", KV = "KV1" });
        schoolClasses.Add("3BHIF", new SchoolClass() { Name = "3BHIF", KV = "KV2" });
        schoolClasses.Add("3CHIF", new SchoolClass() { Name = "3CHIF", KV = "KV3" });
        schoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1001, Vorname = "VN1", Zuname = "ZN1", MinStudiendauer = 5});
        schoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1002, Vorname = "VN2", Zuname = "ZN2", MinStudiendauer = 3 });
        schoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1003, Vorname = "VN3", Zuname = "ZN3", MinStudiendauer = 5 });
        schoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1011, Vorname = "VN4", Zuname = "ZN4", MinStudiendauer = 7 });
        schoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1012, Vorname = "VN5", Zuname = "ZN5", MinStudiendauer = 5 });
        schoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1013, Vorname = "VN6", Zuname = "ZN6", MinStudiendauer = 2 });
        schoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1021, Vorname = "VN7", Zuname = "ZN7" ,MinStudiendauer = 5 });
        schoolClasses["3BHIF"].AddSchueler(new Teacher() { Id = 1021, Vorname = "VN7", Zuname = "ZN7" ,MinStudiendauer = 5 });

        Student s = schoolClasses["3AHIF"].Schuelers[0];
        Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");
        Console.WriteLine("3AHIF vor ChangeKlasse:");
        Console.WriteLine(JsonConvert.SerializeObject(schoolClasses["3AHIF"].Schuelers));
        s.ChangeKlasse(schoolClasses["3BHIF"]);
        Console.WriteLine("3AHIF nach ChangeKlasse:");
        Console.WriteLine(JsonConvert.SerializeObject(schoolClasses["3AHIF"].Schuelers));
        Console.WriteLine("3BHIF nach ChangeKlasse:");
        Console.WriteLine(JsonConvert.SerializeObject(schoolClasses["3BHIF"].Schuelers));
        Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");
        KuerzesteStudiendauer(schoolClasses["3AHIF"]);
        Console.WriteLine(schoolClasses["3AHIF"].Schuelers[1].FullName);
    }
    private static void KuerzesteStudiendauer(SchoolClass k)
    {
        //1. Initialisierung mit maxWert         
        //2. prüfen ob nächste Dauer kleiner od größer ist
        //2.1 wenn größer: nichts tun; nächster Schueler
        //2.2 wenn kleiner: überschreiben wir den ersten Wert mit der neuen Dauer
        int minWert = 7;
        foreach(Student item in k.Schuelers)
        {
            if(item.MinStudiendauer < minWert)
            {
                minWert = item.MinStudiendauer;
            }
        }
        Console.WriteLine($"kürzeste Dauer der {k?.Name ?? "unbekannte Klasse"} ist: {minWert}");//k? könnte null sein
    }
}