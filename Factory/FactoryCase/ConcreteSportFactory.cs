using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCase
{
    class ConcreteSportFactory : AbstractEquipmentFactory
    {
        public override AbstractCar CreateAbstractCar()
        {
            return new ConcreteCar();
        }

        public override AbstractPackage CreateAbstractPackage()
        {
            return new ConcretePackage();
        }
    }
}
