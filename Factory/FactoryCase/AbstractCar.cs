using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCase
{
    abstract class AbstractCar
    {
        public abstract string Name { get; }

        public abstract decimal Price { get; }
    }
}
