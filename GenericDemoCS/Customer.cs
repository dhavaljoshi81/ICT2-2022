using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoCS
{
    class Customer : IClassDesign
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public void ShowData()
        {
            Console.WriteLine("This is ShowData from Customer");
            Console.WriteLine("Customer : ID = " + CustomerId + " Name =" + Name);
        }
    }
}
