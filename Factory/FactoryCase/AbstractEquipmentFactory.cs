using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCase
{
    abstract class AbstractEquipmentFactory
    {
        public abstract AbstractCar CreateAbstractCar();

        public abstract AbstractPackage CreateAbstractPackage();
    }
}
