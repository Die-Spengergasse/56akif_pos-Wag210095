using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPG.Parsable.Demo
{
    public static class StringExtensions//ExtensionsMethods sind immer statisch
    {
        public static int CountWords(this string s)
        {
            return s.Split(' ').Length;
        }

        public static T Parse<T>(this string s)// der Typ T ist nur dann akzeptiert wenn T IParsable implementiert 
            where T : IParsable<T>// und die Bedingung erfüllt
        {
            return T.Parse(s, null);
        }
    }
}
