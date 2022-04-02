using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoCS
{
    class GenericTestTwo
    {
        public void ShowData<U>(U x)
        {
            Console.WriteLine(x);
        }

        public void ShowData<Y,Z>(Y x)
        {

        }

        public void ShowData<Y, Z>(Y x, Z z)
        {

        }

        //public K GetUpdatedData<K>(K v)
        //{

        //}
    }
}
