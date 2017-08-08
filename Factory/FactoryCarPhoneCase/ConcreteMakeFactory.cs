using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCarPhoneCase
{
    class ConcreteMakeFactory:AbstractMakeFactory
    {
        public override AbstractMobile CreateMobile()
        {
            return new ConcreteNokia();    
        }

        public override AbstractCar CreateCar()
        {
            return new ConcreteOuDiCar();    
        }
    }
}
