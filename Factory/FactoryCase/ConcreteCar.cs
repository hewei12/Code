using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCase
{
    class ConcreteCar:AbstractCar
    {
        private string type = "Sport";
        private decimal price = (decimal)0.11;

        public override string Name
        {
            get
            {
                return type;
            }
        }

        public override decimal Price
        {
            get
            {
                return price;    
            }
        }
    }
}
