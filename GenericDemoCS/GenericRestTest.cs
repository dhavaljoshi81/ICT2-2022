using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoCS
{
    class GenericRestTest<X> where X : IClassDesign
    {
        private X objX;
        public IClassDesign DataX 
        {
            get
            {
                return objX;
            }
            set
            {
                objX = (X) value;
            }
        }

        public void ShowDataforX()
        {
            objX.ShowData();
        }
    }
}
