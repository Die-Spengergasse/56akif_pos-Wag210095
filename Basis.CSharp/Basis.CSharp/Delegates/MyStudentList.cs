using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basis.CSharp.Delegates
{
    public class MyStudentList : List<Student>
    {
        public List<Student> Filter(string PartOfLastName)
        {
            List<Student> list = new List<Student>();
            foreach(Student item in this)
            {

            }
        }
    }
}
