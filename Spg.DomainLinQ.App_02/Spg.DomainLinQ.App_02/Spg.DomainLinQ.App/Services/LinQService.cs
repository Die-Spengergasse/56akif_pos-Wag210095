﻿using Microsoft.EntityFrameworkCore.Query.Internal;
using Spg.DomainLinQ.App.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Services
{
    /// <summary>
    /// (8P)
    /// </summary>
    public class LinQService
    {
        private readonly Shop2000Context _db;
        public LinQService(Shop2000Context db)
        {
            _db = db;
        }

        public void Start()
        {
            //    // Gebe jenen User mit der ID=8 zurück.
            //    var result01 = _db.Users.SingleOrDefault(u => u.RegistrationNumber == 8);
            //    //Console.WriteLine($"Anzahl Datensätze 01: {result01.Count()}");

            //    // Erstelle eine Liste aller User, deren Nachname mit A beginnt.
            //    //var result02 = 
            //    Console.WriteLine($"Anzahl Datensätze 02: {result02.Count()}");

            //    // Erstelle eine Liste aller Produkte, die keinen Preis eingetragen haben.
            //    var result03 = string.Empty;
            //    Console.WriteLine($"Anzahl Datensätze 03: {result03.Count()}");

            //    // Gib das Produkt mit dem kleinsten Preis zurück.
            //    var result04 = string.Empty;
            //    Console.WriteLine($"Anzahl Datensätze 04: {result04.Count()}");

            //    // Erstelle eine Liste aller User, deren Nachname mit C beginnt
            //    // und denen keine Produkte zugeordnet sind.
            //    var result05 = string.Empty;
            //    Console.WriteLine($"Anzahl Datensätze 05: {result05.Count()}");

            //    // Wieviele Produkte haben keinen einzigen Preis.
            //    var result06 = 0;
            //    Console.WriteLine($"Ergebnis 06: {result06}");

            //    // Wieviele Produkte liegen im Preissegment zwischen 1000€ und 1500€.
            //    var result07 = 0;
            //    Console.WriteLine($"Ergebnis  07: {result07}");
            //}
        }
    }
}
