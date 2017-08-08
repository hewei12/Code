using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCarPhoneCase
{
    abstract class AbstractMakeFactory
    {
        public abstract AbstractCar CreateCar();

        public abstract AbstractMobile CreateMobile();

    }
}
