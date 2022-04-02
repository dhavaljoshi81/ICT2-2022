using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoCS
{
    class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public override string ToString()
        {
            return "ID : " + BookID + " Title : " + Title + " Amount : " + Amount; 
        }
    }
}
