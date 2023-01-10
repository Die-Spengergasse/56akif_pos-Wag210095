using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basis.CSharp.Delegates
   
{
    public delegate bool CompareHandler(int a, int b);
    public class OldSchool
    {
        public bool GreatMethodForNearlyEverything(CompareHandler handler,  int x, int y)
        {
            // ...
            // 1000 Zeilen Code (z.B. irgendweche Vorbereitungen werden duhgeführt)
            // ...

            bool result = handler(x, y);

            if (result == true)
        {
            //do sth
        }
        else
        {
            // do sth
        }
        // ...
        // 1000 Zeilen Code (z.B. result wird irgendwie verarbeitet)
        // ...
        return result;

        
        }

        public bool CompareGreater(int x, int y)
        {
            return x == y;
        }
    }
    //public bool CompareEqual(int x, int y)
    //{
    //    //if (x == y)
    //    //    return true;
    //    //else
    //    //    return false; 
       
    //    return x == y;
        
    //} 
    //public void DoSomeWork()
    //{
    //    Console.WriteLine(GreatMethodeForNearlyEverything(CompareEqual, 5, 12));
    //}
}
