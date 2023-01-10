using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPG.Parsable.Demo
{
    public class Person : IParsable<Person>
    {
       

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        protected Person()// damit DB kein leeres Objekt reinschreibt protected oder private
        {}

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public static Person Parse(string s, IFormatProvider? provider)
        {
            if (s is null)
            {
                throw new ArgumentNullException("Input war null!");
            }
            string[] result = s.Split(new char[]{',', ';', '\t'});
            if(result.Length != 3)
            {
                throw new ArgumentException("Input muss bestehen aus First/Lastname und Birthdate");
            }
            DateTime birthDate;
            if (!DateTime.TryParse(result[2], out birthDate))
            {
                throw new FormatException("Geb hat falsches Format");
            }
            return new Person(result[0].Trim(), result[1].Trim(), birthDate); //res [2]is birthdate geht nicht -> casten

        }

        
        public static bool TryParse(
            [NotNullWhen(true)] string? s, 
            IFormatProvider? provider,
            [MaybeNullWhen(false)] out Person result)
        {
            result = null;//res muss festgelegt werden weil in Signatur
            if(s is null)
            {
                return false;//throw new ArgumentException("darf nicht null sein");
            }
            try {//Exceptions selten nutzen überdeckt Programmfehler
                result =  Parse(s, provider);
                return true;
            }
            catch(Exception) {
                return false; 
            }
        }
    }
}
