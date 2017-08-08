using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCase
{
    class ConcretePackage:AbstractPackage
    {
        private string color = "Red";
        private int size = 10;
        public override string Color
        {
            get
            {
                return color;    
            }
        }

        public override int Size
        {
            get
            {
                return size;    
            }
        }
    }
}
