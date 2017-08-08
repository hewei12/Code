using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class ConcreteDataBaseFactory:AbstractFactory
    {
        public override DataBaseProduct GetDataBaseProduct()
        {
            return new ConcreteDataBaseProduct();    
        }

        public override TextProduct GetTextProduct()
        {
            return new ConcreteTextProduct();    
        }
    }
}
