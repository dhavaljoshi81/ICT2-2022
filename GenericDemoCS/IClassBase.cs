using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoCS
{
    interface IClassBase<T>
    {
        void Display(T valueX);
        T ChangeValue();
    }
}
