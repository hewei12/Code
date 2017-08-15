using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProdectCase
{
    public class Creator1:AbstractCreator
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();    
        }
    }
}
