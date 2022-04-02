using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoCS
{
    class GenericFirstTest<T>
    {
        private T x;

        public T X 
        { 
            set
            {
                x = value;
            }
        }
        public void PrintData()
        {
            Console.WriteLine(x);
        }

        public T GetData()
        {
            return x;
        }


        public void ShowData<Y, Z>(Y x, Z z)
        {
            T v1;

        }
    }
}
