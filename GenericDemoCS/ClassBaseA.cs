using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoCS
{
    class ClassBaseA : IClassBase<int>
    {
        public int ChangeValue()
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Display(int valueX)
        {
            throw new NotImplementedException();
        }
    }
}
