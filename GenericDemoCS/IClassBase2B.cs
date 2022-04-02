using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoCS
{
    interface IClassBase2B : IClassBase<string>
    {
        int GetDataById(int id);

    }

    interface IClassBase2C<T> : IClassBase<T>
    {
        T ShowValues();
    }
}
