using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoCS
{
    class Student : IClassDesign
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public void ShowData()
        {
            Console.WriteLine("This is ShowData from Student");
            Console.WriteLine("Student : ID = " + StudentID + " Name =" + Name);
        }
    }
}
